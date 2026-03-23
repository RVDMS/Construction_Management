using RVDMS.Domain.Constants;
using RVDMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class ProjectAssignmentSeedData
    {
        public static readonly List<ProjectAssignment> ProjectAssignments = new()
        {
            // ==================== HOUSING DEPARTMENT - AHP PROJECTS ====================
            // North Rift AHP Projects
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000001"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000001"), // Maili Tatu AHP
                UserId = "COW00000-0000-0000-0000-000000000001", // Daniel Kibowen
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 6, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000002"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000002"), // Kidiwa AHP Phase 2
                UserId = "COW00000-0000-0000-0000-000000000003", // Carolyne Simiyu
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 6, 19),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000003"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000003"), // Pioneer AHP Kapseret
                UserId = "COW00000-0000-0000-0000-000000000007", // Sailas Rugah
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000004"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000004"), // Nandi Hills AHP
                UserId = "COW00000-0000-0000-0000-000000000008", // Abel Kipruto
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000005"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000005"), // Chesumei AHP
                UserId = "COW00000-0000-0000-0000-000000000032", // Irwin Jara
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 6, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000006"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000006"), // Eldoret Railway City AHP
                UserId = "COW00000-0000-0000-0000-000000000030", // Emmanuel Sikuku
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 4, 4),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000007"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000007"), // Chepkorio AHP
                UserId = "COW00000-0000-0000-0000-000000000063", // Victor Kiprop
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 17),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000008"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000008"), // Iten Affordable Housing Phase I
                UserId = "COW00000-0000-0000-0000-000000000015", // Wangah Ian
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 12, 2),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000009"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000009"), // Iten Affordable Housing Phase II
                UserId = "COW00000-0000-0000-0000-000000000010", // Ian Sang
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 13),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000010"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000010"), // Kimumu AHP
                UserId = "COW00000-0000-0000-0000-000000000089", // Denies Langat
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000011"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000011"), // Kapsuswa AHP
                UserId = "COW00000-0000-0000-0000-000000000019", // Edwin Ondeng
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2023, 10, 28),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000012"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000012"), // Suam Border Post AHP
                UserId = "COW00000-0000-0000-0000-000000000057", // Mathias Munyendo
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 20),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // South Rift AHP Projects
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000013"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000013"), // Majengo Talai AHP
                UserId = "COW00000-0000-0000-0000-000000000004", // Jobson Birundu
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 15),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000014"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000014"), // Sotik AHP
                UserId = "COW00000-0000-0000-0000-000000000016", // Ramadlay Kiptoo
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 10),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000015"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000015"), // Bahati AHP Phase 2
                UserId = "COW00000-0000-0000-0000-000000000034", // Brian Mosoti
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 3, 29),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000016"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000016"), // Kabarnet Town AHP
                UserId = "COW00000-0000-0000-0000-000000000040", // Robert Kimutai
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000017"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000017"), // Marigat AHP
                UserId = "COW00000-0000-0000-0000-000000000028", // Praise Lekesio
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 5, 12),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000018"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000018"), // Kilgoris AHP
                UserId = "COW00000-0000-0000-0000-000000000027", // Robert Ronoh
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 1, 20),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000019"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000019"), // Buffalo Mall Phase 1
                UserId = "COW00000-0000-0000-0000-000000000041", // Archimedes Mulumba
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 8, 14),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000020"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000020"), // Karagita AHP Phase 2
                UserId = "COW00000-0000-0000-0000-000000000083", // Benson Charagu
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 9),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000021"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000021"), // Mogotio AHP
                UserId = "COW00000-0000-0000-0000-000000000104", // Kennedy Kiprotich
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Northern AHP Projects
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000022"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000022"), // Maralal AHP
                UserId = "COW00000-0000-0000-0000-000000000012", // Vincent Odhiambo
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 15),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000023"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000023"), // Archers Post AHP
                UserId = "COW00000-0000-0000-0000-000000000099", // Cliff Wanjala
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 14),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== URBAN DEVELOPMENT - ESP MARKETS ====================
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000024"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000024"), // Kolongei ESP Market
                UserId = "COW00000-0000-0000-0000-000000000002", // Vincent Wekesa
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 1),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000025"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000025"), // Sibanga ESP Market
                UserId = "COW00000-0000-0000-0000-000000000005", // George Wekesa
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 24),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000026"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000026"), // Naikarra ESP Market
                UserId = "COW00000-0000-0000-0000-000000000006", // Nixon Kipchirchir
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 2, 6),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000027"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000027"), // Ololulunga ESP Market
                UserId = "COW00000-0000-0000-0000-000000000031", // Calvince Nyakinda
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000028"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000028"), // Ainabkoi ESP Market
                UserId = "COW00000-0000-0000-0000-000000000037", // Peter Kakuko
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 2, 19),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000029"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000029"), // Sotik Modern Market
                UserId = "COW00000-0000-0000-0000-000000000039", // Isaac Chege
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 2),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000030"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000030"), // Kapcherop ESP Market
                UserId = "COW00000-0000-0000-0000-000000000042", // Stanley Ronoh
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 12, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000031"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000031"), // Kilgoris Modern Market
                UserId = "COW00000-0000-0000-0000-000000000045", // Duncan Maruti
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 2, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000032"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000032"), // Bikeke ESP Market
                UserId = "COW00000-0000-0000-0000-000000000046", // Felix Osok
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 24),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000033"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000033"), // Kesses ESP Market
                UserId = "COW00000-0000-0000-0000-000000000050", // Brian Kipruto
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 25),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000034"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000034"), // Olkalou ESP Market
                UserId = "COW00000-0000-0000-0000-000000000051", // Albert Mulonzi
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000035"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000035"), // Matharu ESP Market
                UserId = "COW00000-0000-0000-0000-000000000052", // Philemon Koech
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 5, 10),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000036"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000036"), // Birunda ESP Market
                UserId = "COW00000-0000-0000-0000-000000000053", // Evans Kipserem
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 19),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000037"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000037"), // Kiptagich ESP Market
                UserId = "COW00000-0000-0000-0000-000000000055", // Francisca Kisyula
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000038"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000038"), // Maraba ESP Market
                UserId = "COW00000-0000-0000-0000-000000000056", // Charles Ekirapa
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000039"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000039"), // Makutano ESP Market
                UserId = "COW00000-0000-0000-0000-000000000059", // Nakus Kachurkwel
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 5, 13),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000040"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000040"), // Kiminini Modern Market
                UserId = "COW00000-0000-0000-0000-000000000060", // Milton Wamukota
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 20),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000041"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000041"), // Suam Modern Market
                UserId = "COW00000-0000-0000-0000-000000000080", // Sostine Wanyonyi
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 1),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000042"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000042"), // Kapseret ESP Market
                UserId = "COW00000-0000-0000-0000-000000000081", // Faith Chebet
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 5, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000043"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000043"), // Kabatini ESP Market
                UserId = "COW00000-0000-0000-0000-000000000086", // Eric Kamau
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 5, 14),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000044"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000044"), // Nyamamithi ESP Market
                UserId = "COW00000-0000-0000-0000-000000000087", // Emmanuel Kimwaki
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 19),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000045"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000045"), // Mauche ESP Market
                UserId = "COW00000-0000-0000-0000-000000000091", // Peter Kiplangat
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000046"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000046"), // Baragoi Modern Market
                UserId = "COW00000-0000-0000-0000-000000000094", // Michael Lepartobiko
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 9),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000047"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000047"), // Mosoriot ESP Market
                UserId = "COW00000-0000-0000-0000-000000000098", // Robert Kimutai
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 3, 27),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000048"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000048"), // Chebunyo ESP Market
                UserId = "COW00000-0000-0000-0000-000000000102", // Ezra Rono
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 30),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000049"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000049"), // Kibigori ESP Market
                UserId = "COW00000-0000-0000-0000-000000000103", // Ezra Ayabei
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 24),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000050"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000050"), // Lower Moiben ESP Market
                UserId = "COW00000-0000-0000-0000-000000000105", // Pascal Kimutai
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 9),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000051"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000051"), // Sigor ESP Market
                UserId = "COW00000-0000-0000-0000-000000000107", // Clyite Kibet
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000052"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000052"), // Kakuma ESP Market
                UserId = "COW00000-0000-0000-0000-000000000110", // Locha Lokwanamor
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 1),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000053"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000053"), // Kiptangwanyi ESP Market
                UserId = "COW00000-0000-0000-0000-000000000111", // Chepyegon Mercy
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 11, 27),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000054"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000054"), // Uhuru Modern Market
                UserId = "COW00000-0000-0000-0000-000000000113", // Sheila Chelang'at
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 29),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000055"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000055"), // Iten ESP Market
                UserId = "COW00000-0000-0000-0000-000000000116", // Ronald Kirui
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 25),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000056"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000056"), // Iten Modern Market
                UserId = "COW00000-0000-0000-0000-000000000119", // James Makheti
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 5, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== INSTITUTIONAL HOUSING ====================
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000057"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000057"), // Maasai Mara University Hostels
                UserId = "COW00000-0000-0000-0000-000000000117", // Emmanuel Kiprotich
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 9),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000058"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000058"), // Turkana University Student Hostel
                UserId = "COW00000-0000-0000-0000-000000000093", // Celestine Jerono
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 6),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000059"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000059"), // Bomet University Hostels
                UserId = "COW00000-0000-0000-0000-000000000106", // Geophry Okeyo
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 3),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000060"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000060"), // Maasai Mara TVC Hostels
                UserId = "COW00000-0000-0000-0000-000000000009", // Olivia Wanyama
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 29),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000061"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000061"), // Eldama Ravine TVC
                UserId = "COW00000-0000-0000-0000-000000000062", // Collins Maina
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 30),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000062"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000062"), // Heroes TTI
                UserId = "COW00000-0000-0000-0000-000000000077", // Dickson Losute
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000063"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000063"), // Total TVC Kuresoi
                UserId = "COW00000-0000-0000-0000-000000000067", // Felistus Chepkemoi
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 2, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000064"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000064"), // KMTC Kapenguria
                UserId = "COW00000-0000-0000-0000-000000000084", // Collins Mudoga
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000065"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000065"), // Sigor VTC
                UserId = "COW00000-0000-0000-0000-000000000085", // Timothy Bwayo
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 1),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000066"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000066"), // Kilgoris TVC
                UserId = "COW00000-0000-0000-0000-000000000118", // Mercy Chelangat
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 1),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000067"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000067"), // MTRH Students Village
                UserId = "COW00000-0000-0000-0000-000000000074", // Gaylord Nyasende
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 22),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000068"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000068"), // Chepareria VTC
                UserId = "COW00000-0000-0000-0000-000000000114", // Sidney Serem
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 2, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== FISH MARKETS ====================
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000069"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000069"), // Lowarengak Fish Market
                UserId = "COW00000-0000-0000-0000-000000000033", // Felix Onyonge
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000070"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000070"), // Kalokol Fish Market
                UserId = "COW00000-0000-0000-0000-000000000072", // John Lopeyok
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 1, 29),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== ULTRA-MODERN MARKET ====================
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000071"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000071"), // Eldoret 64-UltraModern Market
                UserId = "COW00000-0000-0000-0000-000000000038", // Dennis Ng'ang'a
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 3, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== ADDITIONAL MODERN MARKETS ====================
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000072"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000072"), // Kapsabet Modern Market
                UserId = "COW00000-0000-0000-0000-000000000054", // Peter Otieno
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 8, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000073"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000073"), // Nandi Hills Modern Market
                UserId = "COW00000-0000-0000-0000-000000000066", // Benjamin Wafula
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 5, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000074"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000074"), // Ewaso Ngiro ESP Market
                UserId = "COW00000-0000-0000-0000-000000000068", // Lilian Otieno
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 17),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000075"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000075"), // Kinungi ESP Market
                UserId = "COW00000-0000-0000-0000-000000000071", // Dennis Mvoi
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2026, 2, 3),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000076"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000076"), // Mulot ESP Market
                UserId = "COW00000-0000-0000-0000-000000000078", // Cleophas Kibon
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 30),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000077"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000077"), // ASTU Gilgil
                UserId = "COW00000-0000-0000-0000-000000000112", // Jane Wangeci
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 28),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== TECHNICAL LEAD ASSIGNMENTS ====================
            // Jeremiah Miyora (TL) - North Rift Projects
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000078"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000001"), // Maili Tatu AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 6, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000079"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000002"), // Kidiwa AHP Phase 2
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 6, 19),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000080"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000003"), // Pioneer AHP Kapseret
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2024, 7, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000081"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000004"), // Nandi Hills AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 11, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000082"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000005"), // Chesumei AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 6, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000083"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000006"), // Eldoret Railway City AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 4, 4),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000084"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000007"), // Chepkorio AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 10, 17),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000085"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000008"), // Iten Affordable Housing Phase I
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2024, 12, 2),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000086"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000009"), // Iten Affordable Housing Phase II
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2025, 10, 13),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000087"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000010"), // Kimumu AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2024, 7, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000088"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000011"), // Kapsuswa AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2023, 10, 28),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000089"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000012"), // Suam Border Post AHP
                UserId = "TL000000-0000-0000-0000-000000000001",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2026, 1, 20),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Sheila Chepng'eno (TL) - All other projects
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000090"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000013"), // Majengo Talai AHP
                UserId = "TL000000-0000-0000-0000-000000000002",
                Role = UserRoles.TechnicalLead,
                AssignedAt = new DateTime(2024, 7, 15),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },
                        // Add these to ProjectAssignmentSeedData.ProjectAssignments list

            // ==================== ADDITIONAL COW ASSIGNMENTS ====================

            // Bahati Modern Market - Gideon Ngacha
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000091"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000078"),
                UserId = "COW00000-0000-0000-0000-000000000011",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 2),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Kaptumo Modern Market - Kelvin Namu Mugendi
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000092"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000079"),
                UserId = "COW00000-0000-0000-0000-000000000017",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 8, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Subukia ESP Market - Daniel Githiomi
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000093"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000080"),
                UserId = "COW00000-0000-0000-0000-000000000018",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Nessuit ESP Market - Kelvin Kaptum
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000094"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000081"),
                UserId = "COW00000-0000-0000-0000-000000000020",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Kericho ESP Market - Charity Chelagat
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000095"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000082"),
                UserId = "COW00000-0000-0000-0000-000000000021",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Naivasha SEZA AHP - Phineas Lingera
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000096"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000083"),
                UserId = "COW00000-0000-0000-0000-000000000022",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 25),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Seguton ESP Market - Jeff Ongala
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000097"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000084"),
                UserId = "COW00000-0000-0000-0000-000000000023",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 8, 26),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Keringet ESP Market - Betty Chebii
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000098"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000085"),
                UserId = "COW00000-0000-0000-0000-000000000024",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 5, 22),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Moi's Modern Market - Emmanuel Wanyonyi
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000099"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000086"),
                UserId = "COW00000-0000-0000-0000-000000000025",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 17),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Rongai ESP Market - Stanslaus Njue
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000100"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000087"),
                UserId = "COW00000-0000-0000-0000-000000000026",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 6, 12),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Ollessos ESP Market - Sammy Kipruto
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000101"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000088"),
                UserId = "COW00000-0000-0000-0000-000000000065",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 7, 4),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // West Pokot ESP Markets - Alex Maina
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000102"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000089"),
                UserId = "COW00000-0000-0000-0000-000000000058",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 4, 18),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Limuko Primary School - Salome Muthini
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000103"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000090"),
                UserId = "COW00000-0000-0000-0000-000000000109",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 3, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // ==================== ADDITIONAL ASSIGNMENTS FOR DUPLICATE COWS ====================

            // Chesumei AHP - Moses Omondi (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000104"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000005"), // Chesumei AHP
                UserId = "COW00000-0000-0000-0000-000000000014",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 6, 23),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Nandi Hills AHP - Nickson Kirui (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000105"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000004"), // Nandi Hills AHP
                UserId = "COW00000-0000-0000-0000-000000000029",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Nandi Hills AHP - Rahab Njoroge (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000106"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000004"), // Nandi Hills AHP
                UserId = "COW00000-0000-0000-0000-000000000115",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Kabarnet Town AHP - Kevin Kiprono (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000107"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000016"), // Kabarnet Town AHP
                UserId = "COW00000-0000-0000-0000-000000000043",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Kabarnet Town AHP - Abel Atebe (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000108"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000016"), // Kabarnet Town AHP
                UserId = "COW00000-0000-0000-0000-000000000047",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 12, 5),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Pioneer AHP - Kiprotich Dennis (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000109"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000003"), // Pioneer AHP
                UserId = "COW00000-0000-0000-0000-000000000044",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2024, 7, 16),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Lowarengak Fish Market - Musa Erube (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000110"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000069"), // Lowarengak Fish Market
                UserId = "COW00000-0000-0000-0000-000000000036",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 11, 7),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

            // Sotik AHP - Robert Ouko (additional COW)
            new ProjectAssignment
            {
                Id = Guid.Parse("80000000-0000-0000-0000-000000000111"),
                ProjectId = Guid.Parse("70000000-0000-0000-0000-000000000014"), // Sotik AHP
                UserId = "COW00000-0000-0000-0000-000000000079",
                Role = UserRoles.ClerkOfWorks,
                AssignedAt = new DateTime(2025, 10, 10),
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "system-seed",
                IsDeleted = false
            },

        };

       
        // 1. One COW assignment
        // 2. One TL assignment (either TL1 for North Rift or TL2 for others)
    }
}
