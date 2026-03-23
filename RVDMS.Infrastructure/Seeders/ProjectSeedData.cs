using RVDMS.Domain.Constants;
using RVDMS.Domain.Entities;
using RVDMS.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
   
        public static class ProjectSeedData
        {
            public static readonly List<Project> Projects = new()
        {
            // ==================== HOUSING DEPARTMENT - AHP PROJECTS ====================
            // North Rift AHP Cluster (Trans-Nzoia, Uasin Gishu, Elgeyo Marakwet, Nandi, West Pokot)
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000001"),
                Name = "Maili Tatu AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/025/2024-2025",
                ContractorName = "Globetek Systems K Ltd",
                ConsultantName = "Tej Consortium",
                Description = @"The works to be carried out include the following:
Built up Structures: Block Type A G+9 (5 blocks, 26,755 sqm), Block Type B G+9 (6 blocks, 40,692 sqm), Commercial Stalls (249 sqm), Kindergarten (552 sqm), Guard House (2, 30 sqm), Garbage Receptacle (2, 206 sqm), Power House (24 sqm). External works: Roads, Sewer & Parking works, Boundary wall & underground water tank. Total units: 1035 units comprising social, affordable and market rate houses.",
                ContractSum = 2793053301.27m,
                StartDate = new DateTime(2025, 6, 26),
                EndDate = new DateTime(2026, 12, 26),
                Status = ProjectStatus.Active,
                Latitude = 0.984000,
                Longitude = 34.984396,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 23,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000001", // Daniel Kibowen
                WardId = WardSeedData.Wards[0].Id, // Matisi
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000002"),
                Name = "Kidiwa AHP Phase 2",
                TenderNumber = "MLPWHUD/SDHUD/AHP/420/2023-2024",
                ContractorName = "Double Portion Agency Limited",
                ConsultantName = "Morphosis Consultant",
                Description = "G+14, 14 No. blocks. Community centre, Club house, Civil works, ECD Centre, Swimming pool, 2 Basketball courts, 2 gate houses, MUD.",
                ContractSum = 5593692539m,
                StartDate = new DateTime(2025, 6, 19),
                EndDate = new DateTime(2026, 12, 19),
                Status = ProjectStatus.Active,
                Latitude = 0.526938, 
                Longitude = 35.262038,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 9.76m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000003", // Carolyne Simiyu
                WardId = WardSeedData.Wards[7].Id, // Huruma
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000003"),
                Name = "Pioneer AHP Kapseret",
                TenderNumber = "MLPWHUD/SDHUD/AHP/220/2023-2024",
                ContractorName = "Vagjiyani Enterprise Limited",
                ConsultantName = "Becs Consultancy",
                Description = "2048 units being constructed with associated amenities including Day care, primary school, club house, community Centre, swimming pools, playing grounds and fields, Mixed use developments (shops, supermarket & hospital), Electrical and Mechanical installations",
                ContractSum = 5300000000m,
                StartDate = new DateTime(2024, 7, 16),
                EndDate = new DateTime(2026, 4, 16),
                Status = ProjectStatus.Active,
                Latitude = 0.31536,
                Longitude = 35.15473,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 62.19m,
                LastProgressUpdate = new DateTime(2026, 2, 19),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000007", // Sailas Rugah
                WardId = WardSeedData.Wards[11].Id, // Simat/Kapseret
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000004"),
                Name = "Nandi Hills AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/046/2024-2025",
                ContractorName = "Samaha Company Limited",
                ConsultantName = "BECS Consultancy LLP",
                Description = "Proposed Construction of Nandi hills AHP with associated social amenities and infrastructure",
                ContractSum = 1773771500m,
                StartDate = new DateTime(2025, 11, 5),
                EndDate = new DateTime(2027, 5, 5),
                Status = ProjectStatus.Active,
                Latitude = 0.0601,
                Longitude = 35.1035,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 11.70m,
                LastProgressUpdate = new DateTime(2026, 2, 23),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000008", // Abel Kipruto
                WardId = WardSeedData.Wards[19].Id, // Nandi Hills
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000005"),
                Name = "Chesumei AHP",
                TenderNumber = "MLPWHUD/HUD/AHP/419/2023-2024",
                ContractorName = "Sparkey Baxter Limited",
                ConsultantName = "BECS",
                Description = "Affordable housing program located in Nandi County at Chesumei.",
                ContractSum = 3506655368.69m,
                StartDate = new DateTime(2025, 6, 23),
                EndDate = new DateTime(2026, 12, 23),
                Status = ProjectStatus.Active,
                Latitude = 0.204281,
                Longitude = 35.109664,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 16.20m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000032", // Irwin Jara
                WardId = WardSeedData.Wards[21].Id, // Chemundu/Kapng'etuny
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000006"),
                Name = "Eldoret Railway City AHP",
                TenderNumber = "MLPWHUD/SDHUD/DH/AHP/336/2023-2024",
                ContractorName = "Vaghjiyani Enterprises Limited",
                ConsultantName = "Morphosis Limited",
                Description = @"2180 Units in 15No. Block of G+14 Floors including:
Social Units: 1 Room (135 units), 2 Rooms (260 units), 3 Rooms (135 units)
AHP Units: Studio (270 units), 2 Bedroom (615 units), 3 Bedroom (225 units)
Market Units: 2 Bedroom (270 units), 3 Bedroom (270 units)
65 Shops, Garbage Receptacles (2), Guard House (3), Power House, Basketball Pitch, Underground water tank, Civil works (Roads & Sewer), Swimming Pool, Club House, Kindergarten/ECD, School, Community Centre",
                ContractSum = 5956400757.31m,
                StartDate = new DateTime(2025, 4, 4),
                EndDate = new DateTime(2027, 3, 25),
                Status = ProjectStatus.Active,
                Latitude = 0.52823,
                Longitude = 35.26206,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 35.40m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000030", // Emmanuel Sikuku
                WardId = WardSeedData.Wards[8].Id, // Kipsuswa
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000007"),
                Name = "Chepkorio AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/043/2024-2025",
                ContractorName = "Tejaswini Builders Limited",
                ConsultantName = "Design Artitude",
                Description = "Construction of 380 units G+4 with associated social amenities",
                ContractSum = 1079248889.12m,
                StartDate = new DateTime(2025, 10, 17),
                EndDate = new DateTime(2027, 5, 17),
                Status = ProjectStatus.Active,
                Latitude = 0.3677222,
                Longitude = 35.5571111,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5.73m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000063", // Victor Kiprop
                WardId = WardSeedData.Wards[17].Id, // Chepkorio
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000008"),
                Name = "Iten Affordable Housing Phase I",
                TenderNumber = "MLPWHUD/SDHUD/AHP/222/2023-2024",
                ContractorName = "Vee Vee Enterprises Ltd",
                ConsultantName = "Scope Design Consultants",
                Description = "Affordable housing with 268 units",
                ContractSum = 626850000m,
                StartDate = new DateTime(2024, 12, 2),
                EndDate = new DateTime(2026, 8, 12),
                Status = ProjectStatus.Active,
                Latitude = 0.40617,
                Longitude = 35.3045,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 54.1m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000015", // Wangah Ian
                WardId = WardSeedData.Wards[15].Id, // Kapchemutwa
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000009"),
                Name = "Iten Affordable Housing Phase II",
                TenderNumber = "MLPWHUD/SDHUD/AHP/042/2024-2025",
                ContractorName = "Jilk Construction Company Ltd",
                ConsultantName = "Scope Design Systems Ltd",
                Description = "PROPOSED ITEN AFFORDABLE HOUSING PROJECT PHASE II, KEIYO NORTH CONSTITUENCY, ELGEYO MARAKWET COUNTY (WITH ASSOCIATED AMENITIES AND INFRASTRUCTURE)",
                ContractSum = 1676863673m,
                StartDate = new DateTime(2025, 10, 13),
                EndDate = new DateTime(2027, 4, 17),
                Status = ProjectStatus.Active,
                Latitude = 0.6703,
                Longitude = 35.5075,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 4.2m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000010", // Ian Sang
                WardId = WardSeedData.Wards[15].Id, // Kapchemutwa
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000010"),
                Name = "Kimumu AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/221/2023-2024",
                ContractorName = "Pinnie Agency Limited",
                ConsultantName = "Becs Consultants",
                Description = "Affordable housing project in Kimumu",
                ContractSum = 568535616.33m,
                StartDate = new DateTime(2024, 7, 16),
                EndDate = new DateTime(2026, 7, 16),
                Status = ProjectStatus.Active,
                Latitude = 0.572345,
                Longitude = 35.310227,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 77.20m,
                LastProgressUpdate = new DateTime(2026, 2, 24),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000089", // Denies Langat
                WardId = WardSeedData.Wards[14].Id, // Kimumu
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000011"),
                Name = "Kapsuswa AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/168/2022-2023",
                ContractorName = "Padaa Enterprises Ltd",
                ConsultantName = "BECS Consultancy LLP",
                Description = "PROPOSED CONSTRUCTION OF HOUSING UNITS AND ASSOCIATED WORKS FOR KAPSUSWA, SOY CONSTITUENCY. THE SITE CONSIST OF 9NO BLOCKS OF G+4 WITH A TOTAL OF 220 UNIT COMPRISING 4 TYPOLOGIES: STUDIO 60 UNITS, ONE BEDROOM 40 UNITS, TWO BEDROOM 100 UNIT AND THREE BEDROOM 20 UNITS",
                ContractSum = 529128857.21m,
                StartDate = new DateTime(2023, 10, 28),
                EndDate = new DateTime(2026, 3, 31),
                Status = ProjectStatus.Active,
                Latitude = 0.31536,
                Longitude = 35.15473,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 98,
                LastProgressUpdate = new DateTime(2026, 2, 18),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000019", // Edwin Ondeng
                WardId = WardSeedData.Wards[8].Id, // Kipsuswa
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000012"),
                Name = "Suam Border Post AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/580/2024-2025",
                ContractorName = "Ibrann General Supplies Limited",
                ConsultantName = "Brickhaus Consortium",
                Description = "Proposed construction of suam border post AHP, and related social and physical infrastructure, located at the suam border between Kenya and Uganda",
                ContractSum = 1170552604m,
                StartDate = new DateTime(2026, 1, 20),
                EndDate = new DateTime(2027, 6, 20),
                Status = ProjectStatus.Active,
                Latitude = 1.2138344,
                Longitude = 34.7413032,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 4.90m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000057", // Mathias Munyendo
                WardId = WardSeedData.Wards[2].Id, // Chepchoina
                ClusterId = ClusterSeedData.Clusters[0].Id, // North Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // South Rift AHP Cluster (Kericho, Bomet, Nakuru, Narok, Baringo)
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000013"),
                Name = "Majengo Talai AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/198/2023-2024",
                ContractorName = "Padaa Enterprises Ltd",
                ConsultantName = "Dama Services Ltd",
                Description = "PROPOSED CONSTRUCTION OF HOUSING UNITS AND ASSOCIATED WORKS AT KERICHO TALAI, AINAMOI CONSTITUENCY, KERICHO COUNTY.",
                ContractSum = 778221897.76m,
                StartDate = new DateTime(2024, 7, 15),
                EndDate = new DateTime(2026, 4, 15),
                Status = ProjectStatus.Active,
                Latitude = -0.3598043,
                Longitude = 35.28986,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 54.81m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000004", // Jobson Birundu
                WardId = WardSeedData.Wards[0].Id, // Need appropriate Kericho ward
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000014"),
                Name = "Sotik AHP",
                TenderNumber = "MLPWHUD|SDHUD|AHP|191|2024-2025",
                ContractorName = "Amber Construction",
                ConsultantName = "Udesign Limited",
                Description = "596 mixed use units with social amenities, Six blocks each G+9",
                ContractSum = 1394245472.47m,
                StartDate = new DateTime(2025, 10, 10),
                EndDate = new DateTime(2027, 4, 10),
                Status = ProjectStatus.Active,
                Latitude = 0.687378,
                Longitude = 35.109831,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 3.81m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000016", // Ramadlay Kiptoo
                WardId = WardSeedData.Wards[21].Id, // Need appropriate Sotik ward
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000015"),
                Name = "Bahati AHP Phase 2",
                TenderNumber = "MLPWHUD/SDHUD/AHP/340/2023-2024",
                ContractorName = "Vaghjiyani Enterprises Limited",
                ConsultantName = "Decalogue Limited",
                Description = "Highrise units made of studio 1, 2, and 3 bedroom units. The units are divided into Social, Affordable and Market units",
                ContractSum = 3129536328m,
                StartDate = new DateTime(2025, 3, 29),
                EndDate = new DateTime(2027, 3, 29),
                Status = ProjectStatus.Active,
                Latitude = -0.1431027,
                Longitude = 36.1500524,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 37,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000034", // Brian Mosoti
                WardId = WardSeedData.Wards[27].Id, // Bahati
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000016"),
                Name = "Kabarnet Town AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/175/2024-2025",
                ContractorName = "Xtreme Engineering Limited",
                ConsultantName = "Dama Services Limited",
                Description = "Kabarnet Town AHP with associated social amenities and infrastructure (504 units)",
                ContractSum = 1182507795m,
                StartDate = new DateTime(2025, 12, 5),
                EndDate = new DateTime(2026, 12, 5),
                Status = ProjectStatus.Active,
                Latitude = 0.494873,
                Longitude = 35.73708,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1.72m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000040", // Robert Kimutai
                WardId = WardSeedData.Wards[47].Id, // Kabarnet
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000017"),
                Name = "Marigat Affordable Housing Project",
                TenderNumber = "MLPWHUD/SDHUD/AHP/028/2023-2024",
                ContractorName = "Skillman Construction Ltd",
                ConsultantName = "Tectonics International Ltd",
                Description = "The Marigat Affordable Housing Project (AHP) includes 4 number of residential blocks, offering a total of 382 units across two typologies, Block Typology A (2 Blocks-A1 & A2) and B (2 Blocks- B1 & B2). The units entail, 3-,2- & 1-Bedroom and the studio apartments. The other infrastructures are; clubhouse & swimming pool, kindergarten, social hall, commercial stalls, Garbage receptacle, power house, gate house, Pump house-2, underground water tank & borehole.",
                ContractSum = 1096217107.02m,
                StartDate = new DateTime(2025, 5, 12),
                EndDate = new DateTime(2026, 11, 12),
                Status = ProjectStatus.Active,
                Latitude = 0.47306,
                Longitude = 35.979379,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 15.29m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000028", // Praise Lekesio
                WardId = WardSeedData.Wards[48].Id, // Marigat
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000018"),
                Name = "Kilgoris AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/204/2023-2024",
                ContractorName = "Vee Vee Enterprise",
                ConsultantName = "Archgrid",
                Description = "Affordable housing project, 185 residential units and 9 shops, parking guard, house power house and garbage receptacle",
                ContractSum = 508179838.66m,
                StartDate = new DateTime(2025, 1, 20),
                EndDate = new DateTime(2026, 7, 20),
                Status = ProjectStatus.Active,
                Latitude = -1.00028,
                Longitude = 34.87665,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 43,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000027", // Robert Ronoh
                WardId = WardSeedData.Wards[45].Id, // Shankoe
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000019"),
                Name = "Buffalo Mall Phase 1 AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/045/2024-2025",
                ContractorName = "Landmark Freight Services Limited",
                ConsultantName = "Decalogue International Limited",
                Description = "PROPOSED CONSTRUCTION OF BUFFALO MALL PHASE 1 AHP PROJECT (WITH SOCIAL AMENITIES AND INFRASTRUCTURE) IN NAIVASHA CONSTITUENCY. The scope of works involve the construction of 1054 Units in 11 blocks G+9 (6 No Block A and 5 no Block B), supporting an estimated 4,000 residents, and will feature essential amenities including Kindergarten, Clubhouse, Power House, Garbage Receptacles, Gate House, swimming pool, Basketball Court, Playgrounds, Roads & Parking works, Sewer, Underground water tank.",
                ContractSum = 2580819424.01m,
                StartDate = new DateTime(2025, 8, 14),
                EndDate = new DateTime(2027, 2, 14),
                Status = ProjectStatus.Active,
                Latitude = -0.70286,
                Longitude = 35.334631,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 10.94m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000041", // Archimedes Mulumba
                WardId = WardSeedData.Wards[29].Id, // Viwandani
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000020"),
                Name = "Karagita AHP Phase 2",
                TenderNumber = "MLPWHUD/SDHUD/AHP/044/2024-2025",
                ContractorName = "Padaa Enterprises Limited",
                ConsultantName = "Alphaquest Designs Ltd",
                Description = "Karagita Phase 2 is an affordable housing project in Nakuru County, Naivasha Sub county and entails: 12No. G+9 Blocks (1134 units), Club House & Swimming pool, Kindergarten, Primary School, Market, Commercial Stalls, Police station, Football Field, Underground Water Tank, Garbage Receptacle, Power House, Guard House.",
                ContractSum = 3391457657.57m,
                StartDate = new DateTime(2025, 7, 9),
                EndDate = new DateTime(2027, 1, 9),
                Status = ProjectStatus.Active,
                Latitude = -0.784635,
                Longitude = 36.432858,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 16.94m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000083", // Benson Charagu
                WardId = WardSeedData.Wards[30].Id, // Hellsgate
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000021"),
                Name = "Mogotio Affordable Housing Project",
                TenderNumber = "MLPWHUD/SDHUD/028/2023-2024",
                ContractorName = "Paschal Construction Ltd",
                ConsultantName = "Lins Consultants",
                Description = "The Mogotio Affordable Housing Project (AHP) is located in Mogotio Ward, Mogotio Constituency, Baringo County. The site is situated approximately 800 metres from Mogotio Town Centre, along the Nakuru–Marigat Road",
                ContractSum = 1313295862.20m,
                StartDate = new DateTime(2026, 1, 23),
                EndDate = new DateTime(2027, 1, 23),
                Status = ProjectStatus.Active,
                Latitude = -0.010056,
                Longitude = 35.964128,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1.50m,
                LastProgressUpdate = new DateTime(2026, 2, 26),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000104", // Kennedy Kiprotich
                WardId = WardSeedData.Wards[49].Id, // Mogotio
                ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Northern AHP Cluster (Turkana, Samburu)
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000022"),
                Name = "Maralal AHP",
                TenderNumber = "MLPWHUD/SDHUD/AHP/195/2023-2024",
                ContractorName = "Abeera Enterprises Limited",
                ConsultantName = "EDG & Atelier Architects",
                Description = "Maralal Affordable housing project has G+10 Block D of 110units, Garbage receptacle, Guard house, G+1 commercial stalls of 8units, Power/Generator room and pump room.",
                ContractSum = 275186780m,
                StartDate = new DateTime(2024, 7, 15),
                EndDate = new DateTime(2026, 1, 7),
                Status = ProjectStatus.Active,
                Latitude = 1.093091,
                Longitude = 36.689542,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 38,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000012", // Vincent Odhiambo
                WardId = WardSeedData.Wards[51].Id, // Maralal
                ClusterId = ClusterSeedData.Clusters[2].Id, // Northern AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000023"),
                Name = "Archers Post AHP",
                TenderNumber = "MLPWHUD/HUD/AHP/029/2024-2025",
                ContractorName = "Agrobriq Investment Limited",
                ConsultantName = "Tej Consortium",
                Description = "3 residential blocks, kindergarten, 2 commercial stalls, social hall",
                ContractSum = 812537550m,
                StartDate = new DateTime(2025, 7, 14),
                EndDate = new DateTime(2027, 1, 14),
                Status = ProjectStatus.Active,
                Latitude = 0.663735,
                Longitude = 37.667609,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 20,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000099", // Cliff Wanjala
                WardId = WardSeedData.Wards[50].Id, // Waso
                ClusterId = ClusterSeedData.Clusters[2].Id, // Northern AHP Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT DEPARTMENT - ESP MARKETS ====================
            // ESP Markets by cluster number
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000024"),
                Name = "Kolongei ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/231/2024-2025",
                ContractorName = "Koshdak Enterprises Ltd",
                ConsultantName = "Brickhaus Consortium",
                Description = "Construction of 200 unit market with associated facilities",
                ContractSum = 130000000m,
                StartDate = new DateTime(2026, 1, 1),
                EndDate = new DateTime(2026, 9, 30),
                Status = ProjectStatus.Active,
                Latitude = 1.090094,
                Longitude = 34.805747,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5,
                LastProgressUpdate = new DateTime(2026, 1, 1),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000002", // Vincent Wekesa
                WardId = WardSeedData.Wards[1].Id, // Matumbei
                ClusterId = ClusterSeedData.Clusters[10].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000025"),
                Name = "Sibanga ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/214/2023-2024-CLUSTER 20",
                ContractorName = "Paco Investment Limited",
                ConsultantName = "Brickehaus Consortium",
                Description = "KEY FACILITIES: Market block, Ablution block, Septic tank, Steel tank, Waste cubicle, Borehole & civil works.",
                ContractSum = 119976652m,
                StartDate = new DateTime(2024, 6, 24),
                EndDate = new DateTime(2024, 12, 24),
                Status = ProjectStatus.Active,
                Latitude = 1.0664,
                Longitude = 35.1328,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 62.93m,
                LastProgressUpdate = new DateTime(2026, 2, 18),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000005", // George Wekesa
                WardId = WardSeedData.Wards[3].Id, // Need appropriate Kaplamai ward
                ClusterId = ClusterSeedData.Clusters[16].Id, // ESP Markets Cluster 20
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000026"),
                Name = "Naikarra ESP Market",
                TenderNumber = "MLPWHID/SDHUD/AHP/686/2024-2025",
                ContractorName = "Eccentriq Investment Limited",
                ConsultantName = "Dama Services Limited",
                Description = "Naikarra esp market construction",
                ContractSum = 71086352.10m,
                StartDate = new DateTime(2026, 2, 6),
                EndDate = new DateTime(2027, 2, 6),
                Status = ProjectStatus.Active,
                Latitude = -1.615425,
                Longitude = 35.661312,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 7.81m,
                LastProgressUpdate = new DateTime(2026, 2, 26),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000006", // Nixon Kipchirchir
                WardId = WardSeedData.Wards[43].Id, // Naikarra
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000027"),
                Name = "Ololulunga ESP Market",
                TenderNumber = "234",
                ContractorName = "Budgets Construction Ltd",
                ConsultantName = "None",
                Description = "ESP market construction",
                ContractSum = 110850481m,
                StartDate = new DateTime(2024, 4, 23),
                EndDate = new DateTime(2024, 10, 23),
                Status = ProjectStatus.Active,
                Latitude = -1.003578,
                Longitude = 35.66316,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 93,
                LastProgressUpdate = new DateTime(2026, 2, 26),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000031", // Calvince Nyakinda
                WardId = WardSeedData.Wards[43].Id, // Ololulunga
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000028"),
                Name = "Ainabkoi ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/05/2024-2025-cluster 089",
                ContractorName = "Marc Construction Works Ltd",
                ConsultantName = "BECS Consultants",
                Description = "The project is located in Ainabkoi/Olare ward, Ainabkoi constituency, Uasin Gishu county. The main contractors works are complete.",
                ContractSum = 58019069m,
                StartDate = new DateTime(2025, 2, 19),
                EndDate = new DateTime(2025, 11, 18),
                Status = ProjectStatus.Active,
                Latitude = 0.164444,
                Longitude = 35.524722,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 99.80m,
                LastProgressUpdate = new DateTime(2026, 1, 31),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000037", // Peter Kakuko
                WardId = WardSeedData.Wards[39].Id, // Need appropriate Ainabkoi ward
                ClusterId = ClusterSeedData.Clusters[21].Id, // ESP Markets Cluster 89
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000029"),
                Name = "Sotik Modern Market",
                TenderNumber = "MLPHUD/SDHUD/AHP/204/2024-2025",
                ContractorName = "Emricon Limited",
                ConsultantName = "Dama Services Ltd",
                Description = "Modern market in Chemagel",
                ContractSum = 359910337.55m,
                StartDate = new DateTime(2025, 10, 2),
                EndDate = new DateTime(2026, 10, 2),
                Status = ProjectStatus.Active,
                Latitude = -0.695147,
                Longitude = 35.10801,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 3,
                LastProgressUpdate = new DateTime(2026, 2, 5),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000039", // Isaac Chege
                WardId = WardSeedData.Wards[21].Id, // Need appropriate Chemagel ward
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000030"),
                Name = "Kapcherop ESP Market",
                TenderNumber = "Cluster 71 / MLPWHUD/SDHUD/UDD/385/2023-2024",
                ContractorName = "Energia Engineering Limited",
                ConsultantName = "Scope Consultants",
                Description = "The project involves the proposed construction of a modern ESP Market and supporting facilities at Kapcherop in Marakwet West Constituency, Elgeyo-Marakwet County, under Cluster 71",
                ContractSum = 160752780m,
                StartDate = new DateTime(2024, 12, 23),
                EndDate = new DateTime(2025, 6, 23),
                Status = ProjectStatus.Active,
                Latitude = 1.038503,
                Longitude = 35.322287,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 10,
                LastProgressUpdate = new DateTime(2025, 10, 10),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000042", // Stanley Ronoh
                WardId = WardSeedData.Wards[18].Id, // Sengwer
                ClusterId = ClusterSeedData.Clusters[20].Id, // ESP Markets Cluster 71
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000031"),
                Name = "Kilgoris Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/08/2024-2025",
                ContractorName = "Rural Distributors Enterprise Limited",
                ConsultantName = "Dama Services Ltd",
                Description = "The project involves construction of Kilgoris Modern Market located in Kilgoris town. The works include construction of modern market, garbage receptacle, and external works including parking, high mast.",
                ContractSum = 297486634.20m,
                StartDate = new DateTime(2026, 2, 7),
                EndDate = new DateTime(2027, 2, 7),
                Status = ProjectStatus.Active,
                Latitude = -1.008222,
                Longitude = 34.880222,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 36,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000045", // Duncan Maruti
                WardId = WardSeedData.Wards[45].Id, // Shankoe
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000032"),
                Name = "Bikeke ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/214/2023-2024",
                ContractorName = "Paco Investment Limited",
                ConsultantName = "Brickhaus Consortium",
                Description = "Market block, Ablution block, Cabbage cubicle, Borehole, Septic tank, Civil works",
                ContractSum = 119976652m,
                StartDate = new DateTime(2024, 6, 24),
                EndDate = new DateTime(2024, 12, 24),
                Status = ProjectStatus.Active,
                Latitude = 0.999891,
                Longitude = 35.058038,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 64,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000046", // Felix Osok
                WardId = WardSeedData.Wards[4].Id, // Sirende
                ClusterId = ClusterSeedData.Clusters[16].Id, // ESP Markets Cluster 20
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000033"),
                Name = "Kesses ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/213/2023-2024 – CLUSTER 19",
                ContractorName = "Savola Investment Ltd",
                ConsultantName = "N/A",
                Description = "The Proposed Construction of Kesses ESP Markets and Supporting Facilities in Uasin Gishu County. Located in Kesses constituency Tulwet Chuiyat Ward.",
                ContractSum = 113007173m,
                StartDate = new DateTime(2024, 4, 25),
                EndDate = new DateTime(2024, 10, 28),
                Status = ProjectStatus.Active,
                Latitude = 0.296095,
                Longitude = 35.325614,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 85.30m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000050", // Brian Kipruto
                WardId = WardSeedData.Wards[12].Id, // Tulwet Chuiyat
                ClusterId = ClusterSeedData.Clusters[15].Id, // ESP Markets Cluster 19
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000034"),
                Name = "Olkalou (Mirangine) ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/245/2023-2024-Cluster 1",
                ContractorName = "PECAR Enterprises Limited",
                ConsultantName = "N/A",
                Description = "The site is earmarked for the construction of a market and associated infrastructure. This project entails the construction of a market block, an ablution, a garbage cubicle and associated mechanical and electrical works.",
                ContractSum = 153438857.40m,
                StartDate = new DateTime(2024, 7, 23),
                EndDate = new DateTime(2025, 1, 22),
                Status = ProjectStatus.Active,
                Latitude = -0.176656,
                Longitude = 36.245203,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 92.13m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000051", // Albert Mulonzi
                WardId = WardSeedData.Wards[37].Id, // Need appropriate Mirangine ward
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000035"),
                Name = "Matharu ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/247/2023-2024",
                ContractorName = "Marc Construction Works",
                ConsultantName = "N/A",
                Description = "ESP market in Kesses constituency",
                ContractSum = 109098180m,
                StartDate = new DateTime(2024, 5, 10),
                EndDate = new DateTime(2025, 11, 10),
                Status = ProjectStatus.Active,
                Latitude = 0.096131,
                Longitude = 35.5037,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 99.66m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000052", // Philemon Koech
                WardId = WardSeedData.Wards[13].Id, // Tarakwa
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000036"),
                Name = "Birunda ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/202/2024-2025",
                ContractorName = "Birunda ESP Market",
                ConsultantName = "Brickhaus",
                Description = "Key facilities: Market block, Borehole, Septic, Garbage cubicles, Ablution block.",
                ContractSum = 136972765m,
                StartDate = new DateTime(2025, 11, 19),
                EndDate = new DateTime(2026, 8, 19),
                Status = ProjectStatus.Active,
                Latitude = 0.961554,
                Longitude = 34.932297,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5,
                LastProgressUpdate = new DateTime(2026, 2, 8),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000053", // Evans Kipserem
                WardId = WardSeedData.Wards[5].Id, // Nabiswa
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000037"),
                Name = "Kiptagich ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/258/2023-2024 CLUSTER 12",
                ContractorName = "Flolizz Contractors Limited",
                ConsultantName = "Dama Services Limited",
                Description = "One market block with 2 Lever market comprising of 100No. stalls, ICT hub, administration block, cold room, food court, social hall, Ablution block, waste cubical, mechanical and electrical works",
                ContractSum = 151147005m,
                StartDate = new DateTime(2024, 6, 5),
                EndDate = new DateTime(2025, 11, 20),
                Status = ProjectStatus.Active,
                Latitude = -0.57342,
                Longitude = 35.61401,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 97.08m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000055", // Francisca Kisyula
                WardId = WardSeedData.Wards[38].Id, // Kiptagich
                ClusterId = ClusterSeedData.Clusters[14].Id, // ESP Markets Cluster 12
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000038"),
                Name = "Maraba ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/291/2023-2024- Cluster 66",
                ContractorName = "Fairdeal Terrazzo Enterprises Limited",
                ConsultantName = "Project implementation team",
                Description = "G+1 market block, an ablution block, mechanical and electrical works.",
                ContractSum = 58777395.50m,
                StartDate = new DateTime(2024, 7, 23),
                EndDate = new DateTime(2025, 1, 23),
                Status = ProjectStatus.Active,
                Latitude = 0.005982,
                Longitude = 35.310048,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 76.58m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000056", // Charles Ekirapa
                WardId = WardSeedData.Wards[25].Id, // Songhor/Soba
                ClusterId = ClusterSeedData.Clusters[19].Id, // ESP Markets Cluster 66
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000039"),
                Name = "Makutano ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/248/2023/-2024",
                ContractorName = "Clara Tiamale",
                ConsultantName = "SDHUD",
                Description = "ESP Market in West Pokot",
                ContractSum = 147275817m,
                StartDate = new DateTime(2024, 5, 13),
                EndDate = new DateTime(2024, 11, 13),
                Status = ProjectStatus.Active,
                Latitude = 1.255286,
                Longitude = 35.09195,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 68,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000059", // Nakus Kachurkwel
                WardId = WardSeedData.Wards[60].Id, // Mnagei
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000040"),
                Name = "Kiminini Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/200/2024-2025",
                ContractorName = "Patience Services Limited",
                ConsultantName = "Brickehaus Consortium Limited",
                Description = "G+2 market block, an abollution block, mechanical and electrical works",
                ContractSum = 181674207.75m,
                StartDate = new DateTime(2025, 11, 20),
                EndDate = new DateTime(2026, 11, 20),
                Status = ProjectStatus.Active,
                Latitude = 0.893047,
                Longitude = 34.924821,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5.60m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000060", // Milton Wamukota
                WardId = WardSeedData.Wards[3].Id, // Kiminini
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000041"),
                Name = "Suam Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/589/2024-2025",
                ContractorName = "Elephant Construction Co. Ltd",
                ConsultantName = "Brickhaus Consortium",
                Description = "Proposed construction of suam modern market is located at Kenya-Uganda Suam border along kitale-Endebes-Suam road.",
                ContractSum = 309407023.78m,
                StartDate = new DateTime(2025, 11, 1),
                EndDate = new DateTime(2026, 11, 1),
                Status = ProjectStatus.Active,
                Latitude = 1.218322,
                Longitude = 34.735619,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5.45m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000080", // Sostine Wanyonyi
                WardId = WardSeedData.Wards[2].Id, // Chepchoina
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000042"),
                Name = "Kapseret ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/05 2024-2025",
                ContractorName = "Marc Construction Works Limited",
                ConsultantName = "Becs Consultancy",
                Description = "Construction of ESP Markets and Supporting Facilities",
                ContractSum = 58006569m,
                StartDate = new DateTime(2025, 5, 5),
                EndDate = new DateTime(2026, 1, 12),
                Status = ProjectStatus.Active,
                Latitude = 0.448643,
                Longitude = 35.235109,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 99.10m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000081", // Faith Chebet
                WardId = WardSeedData.Wards[11].Id, // Simat/Kapseret
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000043"),
                Name = "Kabatini ESP Market",
                TenderNumber = "MLPWHUD / SDHUD / UDD / 198 / 2023-2024 CLUSTER 4",
                ContractorName = "Axela Holdings Limited",
                ConsultantName = "Tej Architects",
                Description = "The proposed development comprises the construction of a two-storey reinforced concrete market block with associated external works and supporting infrastructure. The market is designed to accommodate a total of 204 traders, including 75 smart stalls.",
                ContractSum = 180555172m,
                StartDate = new DateTime(2024, 5, 14),
                EndDate = new DateTime(2024, 11, 13),
                Status = ProjectStatus.Active,
                Latitude = -0.229278,
                Longitude = 36.134333,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 98.22m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000086", // Eric Kamau
                WardId = WardSeedData.Wards[28].Id, // Kabatini
                ClusterId = ClusterSeedData.Clusters[11].Id, // ESP Markets Cluster 4
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000044"),
                Name = "Nyamamithi ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/258/2023-2024 – CLUSTER 12",
                ContractorName = "Flolizz Contractors",
                ConsultantName = "Dama Services",
                Description = "The project is located at Nyamamithi Open Air Market in Nakuru County. It includes a market block, ablution block, mechanical and electrical works.",
                ContractSum = 151147005m,
                StartDate = new DateTime(2024, 6, 19),
                EndDate = new DateTime(2024, 12, 17),
                Status = ProjectStatus.Active,
                Latitude = 0.00938,
                Longitude = 36.2125,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 71,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000087", // Emmanuel Kimwaki
                WardId = WardSeedData.Wards[35].Id, // Need appropriate Rongai ward
                ClusterId = ClusterSeedData.Clusters[14].Id, // ESP Markets Cluster 12
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000045"),
                Name = "Mauche ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/098/2024-2025",
                ContractorName = "Quartz Company Ltd",
                ConsultantName = "Tej Architects",
                Description = "The Proposed Construction of Mauche esp market comprise of G+1 market block, ablution block, waste cuble, electrical and mechanical works.",
                ContractSum = 111770460m,
                StartDate = new DateTime(2025, 7, 23),
                EndDate = new DateTime(2026, 4, 23),
                Status = ProjectStatus.Active,
                Latitude = -0.511928,
                Longitude = 35.975946,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 56.50m,
                LastProgressUpdate = new DateTime(2026, 2, 20),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000091", // Peter Kiplangat
                WardId = WardSeedData.Wards[33].Id, // Mauche
                ClusterId = ClusterSeedData.Clusters[22].Id, // ESP Markets Cluster 93
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000046"),
                Name = "Baragoi Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/192/2024-2025",
                ContractorName = "Blue Pacific Agency Limited",
                ConsultantName = "E.D.G and Atelier",
                Description = "Proposed construction of Baragoi modern market in Baragoi, Samburu North, Samburu County.",
                ContractSum = 189968224m,
                StartDate = new DateTime(2025, 11, 9),
                EndDate = new DateTime(2026, 11, 8),
                Status = ProjectStatus.Active,
                Latitude = 1.785569,
                Longitude = 36.789939,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 6,
                LastProgressUpdate = new DateTime(2026, 3, 1),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000094", // Michael Lepartobiko
                WardId = WardSeedData.Wards[51].Id, // Elbarta
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000047"),
                Name = "Mosoriot ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/215/2023-2024",
                ContractorName = "Katrukan Supplies Limited",
                ConsultantName = "None",
                Description = "ESP market at Mosoriot trading centre, behind KMTC Mosoriot",
                ContractSum = 141786521m,
                StartDate = new DateTime(2024, 3, 27),
                EndDate = new DateTime(2024, 9, 26),
                Status = ProjectStatus.Active,
                Latitude = 0.322059,
                Longitude = 35.17014,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 98.62m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000098", // Robert Kimutai
                WardId = WardSeedData.Wards[22].Id, // Lelmokwo/Ngechek
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000048"),
                Name = "Chebunyo ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/204/2023-2024/10",
                ContractorName = "Squarestone Developers Limited",
                ConsultantName = "N/A",
                Description = "ESP market located within chebunyo market",
                ContractSum = 29466821m,
                StartDate = new DateTime(2024, 4, 30),
                EndDate = new DateTime(2024, 10, 30),
                Status = ProjectStatus.Active,
                Latitude = -0.966188,
                Longitude = 35.190675,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 58.6m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000102", // Ezra Rono
                WardId = WardSeedData.Wards[0].Id, // Need appropriate Chebunyo ward
                ClusterId = ClusterSeedData.Clusters[10].Id, // ESP Markets Cluster 3
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000049"),
                Name = "Kibigori ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/216/2024-2025",
                ContractorName = "Stima Network Limited",
                ConsultantName = "Scope Consultant",
                Description = "ESP market at Kibigori junction in chemase ward",
                ContractSum = 66000000m,
                StartDate = new DateTime(2025, 11, 24),
                EndDate = new DateTime(2026, 3, 23),
                Status = ProjectStatus.Active,
                Latitude = 0.0667,
                Longitude = 35.05,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 5,
                LastProgressUpdate = new DateTime(2026, 2, 23),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000103", // Ezra Ayabei
                WardId = WardSeedData.Wards[24].Id, // Chemase
                ClusterId = ClusterSeedData.Clusters[12].Id, // ESP Markets Cluster 8
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000050"),
                Name = "Lower Moiben ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/213/2023-2024-cluster 19",
                ContractorName = "Savola Investment Limited",
                ConsultantName = "N/A",
                Description = "Construction of Lower Moiben ESP Market and supporting facilities",
                ContractSum = 113007173m,
                StartDate = new DateTime(2024, 4, 9),
                EndDate = new DateTime(2024, 10, 24),
                Status = ProjectStatus.Active,
                Latitude = 0.82,
                Longitude = 35.38,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 24.49m,
                LastProgressUpdate = new DateTime(2026, 3, 1),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000105", // Pascal Kimutai
                WardId = WardSeedData.Wards[9].Id, // Segero/Barsombe
                ClusterId = ClusterSeedData.Clusters[15].Id, // ESP Markets Cluster 19
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000051"),
                Name = "Sigor ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/248/2023-2024",
                ContractorName = "Kongasis Investment",
                ConsultantName = "Null",
                Description = "SIGOR ESP IS G+1 MARKET OF TYPOLOGY 36*30M",
                ContractSum = 147275817m,
                StartDate = new DateTime(2024, 4, 23),
                EndDate = new DateTime(2024, 10, 25),
                Status = ProjectStatus.Active,
                Latitude = 1.486858,
                Longitude = 35.472625,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 47.20m,
                LastProgressUpdate = new DateTime(2026, 1, 21),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000107", // Clyite Kibet
                WardId = WardSeedData.Wards[58].Id, // Need appropriate Weiwei ward
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000052"),
                Name = "Kakuma ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/657/2024-2025",
                ContractorName = "Pensha Enterprises LTD",
                ConsultantName = "Morphosis Limited",
                Description = "The project entails the construction of the Kakuma ESP Market in Turkana West Constituency, providing organized trading spaces and basic market facilities.",
                ContractSum = 0m, // Not indicated in tender document
                StartDate = new DateTime(2025, 12, 1),
                EndDate = new DateTime(2026, 12, 1),
                Status = ProjectStatus.Active,
                Latitude = 3.707505,
                Longitude = 34.882983,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000110", // Locha Lokwanamor
                WardId = WardSeedData.Wards[57].Id, // Kakuma
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000053"),
                Name = "Kiptangwanyi ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/254/2023-2024 CLUSTER 1",
                ContractorName = "PECAR Investment Limited",
                ConsultantName = "SDHUD",
                Description = "Market topology: 30m x 36m, Number of stalls: 204",
                ContractSum = 153438857.40m,
                StartDate = new DateTime(2024, 11, 27),
                EndDate = new DateTime(2026, 5, 27),
                Status = ProjectStatus.Active,
                Latitude = -0.565011,
                Longitude = 36.11705,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 52.47m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000111", // Chepyegon Mercy
                WardId = WardSeedData.Wards[34].Id, // Need appropriate Elementaita ward
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000054"),
                Name = "Uhuru Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/183/2023-2024",
                ContractorName = "County Builders Limited",
                ConsultantName = "Dama Services Limited",
                Description = "Modern market located in majengo area of Narok town.",
                ContractSum = 357791914m,
                StartDate = new DateTime(2024, 7, 29),
                EndDate = new DateTime(2026, 7, 29),
                Status = ProjectStatus.Active,
                Latitude = -1.08519,
                Longitude = 35.87806,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 77.70m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000113", // Sheila Chelang'at
                WardId = WardSeedData.Wards[41].Id, // Narok Town
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000055"),
                Name = "Iten ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/SUD/247/2023-2024/CLUSTER 3",
                ContractorName = "Marc Construction Works LTD",
                ConsultantName = "N/A",
                Description = "cluster 3 market 48x21m, Ablution block, waste cubicle and civil works",
                ContractSum = 109098108m,
                StartDate = new DateTime(2024, 4, 25),
                EndDate = new DateTime(2024, 10, 25),
                Status = ProjectStatus.Active,
                Latitude = 0.669906,
                Longitude = 35.506299,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 99.17m,
                LastProgressUpdate = new DateTime(2026, 3, 2),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000116", // Ronald Kirui
                WardId = WardSeedData.Wards[15].Id, // Kapchemutwa
                ClusterId = ClusterSeedData.Clusters[10].Id, // ESP Markets Cluster 3
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000056"),
                Name = "Iten Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/012/2024-2025",
                ContractorName = "Grayan Investments Limited",
                ConsultantName = "Tectonics International Limited",
                Description = "Modern market in Iten",
                ContractSum = 310463990m,
                StartDate = new DateTime(2025, 5, 23),
                EndDate = new DateTime(2026, 5, 23),
                Status = ProjectStatus.Active,
                Latitude = 0.670125,
                Longitude = 35.5098,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 26.9m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000119", // James Makheti
                WardId = WardSeedData.Wards[15].Id, // Kapchemutwa
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== INSTITUTIONAL HOUSING DEPARTMENT ====================
            // University Hostels
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000057"),
                Name = "Maasai Mara University Hostels",
                TenderNumber = "MLPWHUD/SDHUD/AHP/517/2024-2025",
                ContractorName = "Lavasa Construction Limited",
                ConsultantName = "Dama Service Limited",
                Description = "Proposed construction of hostels and related social infrastructure at Masai Mara university (G+14)",
                ContractSum = 522280854.50m,
                StartDate = new DateTime(2025, 12, 9),
                EndDate = new DateTime(2026, 12, 9),
                Status = ProjectStatus.Active,
                Latitude = -1.090546,
                Longitude = 35.85415,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 3.5m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000117", // Emmanuel Kiprotich
                WardId = WardSeedData.Wards[41].Id, // Narok Town
                ClusterId = ClusterSeedData.Clusters[6].Id, // University Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000058"),
                Name = "Turkana University Student Hostel",
                TenderNumber = "MLPWHUD/SDHUD/AHP/553/2024-2025",
                ContractorName = "Lavasa Construction Company Ltd",
                ConsultantName = "Brickhaus Limited",
                Description = "PROPOSED CONSTRUCTION OF TURKANA UNIVERSITY (PHASE 1) STUDENT HOSTEL WITH ASSOCIATED AMENITIES AND INFRASTRUCTURE IN TURKANA COUNTY.",
                ContractSum = 616975867m,
                StartDate = new DateTime(2025, 10, 6),
                EndDate = new DateTime(2026, 10, 6),
                Status = ProjectStatus.Active,
                Latitude = 3.069444,
                Longitude = 35.614167,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 12,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000093", // Celestine Jerono
                WardId = WardSeedData.Wards[53].Id, // Kanamkemer
                ClusterId = ClusterSeedData.Clusters[6].Id, // University Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000059"),
                Name = "Bomet University Hostels",
                TenderNumber = "MLPWHUD/SDHUD/AHP/353/2024-2025",
                ContractorName = "Rhombus Concrete Limited",
                ConsultantName = "Dama Services",
                Description = "Bomet university Hostels AHP",
                ContractSum = 381780923m,
                StartDate = new DateTime(2025, 12, 3),
                EndDate = new DateTime(2027, 6, 3),
                Status = ProjectStatus.Active,
                Latitude = -0.792072,
                Longitude = 35.332051,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 4.5m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000106", // Geophry Okeyo
                WardId = WardSeedData.Wards[0].Id, // Need appropriate Nyongores ward
                ClusterId = ClusterSeedData.Clusters[6].Id, // University Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // TVET Hostels
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000060"),
                Name = "Maasai Mara TVC Hostels",
                TenderNumber = "MLPWHUD/SDHUD/AHP/516/2024-2025",
                ContractorName = "Snavem Enterprises Ltd",
                ConsultantName = "Dama Services",
                Description = "Student village (hostel blocks) with associated infrastructure",
                ContractSum = 143719318.35m,
                StartDate = new DateTime(2026, 1, 29),
                EndDate = new DateTime(2027, 1, 28),
                Status = ProjectStatus.Active,
                Latitude = -1.108336,
                Longitude = 36.005554,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 8.20m,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000009", // Olivia Wanyama
                WardId = WardSeedData.Wards[41].Id, // Need Ildamat ward
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000061"),
                Name = "Students Village at Eldama Ravine TVC",
                TenderNumber = "MLPWHUD/SDHUD/AHP/321/2024-2025",
                ContractorName = "Nomic Agency",
                ConsultantName = "Tectonics Consultants",
                Description = "PROPOSED STUDENTS VILLAGE AND ASSOCIATED INFRASTRUCTURE AT ELDAMA RAVINE TVC",
                ContractSum = 155146587.81m,
                StartDate = new DateTime(2025, 11, 30),
                EndDate = new DateTime(2026, 12, 1),
                Status = ProjectStatus.Active,
                Latitude = 0.03925,
                Longitude = 35.72821,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1,
                LastProgressUpdate = new DateTime(2026, 2, 26),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000062", // Collins Maina
                WardId = WardSeedData.Wards[49].Id, // Koibatek
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000062"),
                Name = "Student Village at Heroes TTI",
                TenderNumber = "MLPWHUD/SDHUD/AHP/502/2024-2025",
                ContractorName = "Lenich Global Ltd",
                ConsultantName = "Dama Services",
                Description = "PROPOSED CONSTRUCTION OF A STUDENT VILLAGE AND INFRASTRUCTURE AT HEROES TTI IN BAHATI CONSTITUENCY NAKURU COUNTY",
                ContractSum = 146916648.16m,
                StartDate = new DateTime(2025, 12, 16),
                EndDate = new DateTime(2026, 12, 16),
                Status = ProjectStatus.Active,
                Latitude = -0.246973,
                Longitude = 36.149182,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 16.29m,
                LastProgressUpdate = new DateTime(2026, 1, 23),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000077", // Dickson Losute
                WardId = WardSeedData.Wards[28].Id, // Kabatini
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000063"),
                Name = "Students Village at Total TVC Kuresoi North",
                TenderNumber = "MLPWHUD/SDHUD/AHP/504/2024-2025",
                ContractorName = "Splash General Supplies Limited",
                ConsultantName = "Dama Services",
                Description = "PROPOSED CONSTRUCTION OF A STUDENTS VILLAGE AND ASSOCIATED INFRASTRUCTURE IN TOTAL TVC KURESOI NORTH NAKURU COUNTY. Amenities: Guardhouse, garbage receptacles and a powerhouse. External works: Roads & Parking works, Sewer, Underground water tank, borehole and waste.",
                ContractSum = 215989361.69m,
                StartDate = new DateTime(2026, 2, 16),
                EndDate = new DateTime(2027, 2, 16),
                Status = ProjectStatus.Active,
                Latitude = -0.16,
                Longitude = 35.69,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 0,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000067", // Felistus Chepkemoi
                WardId = WardSeedData.Wards[39].Id, // Kamara
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000064"),
                Name = "Student Village at KMTC Kapenguria",
                TenderNumber = "MLPWHUD/SDHUD/AHP/574/2024-2025",
                ContractorName = "Vanqo Roads and Engineering Limited",
                ConsultantName = "Morphosis Limited",
                Description = "Proposed construction of a student village and associated infrastructure at kmtc kapenguria",
                ContractSum = 220652721.50m,
                StartDate = new DateTime(2026, 1, 16),
                EndDate = new DateTime(2027, 1, 16),
                Status = ProjectStatus.Active,
                Latitude = 1.24,
                Longitude = 35.12,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000084", // Collins Mudoga
                WardId = WardSeedData.Wards[61].Id, // Kapenguria
                ClusterId = ClusterSeedData.Clusters[8].Id, // Medical Training College Hostels
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000065"),
                Name = "Sigor Vocational Training Centre Hostels",
                TenderNumber = "MLPWHUD/SDHUD/AHP/575/2025",
                ContractorName = "Wanes Ventures Ltd",
                ConsultantName = "Morphosis Ltd",
                Description = "Construction of students village at Sigor vocational training centre",
                ContractSum = 148790986.25m,
                StartDate = new DateTime(2026, 1, 1),
                EndDate = new DateTime(2027, 1, 13),
                Status = ProjectStatus.Active,
                Latitude = 1.49597,
                Longitude = 35.47271,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1.2m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000085", // Timothy Bwayo
                WardId = WardSeedData.Wards[59].Id, // Weiwei
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000066"),
                Name = "Students Village at Kilgoris TVC",
                TenderNumber = "MLPWHUD/SDHUD/AHP/515/2024-2025",
                ContractorName = "Ellys Engineering Works",
                ConsultantName = "Dama Services Ltd",
                Description = "PROPOSED CONSTRUCTION OF STUDENTS VILLAGE AND ASSOCIATED INFRASTRUCTURE AT KILGORIS CONSTITUENCY, NAROK COUNTY",
                ContractSum = 141581198.43m,
                StartDate = new DateTime(2025, 12, 1),
                EndDate = new DateTime(2026, 12, 1),
                Status = ProjectStatus.Active,
                Latitude = -0.99771,
                Longitude = 34.781502,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 3,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000118", // Mercy Chelangat
                WardId = WardSeedData.Wards[46].Id, // Shang'oe
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000067"),
                Name = "Students Village at MTRH",
                TenderNumber = "MLPWHUD/SDHUD/UDD/301/2024-2025",
                ContractorName = "Tenet Engineering Limited",
                ConsultantName = "BECS Consultancy",
                Description = "Proposed Construction of A Students Village And Associated Infrastructure at MTRH. Located in Kiplombe. Uasin Gishu County.",
                ContractSum = 616925785.02m,
                StartDate = new DateTime(2026, 1, 22),
                EndDate = new DateTime(2027, 1, 23),
                Status = ProjectStatus.Active,
                Latitude = 0.548161,
                Longitude = 35.286149,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 3.83m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000074", // Gaylord Nyasende
                WardId = WardSeedData.Wards[6].Id, // Kiplombe
                ClusterId = ClusterSeedData.Clusters[8].Id, // Medical Training College Hostels
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000068"),
                Name = "Chepareria VTC Hostels",
                TenderNumber = "MLPWHUD/SDHUD/AHP/576/2024-2025",
                ContractorName = "Wanes Ventures Limited",
                ConsultantName = "Morphosis Counsultancy",
                Description = "Construction of Students Hostels and Associated Infrastructure in Chepareria VTC, Pokot South Constituency, West Pokot County.",
                ContractSum = 153051745.14m,
                StartDate = new DateTime(2026, 2, 26),
                EndDate = new DateTime(2027, 2, 26),
                Status = ProjectStatus.Active,
                Latitude = 1.389017,
                Longitude = 35.190992,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 0,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000114", // Sidney Serem
                WardId = WardSeedData.Wards[58].Id, // Chepareria
                ClusterId = ClusterSeedData.Clusters[7].Id, // TVET Hostels Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT DEPARTMENT - FISH MARKETS ====================
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000069"),
                Name = "Lowarengak Fish Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/194/2024-2025",
                ContractorName = "Lenich Global Ltd",
                ConsultantName = "Morphosis Limited",
                Description = "Proposed Construction of Lowarengak Fish Market in Turkana North Constituency, Turkana County.",
                ContractSum = 185776074.75m,
                StartDate = new DateTime(2025, 11, 7),
                EndDate = new DateTime(2026, 11, 7),
                Status = ProjectStatus.Active,
                Latitude = 4.279788,
                Longitude = 35.892157,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 0,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000033", // Felix Onyonge
                WardId = WardSeedData.Wards[56].Id, // Lake Zone
                ClusterId = ClusterSeedData.Clusters[24].Id, // Fish Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000070"),
                Name = "Kalokol Fish Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/193/2024-2025",
                ContractorName = "Finorize Limited",
                ConsultantName = "Morphosis",
                Description = "Located at the heart of the Lake Turkana fishing belt, the market is expected to cement Kalokol's position as a regional fish supply hub serving East Africa and international markets. The market will feature 500 stalls, cold storage rooms, fish landing and packaging areas, sanitation blocks, waste disposal sites, and breastfeeding spaces for mothers.",
                ContractSum = 183712887.75m,
                StartDate = new DateTime(2026, 1, 29),
                EndDate = new DateTime(2027, 1, 29),
                Status = ProjectStatus.Active,
                Latitude = 3.716667,
                Longitude = 35.833333,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 1.40m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000072", // John Lopeyok
                WardId = WardSeedData.Wards[55].Id, // Kalokol
                ClusterId = ClusterSeedData.Clusters[24].Id, // Fish Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT DEPARTMENT - ULTRA-MODERN MARKETS ====================
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000071"),
                Name = "Eldoret 64-UltraModern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/309/2023-2024",
                ContractorName = "Vaghjiyani Enterprise Limited",
                ConsultantName = "BECS",
                Description = "The market will accommodate 3850 traders, it has two basements with 214 parking slots",
                ContractSum = 1549256804.04m,
                StartDate = new DateTime(2024, 3, 7),
                EndDate = new DateTime(2026, 3, 7),
                Status = ProjectStatus.Active,
                Latitude = 0.515961,
                Longitude = 35.272758,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 60,
                LastProgressUpdate = new DateTime(2026, 2, 23),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000038", // Dennis Ng'ang'a
                WardId = WardSeedData.Wards[7].Id, // Huruma
                ClusterId = ClusterSeedData.Clusters[25].Id, // Ultra-Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT DEPARTMENT - MODERN MARKETS (Additional) ====================
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000072"),
                Name = "Kapsabet Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/26/2023-2024",
                ContractorName = "Jyan Construction Services",
                ConsultantName = "KEMSAL",
                Description = "1000 PAX Market Block -1, Service Block -1, Waste cubicle -1, Power House -1",
                ContractSum = 418039284.30m,
                StartDate = new DateTime(2025, 8, 16),
                EndDate = new DateTime(2027, 2, 16),
                Status = ProjectStatus.Active,
                Latitude = 0.2039,
                Longitude = 35.1063,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 34.25m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000054", // Peter Otieno
                WardId = WardSeedData.Wards[23].Id, // Kapsabet
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000073"),
                Name = "Nandi Hills Modern Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/088/2024-2025",
                ContractorName = "Grayan Investments Limited",
                ConsultantName = "Kemsal Consultant",
                Description = "The comprises of a G+2, 50x62 750PAX market block, an ablution block, mechanical, electrical works, plumbing works, service house, waste cubicle and office block.",
                ContractSum = 356065660m,
                StartDate = new DateTime(2025, 5, 7),
                EndDate = new DateTime(2026, 5, 7),
                Status = ProjectStatus.Active,
                Latitude = 0.106257,
                Longitude = 35.183235,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 25.55m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000066", // Benjamin Wafula
                WardId = WardSeedData.Wards[19].Id, // Nandi Hills
                ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000074"),
                Name = "Ewaso Ngiro ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/089/2024-2025",
                ContractorName = "Budgets Construction Ltd",
                ConsultantName = "Nil",
                Description = "Ongoing construction of ESP market",
                ContractSum = 110850481m,
                StartDate = new DateTime(2024, 7, 17),
                EndDate = new DateTime(2025, 1, 17),
                Status = ProjectStatus.Active,
                Latitude = -1.153364,
                Longitude = 35.761588,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 52.94m,
                LastProgressUpdate = new DateTime(2026, 2, 25),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000068", // Lilian Otieno
                WardId = WardSeedData.Wards[42].Id, // Ewaso Ngiro
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000075"),
                Name = "Kinungi and Oseria ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/AHP/300/2024-2025",
                ContractorName = "De Zonne Group",
                ConsultantName = "Tej Consultant",
                Description = "The site is active and is in Mobilization of Materials Stage. Excavation and Blinding is complete.",
                ContractSum = 67876764m,
                StartDate = new DateTime(2026, 2, 3),
                EndDate = new DateTime(2026, 11, 3),
                Status = ProjectStatus.Active,
                Latitude = -0.784635,
                Longitude = 36.432858,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 8.80m,
                LastProgressUpdate = new DateTime(2026, 3, 1),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000071", // Dennis Mvoi
                WardId = WardSeedData.Wards[31].Id, // Kinungi
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000076"),
                Name = "Mulot ESP Market",
                TenderNumber = "MLPWHUD/SDHUD/UDD/204/2023-2024 CLUSTER 10",
                ContractorName = "Square Stone Developers",
                ConsultantName = "N/A",
                Description = "Proposed construction of esp market in bomet county (mulot) - Slow progress of work, Low mobilization of materials, Low mobilization of labour, Behind the schedule",
                ContractSum = 14522553.50m,
                StartDate = new DateTime(2024, 4, 30),
                EndDate = new DateTime(2024, 10, 30),
                Status = ProjectStatus.Active,
                Latitude = -0.9374,
                Longitude = 35.4213,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 64,
                LastProgressUpdate = new DateTime(2026, 2, 27),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000078", // Cleophas Kibon
                WardId = WardSeedData.Wards[0].Id, // Need appropriate Kipreres ward
                ClusterId = ClusterSeedData.Clusters[13].Id, // ESP Markets Cluster 10
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new Project
            {
                Id = Guid.Parse("70000000-0000-0000-0000-000000000077"),
                Name = "ASTU Gilgil Housing",
                TenderNumber = "MPLWHUD/SDHUD/AHP/140/2024-2025",
                ContractorName = "Checo Construction Limited",
                ConsultantName = "Tej Architects",
                Description = "Proposed completion of 1 block of 12 no.two bedroom and 48 no bedsitters unit at Anti-stock theft unit (ASTU) gil gil Nakuru county. The project involved the construction of 60 units(48 no bedsitters unit and 12no.two bedroom units) in one block G+3. It comprises of a parking space, garbage receptacle, green space and underground water tank.",
                ContractSum = 75268186m,
                StartDate = new DateTime(2025, 10, 28),
                EndDate = new DateTime(2026, 10, 28),
                Status = ProjectStatus.Active,
                Latitude = -0.470784,
                Longitude = 36.334415,
                RadiusInMeters = 500,
                CurrentPhysicalProgress = 35.60m,
                LastProgressUpdate = new DateTime(2026, 2, 28),
                LastUpdatedById = "COW00000-0000-0000-0000-000000000112", // Jane Wangeci
                WardId = WardSeedData.Wards[34].Id, // Gil gil
                ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            // Add these to ProjectSeedData.Projects list

                // ==================== ADDITIONAL MISSING PROJECTS ====================

                // 1. Bahati Modern Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000078"),
                    Name = "Bahati Modern Market",
                    TenderNumber = "MLPWHUD/SDHUD/AHP/346/2024-2025",
                    ContractorName = "Adawa Investment Company",
                    ConsultantName = "Dama Services Limited",
                    Description = "Located in Bahati Constituency, Nakuru County. Modern market construction with associated facilities.",
                    ContractSum = 249505168.50m,
                    StartDate = new DateTime(2025, 10, 2),
                    EndDate = new DateTime(2026, 10, 27),
                    Status = ProjectStatus.Active,
                    Latitude = -0.154841,
                    Longitude = 36.144773,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 20,
                    LastProgressUpdate = new DateTime(2026, 2, 27),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000011", // Gideon Ngacha
                    WardId = WardSeedData.Wards[27].Id, // Bahati
                    ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 2. Kaptumo Modern Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000079"),
                    Name = "Kaptumo Modern Market",
                    TenderNumber = "MLPWHUD/SDHUD/SUS/UDD/109/2023-2024",
                    ContractorName = "Abeera Enterprises LTD",
                    ConsultantName = "KEMSAL",
                    Description = "Kaptumo market located in Nandi County, Aldai Constituency, Kaptumo Kaboi Ward.",
                    ContractSum = 270757858m,
                    StartDate = new DateTime(2025, 8, 26),
                    EndDate = new DateTime(2026, 8, 26),
                    Status = ProjectStatus.Active,
                    Latitude = 0.07651,
                    Longitude = 35.07226,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 18.02m,
                    LastProgressUpdate = new DateTime(2026, 2, 28),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000017", // Kelvin Namu Mugendi
                    WardId = WardSeedData.Wards[26].Id, // Kaptumo/Kaboi
                    ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 3. Subukia ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000080"),
                    Name = "Subukia ESP Market",
                    TenderNumber = "MLPWHUD/SDHUD/UDD/198/2023-2024",
                    ContractorName = "Axela Holdings Limited",
                    ConsultantName = "Tej Consortium",
                    Description = "G+1 esp market with a capacity of 204 vendors.",
                    ContractSum = 180555172.00m,
                    StartDate = new DateTime(2024, 6, 5),
                    EndDate = new DateTime(2025, 1, 13),
                    Status = ProjectStatus.Active,
                    Latitude = 0.00364,
                    Longitude = 36.22974,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 79,
                    LastProgressUpdate = new DateTime(2026, 2, 25),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000018", // Daniel Githiomi
                    WardId = WardSeedData.Wards[37].Id, // Subukia
                    ClusterId = ClusterSeedData.Clusters[11].Id, // ESP Markets Cluster 4
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 4. Nessuit ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000081"),
                    Name = "Nessuit ESP Market",
                    TenderNumber = "MLPWHUD/SDHUD/UDD/098/2024-2025-CLUSTER 93",
                    ContractorName = "Quartz Company Limited",
                    ConsultantName = "Tej Consortium",
                    Description = "ESP market in Njoro Constituency, Nakuru County.",
                    ContractSum = 111770460.00m,
                    StartDate = new DateTime(2025, 7, 23),
                    EndDate = new DateTime(2026, 4, 23),
                    Status = ProjectStatus.Active,
                    Latitude = -0.390172,
                    Longitude = 35.896316,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 62.49m,
                    LastProgressUpdate = new DateTime(2026, 1, 27),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000020", // Kelvin Kaptum
                    WardId = WardSeedData.Wards[34].Id, // Njoro
                    ClusterId = ClusterSeedData.Clusters[22].Id, // ESP Markets Cluster 93
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 5. Kericho ESP Market (Economic Stimulus Program)
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000082"),
                    Name = "Kericho ESP Market",
                    TenderNumber = "220",
                    ContractorName = "Resjos Enterprises Limited",
                    ConsultantName = "No consultant",
                    Description = "Economic stimulus program (ESP) market in Bureti Constituency, Kericho County.",
                    ContractSum = 162008145.00m,
                    StartDate = new DateTime(2024, 4, 26),
                    EndDate = new DateTime(2024, 10, 25),
                    Status = ProjectStatus.Active,
                    Latitude = -0.63142,
                    Longitude = 35.19748,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 85,
                    LastProgressUpdate = new DateTime(2026, 2, 27),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000021", // Charity Chelagat
                    WardId = WardSeedData.Wards.First(w => w.Code == "KKT").Id, // Need appropriate Kapkatet ward
                    ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 6. Naivasha SEZA AHP
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000083"),
                    Name = "Naivasha SEZA AHP",
                    TenderNumber = "MLPWHUD/SDHUD/AHP/438/2023-2024",
                    ContractorName = "Sava Builders Limited",
                    ConsultantName = "Tej Consortium",
                    Description = "The site has both affordable and Social units including social amenities.",
                    ContractSum = 2142408000m,
                    StartDate = new DateTime(2025, 7, 25),
                    EndDate = new DateTime(2027, 1, 22),
                    Status = ProjectStatus.Active,
                    Latitude = -1.015488,
                    Longitude = 36.469896,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 15.62m,
                    LastProgressUpdate = new DateTime(2026, 2, 27),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000022", // Phineas Lingera
                    WardId = WardSeedData.Wards[32].Id, // Maai Mahiu
                    ClusterId = ClusterSeedData.Clusters[1].Id, // South Rift AHP Cluster
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 7. Seguton ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000084"),
                    Name = "Seguton ESP Market",
                    TenderNumber = "MLPWHUD/SDHUD/SUD/258/2023-2024",
                    ContractorName = "Floliz Contractors Limited",
                    ConsultantName = "Dama Services Limited",
                    Description = "The project Comprises of 1 Market Block G+1 an Ablution Block and it's amenities.",
                    ContractSum = 151147005.00m,
                    StartDate = new DateTime(2024, 8, 26),
                    EndDate = new DateTime(2025, 2, 26),
                    Status = ProjectStatus.Active,
                    Latitude = -0.371877,
                    Longitude = 35.684658,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 74,
                    LastProgressUpdate = new DateTime(2026, 2, 28),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000023", // Jeff Ongala
                    WardId = WardSeedData.Wards.First(w => w.Code == "NYT").Id, // Need appropriate Seguton ward
                    ClusterId = ClusterSeedData.Clusters[14].Id, // ESP Markets Cluster 12
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 8. Keringet ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000085"),
                    Name = "Keringet ESP Market",
                    TenderNumber = "MLPWHUD/SDHUD/UDD/198/2023-2024 CLUSTER4",
                    ContractorName = "Axela Holdings Ltd",
                    ConsultantName = "Tej Consortium",
                    Description = "The proposed market project is located in Keringet Town, Nakuru County.",
                    ContractSum = 180555172.00m,
                    StartDate = new DateTime(2024, 5, 22),
                    EndDate = new DateTime(2024, 11, 22),
                    Status = ProjectStatus.Active,
                    Latitude = 0.427105,
                    Longitude = 35.69197,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 72,
                    LastProgressUpdate = new DateTime(2026, 2, 25),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000024", // Betty Chebii
                    WardId = WardSeedData.Wards[40].Id, // Keringet
                    ClusterId = ClusterSeedData.Clusters[11].Id, // ESP Markets Cluster 4
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 9. Moi's Modern Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000086"),
                    Name = "Moi's Modern Market",
                    TenderNumber = "MLPWHUD/SDHUD/UDD/010/2024-2025",
                    ContractorName = "Firmbridge Limited",
                    ConsultantName = "Morphosis Limited",
                    Description = "The site is located in moi's bridge municipality market in uasin gishu county.",
                    ContractSum = 381572751.49m,
                    StartDate = new DateTime(2025, 11, 17),
                    EndDate = new DateTime(2026, 11, 16),
                    Status = ProjectStatus.Active,
                    Latitude = 0.87394,
                    Longitude = 35.11992,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 0,
                    LastProgressUpdate = new DateTime(2026, 2, 27),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000025", // Emmanuel Wanyonyi
                    WardId = WardSeedData.Wards[10].Id, // Moi's Bridge
                    ClusterId = ClusterSeedData.Clusters[23].Id, // Modern Markets Cluster
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 10. Rongai ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000087"),
                    Name = "Rongai ESP Market",
                    TenderNumber = "MLPWHUD/SDHUD/ESP/225/2023-2024 – CLUSTER 31",
                    ContractorName = "Moran Ridge Ltd",
                    ConsultantName = "N/A",
                    Description = "G+1 market block, an ablution block, mechanical, electrical works and waste cubicles. Located at Rongai Market in Visoi Ward, Rongai Sub-County in Nakuru County.",
                    ContractSum = 110653512.00m,
                    StartDate = new DateTime(2024, 6, 12),
                    EndDate = new DateTime(2024, 12, 12),
                    Status = ProjectStatus.Active,
                    Latitude = -0.173871,
                    Longitude = 35.862151,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 52.10m,
                    LastProgressUpdate = new DateTime(2026, 2, 25),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000026", // Stanslaus Njue
                    WardId = WardSeedData.Wards[35].Id, // Visoi
                    ClusterId = ClusterSeedData.Clusters[17].Id, // ESP Markets Cluster 31
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 11. Ollessos ESP Market
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000088"),
                    Name = "Ollessos ESP Market",
                    TenderNumber = "110",
                    ContractorName = "Golbo Holding Limited Company",
                    ConsultantName = "KEMSAL",
                    Description = "Proposed construction of ollessos esp market in Nandi Hills Constituency.",
                    ContractSum = 56852500m,
                    StartDate = new DateTime(2025, 7, 4),
                    EndDate = new DateTime(2026, 4, 28),
                    Status = ProjectStatus.Active,
                    Latitude = 0.166667,
                    Longitude = 35.15,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 5,
                    LastProgressUpdate = new DateTime(2026, 2, 20),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000065", // Sammy Kipruto
                    WardId = WardSeedData.Wards[20].Id, // Ollessos
                    ClusterId = ClusterSeedData.Clusters[26].Id, // ESP Markets General
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 12. West Pokot ESP Markets
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000089"),
                    Name = "West Pokot ESP Markets",
                    TenderNumber = "MLPWHUD/SDHUD/UDD/241/2023-2024 – CLUSTER 47",
                    ContractorName = "Clara Tiamale",
                    ConsultantName = "N/A",
                    Description = "Proposed construction of ESP Markets and Supporting Facilities in West-Pokot County. 30*36 Market Block.",
                    ContractSum = 58341939m,
                    StartDate = new DateTime(2024, 4, 18),
                    EndDate = new DateTime(2024, 10, 18),
                    Status = ProjectStatus.Active,
                    Latitude = 1.43746,
                    Longitude = 35.35484,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 54.52m,
                    LastProgressUpdate = new DateTime(2026, 2, 25),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000058", // Alex Maina
                    WardId = WardSeedData.Wards.First(w => w.Code == "BTI").Id, // Need appropriate Batei ward
                    ClusterId = ClusterSeedData.Clusters[18].Id, // ESP Markets Cluster 47
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },

                // 13. Limuko Primary School Classrooms
                new Project
                {
                    Id = Guid.Parse("70000000-0000-0000-0000-000000000090"),
                    Name = "Limuko Primary School Classrooms",
                    TenderNumber = "MLPHUD/SDHUD/HUD/260/2024-2025",
                    ContractorName = "Megapro Engineering Ltd",
                    ConsultantName = "No consultant",
                    Description = "Construction of 10 classrooms in Limuko primary school, Bahati Constituency, Nakuru County.",
                    ContractSum = 49893884.25m,
                    StartDate = new DateTime(2025, 3, 7),
                    EndDate = new DateTime(2026, 3, 6),
                    Status = ProjectStatus.Active,
                    Latitude = 0.211886,
                    Longitude = 36.161838,
                    RadiusInMeters = 500,
                    CurrentPhysicalProgress = 75,
                    LastProgressUpdate = new DateTime(2026, 2, 25),
                    LastUpdatedById = "COW00000-0000-0000-0000-000000000109", // Salome Muthini
                    WardId = WardSeedData.Wards[28].Id, // Kabatini
                    ClusterId = ClusterSeedData.Clusters[5].Id, // Social Housing Cluster (SUD)
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "system-seed",
                    IsDeleted = false
                },
        };

            // Project Assignments (linking COWs and TLs to projects)
            public static readonly List<(Guid ProjectId, string UserId, string Role)> ProjectAssignments = new()
        {
            // Housing Department - AHP Projects
            (Projects[0].Id, "COW00000-0000-0000-0000-000000000001", UserRoles.ClerkOfWorks), // Maili Tatu - Daniel Kibowen
            (Projects[1].Id, "COW00000-0000-0000-0000-000000000003", UserRoles.ClerkOfWorks), // Kidiwa - Carolyne Simiyu
            (Projects[2].Id, "COW00000-0000-0000-0000-000000000007", UserRoles.ClerkOfWorks), // Pioneer - Sailas Rugah
            (Projects[3].Id, "COW00000-0000-0000-0000-000000000008", UserRoles.ClerkOfWorks), // Nandi Hills - Abel Kipruto
            (Projects[4].Id, "COW00000-0000-0000-0000-000000000032", UserRoles.ClerkOfWorks), // Chesumei - Irwin Jara
            (Projects[5].Id, "COW00000-0000-0000-0000-000000000030", UserRoles.ClerkOfWorks), // Eldoret Railway - Emmanuel Sikuku
            (Projects[6].Id, "COW00000-0000-0000-0000-000000000063", UserRoles.ClerkOfWorks), // Chepkorio - Victor Kiprop
            (Projects[7].Id, "COW00000-0000-0000-0000-000000000015", UserRoles.ClerkOfWorks), // Iten Phase I - Wangah Ian
            (Projects[8].Id, "COW00000-0000-0000-0000-000000000010", UserRoles.ClerkOfWorks), // Iten Phase II - Ian Sang
            (Projects[9].Id, "COW00000-0000-0000-0000-000000000089", UserRoles.ClerkOfWorks), // Kimumu - Denies Langat
            (Projects[10].Id, "COW00000-0000-0000-0000-000000000019", UserRoles.ClerkOfWorks), // Kapsuswa - Edwin Ondeng
            (Projects[11].Id, "COW00000-0000-0000-0000-000000000057", UserRoles.ClerkOfWorks), // Suam Border - Mathias Munyendo
            (Projects[12].Id, "COW00000-0000-0000-0000-000000000004", UserRoles.ClerkOfWorks), // Majengo Talai - Jobson Birundu
            (Projects[13].Id, "COW00000-0000-0000-0000-000000000016", UserRoles.ClerkOfWorks), // Sotik - Ramadlay Kiptoo
            (Projects[14].Id, "COW00000-0000-0000-0000-000000000034", UserRoles.ClerkOfWorks), // Bahati Phase 2 - Brian Mosoti
            (Projects[15].Id, "COW00000-0000-0000-0000-000000000040", UserRoles.ClerkOfWorks), // Kabarnet - Robert Kimutai
            (Projects[16].Id, "COW00000-0000-0000-0000-000000000028", UserRoles.ClerkOfWorks), // Marigat - Praise Lekesio
            (Projects[17].Id, "COW00000-0000-0000-0000-000000000027", UserRoles.ClerkOfWorks), // Kilgoris - Robert Ronoh
            (Projects[18].Id, "COW00000-0000-0000-0000-000000000041", UserRoles.ClerkOfWorks), // Buffalo Mall - Archimedes Mulumba
            (Projects[19].Id, "COW00000-0000-0000-0000-000000000083", UserRoles.ClerkOfWorks), // Karagita - Benson Charagu
            (Projects[20].Id, "COW00000-0000-0000-0000-000000000104", UserRoles.ClerkOfWorks), // Mogotio - Kennedy Kiprotich
            (Projects[21].Id, "COW00000-0000-0000-0000-000000000012", UserRoles.ClerkOfWorks), // Maralal - Vincent Odhiambo
            (Projects[22].Id, "COW00000-0000-0000-0000-000000000099", UserRoles.ClerkOfWorks), // Archers Post - Cliff Wanjala

            // Urban Development - ESP Markets
            (Projects[23].Id, "COW00000-0000-0000-0000-000000000002", UserRoles.ClerkOfWorks), // Kolongei - Vincent Wekesa
            (Projects[24].Id, "COW00000-0000-0000-0000-000000000005", UserRoles.ClerkOfWorks), // Sibanga - George Wekesa
            (Projects[25].Id, "COW00000-0000-0000-0000-000000000006", UserRoles.ClerkOfWorks), // Naikarra - Nixon Kipchirchir
            (Projects[26].Id, "COW00000-0000-0000-0000-000000000031", UserRoles.ClerkOfWorks), // Ololulunga - Calvince Nyakinda
            (Projects[27].Id, "COW00000-0000-0000-0000-000000000037", UserRoles.ClerkOfWorks), // Ainabkoi - Peter Kakuko
            (Projects[28].Id, "COW00000-0000-0000-0000-000000000039", UserRoles.ClerkOfWorks), // Sotik Modern - Isaac Chege
            (Projects[29].Id, "COW00000-0000-0000-0000-000000000042", UserRoles.ClerkOfWorks), // Kapcherop - Stanley Ronoh
            (Projects[30].Id, "COW00000-0000-0000-0000-000000000045", UserRoles.ClerkOfWorks), // Kilgoris Modern - Duncan Maruti
            (Projects[31].Id, "COW00000-0000-0000-0000-000000000046", UserRoles.ClerkOfWorks), // Bikeke - Felix Osok
            (Projects[32].Id, "COW00000-0000-0000-0000-000000000050", UserRoles.ClerkOfWorks), // Kesses - Brian Kipruto
            (Projects[33].Id, "COW00000-0000-0000-0000-000000000051", UserRoles.ClerkOfWorks), // Olkalou - Albert Mulonzi
            (Projects[34].Id, "COW00000-0000-0000-0000-000000000052", UserRoles.ClerkOfWorks), // Matharu - Philemon Koech
            (Projects[35].Id, "COW00000-0000-0000-0000-000000000053", UserRoles.ClerkOfWorks), // Birunda - Evans Kipserem
            (Projects[36].Id, "COW00000-0000-0000-0000-000000000055", UserRoles.ClerkOfWorks), // Kiptagich - Francisca Kisyula
            (Projects[37].Id, "COW00000-0000-0000-0000-000000000056", UserRoles.ClerkOfWorks), // Maraba - Charles Ekirapa
            (Projects[38].Id, "COW00000-0000-0000-0000-000000000059", UserRoles.ClerkOfWorks), // Makutano - Nakus Kachurkwel
            (Projects[39].Id, "COW00000-0000-0000-0000-000000000060", UserRoles.ClerkOfWorks), // Kiminini Modern - Milton Wamukota
            (Projects[40].Id, "COW00000-0000-0000-0000-000000000080", UserRoles.ClerkOfWorks), // Suam Modern - Sostine Wanyonyi
            (Projects[41].Id, "COW00000-0000-0000-0000-000000000081", UserRoles.ClerkOfWorks), // Kapseret - Faith Chebet
            (Projects[42].Id, "COW00000-0000-0000-0000-000000000086", UserRoles.ClerkOfWorks), // Kabatini - Eric Kamau
            (Projects[43].Id, "COW00000-0000-0000-0000-000000000087", UserRoles.ClerkOfWorks), // Nyamamithi - Emmanuel Kimwaki
            (Projects[44].Id, "COW00000-0000-0000-0000-000000000091", UserRoles.ClerkOfWorks), // Mauche - Peter Kiplangat
            (Projects[45].Id, "COW00000-0000-0000-0000-000000000094", UserRoles.ClerkOfWorks), // Baragoi - Michael Lepartobiko
            (Projects[46].Id, "COW00000-0000-0000-0000-000000000098", UserRoles.ClerkOfWorks), // Mosoriot - Robert Kimutai
            (Projects[47].Id, "COW00000-0000-0000-0000-000000000102", UserRoles.ClerkOfWorks), // Chebunyo - Ezra Rono
            (Projects[48].Id, "COW00000-0000-0000-0000-000000000103", UserRoles.ClerkOfWorks), // Kibigori - Ezra Ayabei
            (Projects[49].Id, "COW00000-0000-0000-0000-000000000105", UserRoles.ClerkOfWorks), // Lower Moiben - Pascal Kimutai
            (Projects[50].Id, "COW00000-0000-0000-0000-000000000107", UserRoles.ClerkOfWorks), // Sigor - Clyite Kibet
            (Projects[51].Id, "COW00000-0000-0000-0000-000000000110", UserRoles.ClerkOfWorks), // Kakuma - Locha Lokwanamor
            (Projects[52].Id, "COW00000-0000-0000-0000-000000000111", UserRoles.ClerkOfWorks), // Kiptangwanyi - Chepyegon Mercy
            (Projects[53].Id, "COW00000-0000-0000-0000-000000000113", UserRoles.ClerkOfWorks), // Uhuru - Sheila Chelang'at
            (Projects[54].Id, "COW00000-0000-0000-0000-000000000116", UserRoles.ClerkOfWorks), // Iten ESP - Ronald Kirui
            (Projects[55].Id, "COW00000-0000-0000-0000-000000000119", UserRoles.ClerkOfWorks), // Iten Modern - James Makheti

            // Institutional Housing
            (Projects[56].Id, "COW00000-0000-0000-0000-000000000117", UserRoles.ClerkOfWorks), // Maasai Mara Uni - Emmanuel Kiprotich
            (Projects[57].Id, "COW00000-0000-0000-0000-000000000093", UserRoles.ClerkOfWorks), // Turkana Uni - Celestine Jerono
            (Projects[58].Id, "COW00000-0000-0000-0000-000000000106", UserRoles.ClerkOfWorks), // Bomet Uni - Geophry Okeyo
            (Projects[59].Id, "COW00000-0000-0000-0000-000000000009", UserRoles.ClerkOfWorks), // Maasai Mara TVC - Olivia Wanyama
            (Projects[60].Id, "COW00000-0000-0000-0000-000000000062", UserRoles.ClerkOfWorks), // Eldama Ravine - Collins Maina
            (Projects[61].Id, "COW00000-0000-0000-0000-000000000077", UserRoles.ClerkOfWorks), // Heroes TTI - Dickson Losute
            (Projects[62].Id, "COW00000-0000-0000-0000-000000000067", UserRoles.ClerkOfWorks), // Total TVC - Felistus Chepkemoi
            (Projects[63].Id, "COW00000-0000-0000-0000-000000000084", UserRoles.ClerkOfWorks), // KMTC Kapenguria - Collins Mudoga
            (Projects[64].Id, "COW00000-0000-0000-0000-000000000085", UserRoles.ClerkOfWorks), // Sigor VTC - Timothy Bwayo
            (Projects[65].Id, "COW00000-0000-0000-0000-000000000118", UserRoles.ClerkOfWorks), // Kilgoris TVC - Mercy Chelangat
            (Projects[66].Id, "COW00000-0000-0000-0000-000000000074", UserRoles.ClerkOfWorks), // MTRH - Gaylord Nyasende
            (Projects[67].Id, "COW00000-0000-0000-0000-000000000114", UserRoles.ClerkOfWorks), // Chepareria VTC - Sidney Serem

            // Fish Markets
            (Projects[68].Id, "COW00000-0000-0000-0000-000000000033", UserRoles.ClerkOfWorks), // Lowarengak - Felix Onyonge
            (Projects[69].Id, "COW00000-0000-0000-0000-000000000072", UserRoles.ClerkOfWorks), // Kalokol - John Lopeyok

            // Ultra-Modern Market
            (Projects[70].Id, "COW00000-0000-0000-0000-000000000038", UserRoles.ClerkOfWorks), // Eldoret 64 - Dennis Ng'ang'a

            // Additional Modern Markets
            (Projects[71].Id, "COW00000-0000-0000-0000-000000000054", UserRoles.ClerkOfWorks), // Kapsabet - Peter Otieno
            (Projects[72].Id, "COW00000-0000-0000-0000-000000000066", UserRoles.ClerkOfWorks), // Nandi Hills Modern - Benjamin Wafula
            (Projects[73].Id, "COW00000-0000-0000-0000-000000000068", UserRoles.ClerkOfWorks), // Ewaso Ngiro - Lilian Otieno
            (Projects[74].Id, "COW00000-0000-0000-0000-000000000071", UserRoles.ClerkOfWorks), // Kinungi - Dennis Mvoi
            (Projects[75].Id, "COW00000-0000-0000-0000-000000000078", UserRoles.ClerkOfWorks), // Mulot - Cleophas Kibon
            (Projects[76].Id, "COW00000-0000-0000-0000-000000000112", UserRoles.ClerkOfWorks), // ASTU Gilgil - Jane Wangeci
            // ==================== ADDITIONAL MISSING COW ASSIGNMENTS ====================

            // Bahati Modern Market - Gideon Ngacha (COW011)
            (Projects[77].Id, "COW00000-0000-0000-0000-000000000011", UserRoles.ClerkOfWorks), // Bahati Modern Market

            // Kaptumo Modern Market - Kelvin Namu Mugendi (COW017)
            (Projects[78].Id, "COW00000-0000-0000-0000-000000000017", UserRoles.ClerkOfWorks), // Kaptumo Modern Market

            // Subukia ESP Market - Daniel Githiomi (COW018)
            (Projects[79].Id, "COW00000-0000-0000-0000-000000000018", UserRoles.ClerkOfWorks), // Subukia ESP Market

            // Nessuit ESP Market - Kelvin Kaptum (COW020)
            (Projects[80].Id, "COW00000-0000-0000-0000-000000000020", UserRoles.ClerkOfWorks), // Nessuit ESP Market

            // Kericho ESP Market - Charity Chelagat (COW021)
            (Projects[81].Id, "COW00000-0000-0000-0000-000000000021", UserRoles.ClerkOfWorks), // Kericho ESP Market

            // Naivasha SEZA AHP - Phineas Lingera (COW022)
            (Projects[82].Id, "COW00000-0000-0000-0000-000000000022", UserRoles.ClerkOfWorks), // Naivasha SEZA AHP

            // Seguton ESP Market - Jeff Ongala (COW023)
            (Projects[83].Id, "COW00000-0000-0000-0000-000000000023", UserRoles.ClerkOfWorks), // Seguton ESP Market

            // Keringet ESP Market - Betty Chebii (COW024)
            (Projects[84].Id, "COW00000-0000-0000-0000-000000000024", UserRoles.ClerkOfWorks), // Keringet ESP Market

            // Moi's Modern Market - Emmanuel Wanyonyi (COW025)
            (Projects[85].Id, "COW00000-0000-0000-0000-000000000025", UserRoles.ClerkOfWorks), // Moi's Modern Market

            // Rongai ESP Market - Stanslaus Njue (COW026)
            (Projects[86].Id, "COW00000-0000-0000-0000-000000000026", UserRoles.ClerkOfWorks), // Rongai ESP Market

            // Ollessos ESP Market - Sammy Kipruto (COW065)
            (Projects[87].Id, "COW00000-0000-0000-0000-000000000065", UserRoles.ClerkOfWorks), // Ollessos ESP Market

            // West Pokot ESP Markets - Alex Maina (COW058)
            (Projects[88].Id, "COW00000-0000-0000-0000-000000000058", UserRoles.ClerkOfWorks), // West Pokot ESP Markets

            // Limuko Primary School - Salome Muthini (COW109)
            (Projects[89].Id, "COW00000-0000-0000-0000-000000000109", UserRoles.ClerkOfWorks), // Limuko Primary School Classrooms

            // ==================== ADDITIONAL ASSIGNMENTS FOR DUPLICATE COWS ====================

            // Chesumei AHP - Moses Omondi (COW014) - additional COW
            (Projects[4].Id, "COW00000-0000-0000-0000-000000000014", UserRoles.ClerkOfWorks), // Chesumei AHP

            // Nandi Hills AHP - Nickson Kirui (COW029) - additional COW
            (Projects[3].Id, "COW00000-0000-0000-0000-000000000029", UserRoles.ClerkOfWorks), // Nandi Hills AHP

            // Nandi Hills AHP - Rahab Njoroge (COW115) - additional COW
            (Projects[3].Id, "COW00000-0000-0000-0000-000000000115", UserRoles.ClerkOfWorks), // Nandi Hills AHP

            // Kabarnet Town AHP - Kevin Kiprono (COW043) - additional COW
            (Projects[15].Id, "COW00000-0000-0000-0000-000000000043", UserRoles.ClerkOfWorks), // Kabarnet Town AHP

            // Kabarnet Town AHP - Abel Atebe (COW047) - additional COW
            (Projects[15].Id, "COW00000-0000-0000-0000-000000000047", UserRoles.ClerkOfWorks), // Kabarnet Town AHP

            // Pioneer AHP - Kiprotich Dennis (COW044) - additional COW
            (Projects[2].Id, "COW00000-0000-0000-0000-000000000044", UserRoles.ClerkOfWorks), // Pioneer AHP

            // Lowarengak Fish Market - Musa Erube (COW036) - additional COW
            (Projects[68].Id, "COW00000-0000-0000-0000-000000000036", UserRoles.ClerkOfWorks), // Lowarengak Fish Market

            // Sotik AHP - Robert Ouko (COW079) - additional COW
            (Projects[13].Id, "COW00000-0000-0000-0000-000000000079", UserRoles.ClerkOfWorks), // Sotik AHP

            // Technical Lead assignments (Jeremiah Miyora - TL for all projects in North Rift)
            (Projects[0].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Maili Tatu
            (Projects[1].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Kidiwa
            (Projects[2].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Pioneer
            (Projects[3].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Nandi Hills
            (Projects[4].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Chesumei
            (Projects[5].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Eldoret Railway
            (Projects[6].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Chepkorio
            (Projects[7].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Iten Phase I
            (Projects[8].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Iten Phase II
            (Projects[9].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Kimumu
            (Projects[10].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Kapsuswa
            (Projects[11].Id, "TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead), // Suam Border

            // Technical Lead assignments (Sheila Chepng'eno - TL for South Rift and other regions)
            (Projects[12].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Majengo Talai
            (Projects[13].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Sotik
            (Projects[14].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Bahati Phase 2
            (Projects[15].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kabarnet
            (Projects[16].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Marigat
            (Projects[17].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kilgoris
            (Projects[18].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Buffalo Mall
            (Projects[19].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Karagita
            (Projects[20].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Mogotio
            (Projects[21].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Maralal
            (Projects[22].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Archers Post

            // Technical Lead for all market projects
            (Projects[23].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kolongei
            (Projects[24].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Sibanga
            (Projects[25].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Naikarra
            (Projects[26].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Ololulunga
            (Projects[27].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Ainabkoi
            (Projects[28].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Sotik Modern
            (Projects[29].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kapcherop
            (Projects[30].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kilgoris Modern
            (Projects[31].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Bikeke
            (Projects[32].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kesses
            (Projects[33].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Olkalou
            (Projects[34].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Matharu
            (Projects[35].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Birunda
            (Projects[36].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kiptagich
            (Projects[37].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Maraba
            (Projects[38].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Makutano
            (Projects[39].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kiminini Modern
            (Projects[40].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Suam Modern
            (Projects[41].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kapseret
            (Projects[42].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kabatini
            (Projects[43].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Nyamamithi
            (Projects[44].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Mauche
            (Projects[45].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Baragoi
            (Projects[46].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Mosoriot
            (Projects[47].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Chebunyo
            (Projects[48].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kibigori
            (Projects[49].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Lower Moiben
            (Projects[50].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Sigor
            (Projects[51].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kakuma
            (Projects[52].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kiptangwanyi
            (Projects[53].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Uhuru
            (Projects[54].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Iten ESP
            (Projects[55].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Iten Modern

            // Technical Lead for Institutional projects
            (Projects[56].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Maasai Mara Uni
            (Projects[57].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Turkana Uni
            (Projects[58].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Bomet Uni
            (Projects[59].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Maasai Mara TVC
            (Projects[60].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Eldama Ravine
            (Projects[61].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Heroes TTI
            (Projects[62].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Total TVC
            (Projects[63].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // KMTC Kapenguria
            (Projects[64].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Sigor VTC
            (Projects[65].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kilgoris TVC
            (Projects[66].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // MTRH
            (Projects[67].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Chepareria VTC

            // Technical Lead for Fish Markets
            (Projects[68].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Lowarengak
            (Projects[69].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kalokol

            // Technical Lead for Ultra-Modern Market
            (Projects[70].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Eldoret 64

            // Technical Lead for additional markets
            (Projects[71].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kapsabet
            (Projects[72].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Nandi Hills Modern
            (Projects[73].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Ewaso Ngiro
            (Projects[74].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kinungi
            (Projects[75].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Mulot
            (Projects[76].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // ASTU Gilgil
            // ==================== TECHNICAL LEAD ASSIGNMENTS FOR NEW PROJECTS ====================

            // New projects - assign to Sheila Chepng'eno (TL2) for South Rift and other regions
            (Projects[77].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Bahati Modern Market
            (Projects[78].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kaptumo Modern Market
            (Projects[79].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Subukia ESP Market
            (Projects[80].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Nessuit ESP Market
            (Projects[81].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Kericho ESP Market
            (Projects[82].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Naivasha SEZA AHP
            (Projects[83].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Seguton ESP Market
            (Projects[84].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Keringet ESP Market
            (Projects[85].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Moi's Modern Market
            (Projects[86].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Rongai ESP Market
            (Projects[87].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Ollessos ESP Market
            (Projects[88].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // West Pokot ESP Markets
            (Projects[89].Id, "TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead), // Limuko Primary School
        };
        }
    }

