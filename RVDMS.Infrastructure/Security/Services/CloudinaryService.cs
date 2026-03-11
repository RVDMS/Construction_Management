using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using RVDMS.Application.Interfaces;
using RVDMS.Infrastructure.Data.Cloudinary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Security.Services
{
    public class CloudinaryService : IFileService
    {
        private readonly Cloudinary _cloudinary;
        private readonly string[] _allowedExtensions = { ".pdf", ".xls", ".xlsx", ".xlsm" };
        private const long MaxFileSize = 10 * 1024 * 1024; // 10MB

        public CloudinaryService(IOptions<CloudinarySettings> config)
        {
            var account = new Account(
               config.Value.CloudName,
               config.Value.ApiKey,
               config.Value.ApiSecret
           );
            _cloudinary = new Cloudinary(account);
        }
        public async Task<bool> DeleteFileAsync(string filePath)
        {
            try
            {
                var uri = new Uri(filePath);
                var publicId = Path.GetFileNameWithoutExtension(uri.Segments.Last());

                var deleteParams = new DeletionParams(publicId)
                {
                    ResourceType = ResourceType.Raw // For PDF/Excel files
                };

                var result = await _cloudinary.DestroyAsync(deleteParams);
                return result.Result == "ok";
            }
            catch
            {
                return false;
            }
        }

        public long GetMaxFileSize() => MaxFileSize;
        

        public bool IsValidFileType(string fileName)
        {
            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            return _allowedExtensions.Contains(extension);
        }

        public async Task<string> UploadFileAsync(byte[] fileData, string fileName, string folder = "reports")
        {
            // Validate file type
            if (!IsValidFileType(fileName))
            {
                throw new InvalidOperationException(
                    $"Invalid file type. Allowed types: {string.Join(", ", _allowedExtensions)}"
                );
            }

            // Validate file size
            if (fileData.Length > MaxFileSize)
            {
                throw new InvalidOperationException(
                    $"File size exceeds maximum allowed size of {MaxFileSize / 1024 / 1024}MB"
                );
            }

            using var stream = new MemoryStream(fileData);

            // For PDF/Excel files, use Raw upload instead of Image
            var uploadParams = new RawUploadParams
            {
                File = new FileDescription(fileName, stream),
                Folder = folder,
                PublicId = $"{Guid.NewGuid()}_{Path.GetFileNameWithoutExtension(fileName)}",
                Overwrite = false
            };

            var uploadResult = await _cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
                throw new Exception($"Cloudinary upload failed: {uploadResult.Error.Message}");

            return uploadResult.SecureUrl.ToString();
        }
    }
}
