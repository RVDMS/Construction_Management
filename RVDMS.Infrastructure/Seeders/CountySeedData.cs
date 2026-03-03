using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class CountySeedData
    {
        public static readonly List<County> Counties = new()
        {
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000001"),
                Name = "Trans-Nzoia",
                Code = "TNZ",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000002"),
                Name = "Uasin Gishu",
                Code = "UG",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000003"),
                Name = "Elgeyo Marakwet",
                Code = "EM",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000004"),
                Name = "Nandi",
                Code = "ND",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000005"),
                Name = "Kericho",
                Code = "KR",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000006"),
                Name = "Bomet",
                Code = "BM",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000007"),
                Name = "Nakuru",
                Code = "NK",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000008"),
                Name = "Narok",
                Code = "NR",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000009"),
                Name = "Baringo",
                Code = "BR",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000010"),
                Name = "Samburu",
                Code = "SB",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000011"),
                Name = "Turkana",
                Code = "TK",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new County
            {
                Id = Guid.Parse("20000000-0000-0000-0000-000000000012"),
                Name = "West Pokot",
                Code = "WP",
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            }
        };
    }
}
