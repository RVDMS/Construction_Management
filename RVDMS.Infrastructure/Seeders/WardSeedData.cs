using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class WardSeedData
    {
        public static readonly List<Ward> Wards = new()
        {
            // Trans-Nzoia - Saboti Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000001"),
                Name = "Matisi",
                Code = "MTS",
                ConstituencyId = ConstituencySeedData.Constituencies[0].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Trans-Nzoia - Endebess Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000002"),
                Name = "Matumbei",
                Code = "MTB",
                ConstituencyId = ConstituencySeedData.Constituencies[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000003"),
                Name = "Chepchoina",
                Code = "CPC",
                ConstituencyId = ConstituencySeedData.Constituencies[1].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Trans-Nzoia - Kiminini Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000004"),
                Name = "Kiminini",
                Code = "KMN",
                ConstituencyId = ConstituencySeedData.Constituencies[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000005"),
                Name = "Sirende",
                Code = "SRD",
                ConstituencyId = ConstituencySeedData.Constituencies[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000006"),
                Name = "Nabiswa",
                Code = "NBS",
                ConstituencyId = ConstituencySeedData.Constituencies[2].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu - Turbo Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000007"),
                Name = "Kiplombe",
                Code = "KPL",
                ConstituencyId = ConstituencySeedData.Constituencies[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000008"),
                Name = "Huruma",
                Code = "HRM",
                ConstituencyId = ConstituencySeedData.Constituencies[3].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu - Soy Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000009"),
                Name = "Kipsuswa",
                Code = "KPS",
                ConstituencyId = ConstituencySeedData.Constituencies[4].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000010"),
                Name = "Segero/Barsombe",
                Code = "SGB",
                ConstituencyId = ConstituencySeedData.Constituencies[4].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000011"),
                Name = "Moi's Bridge",
                Code = "MSB",
                ConstituencyId = ConstituencySeedData.Constituencies[4].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu - Kapseret Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000012"),
                Name = "Simat/Kapseret",
                Code = "SMK",
                ConstituencyId = ConstituencySeedData.Constituencies[5].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu - Kesses Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000013"),
                Name = "Tulwet Chuiyat",
                Code = "TWC",
                ConstituencyId = ConstituencySeedData.Constituencies[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000014"),
                Name = "Tarakwa",
                Code = "TRK",
                ConstituencyId = ConstituencySeedData.Constituencies[6].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Uasin Gishu - Moiben Constituency
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000015"),
                Name = "Kimumu",
                Code = "KMM",
                ConstituencyId = ConstituencySeedData.Constituencies[7].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Elgeyo Marakwet - Keiyo North
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000016"),
                Name = "Kapchemutwa",
                Code = "KCM",
                ConstituencyId = ConstituencySeedData.Constituencies[8].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000017"),
                Name = "Irong",
                Code = "IRG",
                ConstituencyId = ConstituencySeedData.Constituencies[8].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Elgeyo Marakwet - Keiyo South
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000018"),
                Name = "Chepkorio",
                Code = "CPK",
                ConstituencyId = ConstituencySeedData.Constituencies[9].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Elgeyo Marakwet - Marakwet West
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000019"),
                Name = "Sengwer",
                Code = "SNG",
                ConstituencyId = ConstituencySeedData.Constituencies[10].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi - Nandi Hills
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000020"),
                Name = "Nandi Hills",
                Code = "NDH",
                ConstituencyId = ConstituencySeedData.Constituencies[11].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000021"),
                Name = "Ollessos",
                Code = "OLS",
                ConstituencyId = ConstituencySeedData.Constituencies[11].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi - Chesumei
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000022"),
                Name = "Chemundu/Kapng'etuny",
                Code = "CMK",
                ConstituencyId = ConstituencySeedData.Constituencies[12].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000023"),
                Name = "Lelmokwo/Ngechek",
                Code = "LMK",
                ConstituencyId = ConstituencySeedData.Constituencies[12].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi - Emgwen
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000024"),
                Name = "Kapsabet",
                Code = "KPS",
                ConstituencyId = ConstituencySeedData.Constituencies[13].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi - Tinderet
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000025"),
                Name = "Chemase",
                Code = "CMS",
                ConstituencyId = ConstituencySeedData.Constituencies[14].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000026"),
                Name = "Songhor/Soba",
                Code = "SGS",
                ConstituencyId = ConstituencySeedData.Constituencies[14].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nandi - Aldai
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000027"),
                Name = "Kaptumo/Kaboi",
                Code = "KPT",
                ConstituencyId = ConstituencySeedData.Constituencies[15].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Bahati
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000028"),
                Name = "Bahati",
                Code = "BHT",
                ConstituencyId = ConstituencySeedData.Constituencies[16].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000029"),
                Name = "Kabatini",
                Code = "KBT",
                ConstituencyId = ConstituencySeedData.Constituencies[16].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Naivasha
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000030"),
                Name = "Viwandani",
                Code = "VWD",
                ConstituencyId = ConstituencySeedData.Constituencies[17].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000031"),
                Name = "Hellsgate",
                Code = "HLG",
                ConstituencyId = ConstituencySeedData.Constituencies[17].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000032"),
                Name = "Kinungi",
                Code = "KNG",
                ConstituencyId = ConstituencySeedData.Constituencies[17].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000033"),
                Name = "Maai Mahiu",
                Code = "MMH",
                ConstituencyId = ConstituencySeedData.Constituencies[17].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Njoro
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000034"),
                Name = "Mauche",
                Code = "MCH",
                ConstituencyId = ConstituencySeedData.Constituencies[18].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000035"),
                Name = "Njoro",
                Code = "NJR",
                ConstituencyId = ConstituencySeedData.Constituencies[18].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Rongai
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000036"),
                Name = "Visoi",
                Code = "VSI",
                ConstituencyId = ConstituencySeedData.Constituencies[19].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000037"),
                Name = "Rongai",
                Code = "RNG",
                ConstituencyId = ConstituencySeedData.Constituencies[19].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Subukia
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000038"),
                Name = "Subukia",
                Code = "SBK",
                ConstituencyId = ConstituencySeedData.Constituencies[20].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Kuresoi North
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000039"),
                Name = "Kiptagich",
                Code = "KPT",
                ConstituencyId = ConstituencySeedData.Constituencies[21].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000040"),
                Name = "Kamara",
                Code = "KMR",
                ConstituencyId = ConstituencySeedData.Constituencies[21].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Nakuru - Kuresoi South
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000041"),
                Name = "Keringet",
                Code = "KRG",
                ConstituencyId = ConstituencySeedData.Constituencies[22].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Narok - Narok North
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000042"),
                Name = "Narok Town",
                Code = "NRT",
                ConstituencyId = ConstituencySeedData.Constituencies[23].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000043"),
                Name = "Ewaso Ngiro",
                Code = "EWN",
                ConstituencyId = ConstituencySeedData.Constituencies[23].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Narok - Narok South
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000044"),
                Name = "Ololulunga",
                Code = "OLL",
                ConstituencyId = ConstituencySeedData.Constituencies[24].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Narok - Narok West
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000045"),
                Name = "Naikarra",
                Code = "NKR",
                ConstituencyId = ConstituencySeedData.Constituencies[25].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Narok - Kilgoris
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000046"),
                Name = "Shankoe",
                Code = "SHK",
                ConstituencyId = ConstituencySeedData.Constituencies[26].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000047"),
                Name = "Shang'oe",
                Code = "SHG",
                ConstituencyId = ConstituencySeedData.Constituencies[26].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Baringo - Baringo Central
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000048"),
                Name = "Kabarnet",
                Code = "KBN",
                ConstituencyId = ConstituencySeedData.Constituencies[27].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Baringo - Baringo South
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000049"),
                Name = "Marigat",
                Code = "MGT",
                ConstituencyId = ConstituencySeedData.Constituencies[28].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Baringo - Mogotio
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000050"),
                Name = "Mogotio",
                Code = "MGT",
                ConstituencyId = ConstituencySeedData.Constituencies[29].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Samburu - Samburu East
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000051"),
                Name = "Waso",
                Code = "WSO",
                ConstituencyId = ConstituencySeedData.Constituencies[30].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Samburu - Samburu North
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000052"),
                Name = "Elbarta",
                Code = "ELB",
                ConstituencyId = ConstituencySeedData.Constituencies[31].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Samburu - Samburu West
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000053"),
                Name = "Maralal",
                Code = "MRL",
                ConstituencyId = ConstituencySeedData.Constituencies[32].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Turkana - Turkana Central
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000054"),
                Name = "Kanamkemer",
                Code = "KNM",
                ConstituencyId = ConstituencySeedData.Constituencies[33].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000055"),
                Name = "Township",
                Code = "TWN",
                ConstituencyId = ConstituencySeedData.Constituencies[33].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000056"),
                Name = "Kalokol",
                Code = "KLK",
                ConstituencyId = ConstituencySeedData.Constituencies[33].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Turkana - Turkana North
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000057"),
                Name = "Lake Zone",
                Code = "LKZ",
                ConstituencyId = ConstituencySeedData.Constituencies[34].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // Turkana - Turkana West
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000058"),
                Name = "Kakuma",
                Code = "KKM",
                ConstituencyId = ConstituencySeedData.Constituencies[35].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // West Pokot - Pokot South
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000059"),
                Name = "Chepareria",
                Code = "CPR",
                ConstituencyId = ConstituencySeedData.Constituencies[36].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // West Pokot - Pokot Central
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000060"),
                Name = "Weiwei",
                Code = "WWI",
                ConstituencyId = ConstituencySeedData.Constituencies[37].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            
            // West Pokot - Kapenguria
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000061"),
                Name = "Mnagei",
                Code = "MNG",
                ConstituencyId = ConstituencySeedData.Constituencies[38].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Ward
            {
                Id = Guid.Parse("40000000-0000-0000-0000-000000000062"),
                Name = "Kapenguria",
                Code = "KPG",
                ConstituencyId = ConstituencySeedData.Constituencies[38].Id,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            }
        };
    }
}
