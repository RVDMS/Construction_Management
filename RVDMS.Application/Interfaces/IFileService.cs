using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Interfaces
{
    public interface IFileService
    {
        Task<string> UploadFileAsync(byte[] fileData, string fileName, string folder = "reports");
        Task<bool> DeleteFileAsync(string filePath);
        bool IsValidFileType(string fileName);
        long GetMaxFileSize();
    }
}
