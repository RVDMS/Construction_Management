using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class ConstituencySeedData
    {
        public static readonly List<Constituency> Constituencies = new()
        {
            // Trans-Nzoia
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000001"),
                Name = "Saboti",
                Code = "SBT",
                CountyId = CountySeedData.Counties[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000002"),
                Name = "Endebess",
                Code = "EDB",
                CountyId = CountySeedData.Counties[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000003"),
                Name = "Kiminini",
                Code = "KMN",
                CountyId = CountySeedData.Counties[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000004"),
                Name = "Turbo",
                Code = "TRB",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000005"),
                Name = "Soy",
                Code = "SOY",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000006"),
                Name = "Kapseret",
                Code = "KPS",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000007"),
                Name = "Kesses",
                Code = "KSS",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000008"),
                Name = "Moiben",
                Code = "MBN",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Elgeyo Marakwet
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000009"),
                Name = "Keiyo North",
                Code = "KYN",
                CountyId = CountySeedData.Counties[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000010"),
                Name = "Keiyo South",
                Code = "KYS",
                CountyId = CountySeedData.Counties[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000011"),
                Name = "Marakwet West",
                Code = "MKW",
                CountyId = CountySeedData.Counties[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000012"),
                Name = "Nandi Hills",
                Code = "NDH",
                CountyId = CountySeedData.Counties[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000013"),
                Name = "Chesumei",
                Code = "CHM",
                CountyId = CountySeedData.Counties[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000014"),
                Name = "Emgwen",
                Code = "EMG",
                CountyId = CountySeedData.Counties[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000015"),
                Name = "Tinderet",
                Code = "TND",
                CountyId = CountySeedData.Counties[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000016"),
                Name = "Aldai",
                Code = "ALD",
                CountyId = CountySeedData.Counties[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000017"),
                Name = "Bahati",
                Code = "BHT",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000018"),
                Name = "Naivasha",
                Code = "NVH",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000019"),
                Name = "Njoro",
                Code = "NJR",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000020"),
                Name = "Rongai",
                Code = "RNG",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000021"),
                Name = "Subukia",
                Code = "SBK",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000022"),
                Name = "Kuresoi North",
                Code = "KRN",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000023"),
                Name = "Kuresoi South",
                Code = "KRS",
                CountyId = CountySeedData.Counties[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Narok
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000024"),
                Name = "Narok North",
                Code = "NRN",
                CountyId = CountySeedData.Counties[7].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000025"),
                Name = "Narok South",
                Code = "NRS",
                CountyId = CountySeedData.Counties[7].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000026"),
                Name = "Narok West",
                Code = "NRW",
                CountyId = CountySeedData.Counties[7].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000027"),
                Name = "Kilgoris",
                Code = "KGS",
                CountyId = CountySeedData.Counties[7].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Baringo
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000028"),
                Name = "Baringo Central",
                Code = "BRC",
                CountyId = CountySeedData.Counties[8].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000029"),
                Name = "Baringo South",
                Code = "BRS",
                CountyId = CountySeedData.Counties[8].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000030"),
                Name = "Mogotio",
                Code = "MGT",
                CountyId = CountySeedData.Counties[8].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Samburu
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000031"),
                Name = "Samburu East",
                Code = "SBE",
                CountyId = CountySeedData.Counties[9].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000032"),
                Name = "Samburu North",
                Code = "SBN",
                CountyId = CountySeedData.Counties[9].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000033"),
                Name = "Samburu West",
                Code = "SBW",
                CountyId = CountySeedData.Counties[9].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Turkana
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000034"),
                Name = "Turkana Central",
                Code = "TKC",
                CountyId = CountySeedData.Counties[10].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000035"),
                Name = "Turkana North",
                Code = "TKN",
                CountyId = CountySeedData.Counties[10].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000036"),
                Name = "Turkana West",
                Code = "TKW",
                CountyId = CountySeedData.Counties[10].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // West Pokot
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000037"),
                Name = "Pokot South",
                Code = "PKS",
                CountyId = CountySeedData.Counties[11].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000038"),
                Name = "Pokot Central",
                Code = "PKC",
                CountyId = CountySeedData.Counties[11].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000039"),
                Name = "Kapenguria",
                Code = "KPG",
                CountyId = CountySeedData.Counties[11].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            //modification after seeding
            //Uasin Gishu
            new Constituency
            {
                Id = Guid.Parse("30000000-0000-0000-0000-000000000040"),
                Name = "Ainabkoi",
                Code = "ABI",
                CountyId = CountySeedData.Counties[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
        };
    }
}
