using RVDMS.Domain.Entities;
using RVDMS.Domain.ValueObjects;
using RVDMS.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Infrastructure.Seeders
{
    public static class UserSeedData
    {
        public const string DefaultPassword = "Default@123";

        public static readonly List<ApplicationUser> Users = new()
        {
            // ==================== CLUSTER SUPERVISORS (CS) ====================
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000001",
                UserName = "asman.saleh@housing.go.ke",
                Email = "asmansalehsdhud@gmail.com",
                FirstName = "Asman",
                LastName = "Saleh",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0708247624",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000002",
                UserName = "fredrick.bowen@housing.go.ke",
                Email = "fredbowen07@gmail.com",
                FirstName = "Fredrick",
                LastName = "Bowen",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0711584288",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000003",
                UserName = "vincent.kabubi@housing.go.ke",
                Email = "vincentkabubi@gmail.com",
                FirstName = "Vincent",
                LastName = "Kabubi",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704546730",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000004",
                UserName = "gilbert.bett.cs@housing.go.ke",
                Email = "bettkgilbert@gmail.com",
                FirstName = "Gilbert",
                LastName = "Bett",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0707330515",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000005",
                UserName = "dominic.bor@housing.go.ke",
                Email = "dominicbor44@gmail.com",
                FirstName = "Dominic",
                LastName = "Bor",
                BaseLocation = new Location(1.233333, 35.116667, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "254721000000",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000006",
                UserName = "eric.ndeda@housing.go.ke",
                Email = "ericndeda30@gmail.com",
                FirstName = "Eric",
                LastName = "Ndeda",
                BaseLocation = new Location(-0.983333, 35.366667, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0728611119",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000007",
                UserName = "peter.langat@housing.go.ke",
                Email = "peterclangat@gmail.com",
                FirstName = "Peter",
                LastName = "Langat",
                BaseLocation = new Location(0.166667, 35.133333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724851577",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CS000000-0000-0000-0000-000000000008",
                UserName = "dickson.kimutai@housing.go.ke",
                Email = "dicksonkimutai00@gmail.com",
                FirstName = "Dickson",
                LastName = "Kimutai",
                BaseLocation = new Location(0.466667, 35.733333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704495441",
                PhoneNumberConfirmed = true
            },

            // ==================== COUNTY DIRECTORS (CDH) ====================
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000001",
                UserName = "ruto.mengwa@housing.go.ke",
                Email = "cdhemc@gmail.com",
                FirstName = "Ruto",
                LastName = "Meng'wa",
                BaseLocation = new Location(0.366667, 35.550000, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724060558",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000002",
                UserName = "caesar.munene@housing.go.ke",
                Email = "mrgcaesar@yahoo.com",
                FirstName = "Caesar Munene",
                LastName = "Murage",
                BaseLocation = new Location(1.083333, 36.700000, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0723834495",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000003",
                UserName = "nicholas.ogajo@housing.go.ke",
                Email = "jnogajo@gmail.com",
                FirstName = "Nicholas",
                LastName = "Ogajo",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0720865347",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000004",
                UserName = "lawrence.mutisya@housing.go.ke",
                Email = "lmkasivu@gmail.com",
                FirstName = "Lawrence",
                LastName = "Mutisya",
                BaseLocation = new Location(0.466667, 35.733333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0721631758",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000005",
                UserName = "euginia.changach@housing.go.ke",
                Email = "jepbundi@gmail.com",
                FirstName = "Euginia",
                LastName = "Chang'ach",
                BaseLocation = new Location(0.166667, 35.133333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0726175708",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000006",
                UserName = "brian.kangogo@housing.go.ke",
                Email = "bryankantai@gmail.com",
                FirstName = "Brian",
                LastName = "Kangogo",
                BaseLocation = new Location(3.116667, 35.600000, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0714703953",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "CDH00000-0000-0000-0000-000000000007",
                UserName = "chris.rotich@housing.go.ke",
                Email = "chris.rotich@housing.go.ke",
                FirstName = "Chris",
                LastName = "Rotich",
                BaseLocation = new Location(-1.083333, 35.866667, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            },

            // ==================== TECHNICAL LEAD (TL) ====================
            new ApplicationUser
            {
                Id = "TL000000-0000-0000-0000-000000000001",
                UserName = "jeremiah.miyora@housing.go.ke",
                Email = "miyora1jere@gmail.com",
                FirstName = "Jeremiah",
                LastName = "Miyora",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0726416520",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "TL000000-0000-0000-0000-000000000002",
                UserName = "sheila.chepngeno@housing.go.ke",
                Email = "sheilachepngeno3@gmail.com",
                FirstName = "Sheila",
                LastName = "Chepng'eno",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706979241",
                PhoneNumberConfirmed = true
            },

            // ==================== REGIONAL LEAD (RL) ====================
            new ApplicationUser
            {
                Id = "RL000000-0000-0000-0000-000000000001",
                UserName = "gilbert.bett.rl@housing.go.ke",
                Email = "gilbert.bett@housing.go.ke",
                FirstName = "Gilbert",
                LastName = "Bett",
                BaseLocation = new Location(0.516667, 35.283333, 50000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            },

            // ==================== SUPER ADMIN ====================
            new ApplicationUser
            {
                Id = "ADMIN000-0000-0000-0000-000000000001",
                UserName = "admin@housing.go.ke",
                Email = "admin@housing.go.ke",
                FirstName = "System",
                LastName = "Administrator",
                BaseLocation = new Location(0.0, 0.0, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            },

            // ==================== CLERK OF WORKS (COW) ====================
            // From your Excel data - all Clerk of Works entries
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000001",
                UserName = "daniel.kibowen@housing.go.ke",
                Email = "danyowen330@gmail.com",
                FirstName = "Daniel",
                LastName = "Kibowen",
                BaseLocation = new Location(0.983978, 34.984662, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0758930883",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000002",
                UserName = "vincent.wekesa@housing.go.ke",
                Email = "vincentwekesa003@gmail.com",
                FirstName = "Vincent",
                LastName = "Wekesa",
                BaseLocation = new Location(1.090094, 34.805747, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0718364737",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000003",
                UserName = "carolyne.simiyu@housing.go.ke",
                Email = "carolynenanjala234@gmail.com",
                FirstName = "Carolyne",
                LastName = "Simiyu",
                BaseLocation = new Location(0.526938, 35.262038, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0717622216",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000004",
                UserName = "jobson.birundu@housing.go.ke",
                Email = "jobirundu@gmail.com",
                FirstName = "Jobson",
                LastName = "Birundu",
                BaseLocation = new Location(-0.3598043, 35.28986, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0713798633",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000005",
                UserName = "george.wekesa@housing.go.ke",
                Email = "wekesageorge20@gmail.com",
                FirstName = "George",
                LastName = "Wekesa",
                BaseLocation = new Location(1.0664, 35.1328, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0745239168",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000006",
                UserName = "nixon.kipchirchir@housing.go.ke",
                Email = "nixonkorir97@gmail.com",
                FirstName = "Nixon",
                LastName = "Kipchirchir",
                BaseLocation = new Location(-1.615425, 35.661312, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0791406890",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000007",
                UserName = "sailas.rugah@housing.go.ke",
                Email = "ochiengrugah444@gmail.com",
                FirstName = "Sailas",
                LastName = "Rugah",
                BaseLocation = new Location(0.31536, 35.15473, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715771310",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000008",
                UserName = "abel.kipruto@housing.go.ke",
                Email = "kiprutoabel085@gmail.com",
                FirstName = "Abel",
                LastName = "Kipruto",
                BaseLocation = new Location(0.0601, 35.1035, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0711760497",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000009",
                UserName = "olivia.wanyama@housing.go.ke",
                Email = "oliviabright2001@gmail.com",
                FirstName = "Olivia Bright",
                LastName = "Wanyama",
                BaseLocation = new Location(-1.108336, 36.005554, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0759121480",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000010",
                UserName = "ian.sang@housing.go.ke",
                Email = "iankiplagatsang@gmail.com",
                FirstName = "Ian",
                LastName = "Sang",
                BaseLocation = new Location(0.6703, 35.5075, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0729118637",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000011",
                UserName = "gideon.ngacha@housing.go.ke",
                Email = "gidngacha@gmail.com",
                FirstName = "Gideon",
                LastName = "Ngacha",
                BaseLocation = new Location(-0.154841, 36.144773, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0791536424",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000012",
                UserName = "vincent.odhiambo@housing.go.ke",
                Email = "vincentodhiambo091@gmail.com",
                FirstName = "Vincent",
                LastName = "Odhiambo",
                BaseLocation = new Location(1.093091, 36.689542, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0718269520",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000013",
                UserName = "paul.chesebe@housing.go.ke",
                Email = "polrto10@gmail.com",
                FirstName = "Paul",
                LastName = "Chesebe",
                BaseLocation = new Location(0.110638, 35.18415, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706391585",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000014",
                UserName = "moses.omondi@housing.go.ke",
                Email = "mosesomondi887@gmail.com",
                FirstName = "Moses",
                LastName = "Omondi",
                BaseLocation = new Location(0.204281, 35.109664, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0735375929",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000015",
                UserName = "wangah.ian@housing.go.ke",
                Email = "ianduncan.iw@gmail.com",
                FirstName = "Wangah",
                LastName = "Ian",
                BaseLocation = new Location(0.40617, 35.3045, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0701325668",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000016",
                UserName = "ramadlay.kiptoo@housing.go.ke",
                Email = "toooriam@gmail.com",
                FirstName = "Ramadlay",
                LastName = "Kiptoo",
                BaseLocation = new Location(0.687378, 35.109831, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0769001300",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000017",
                UserName = "kelvin.namu@housing.go.ke",
                Email = "mugendi.kelvin.namu@gmail.com",
                FirstName = "Kelvin Namu",
                LastName = "Mugendi",
                BaseLocation = new Location(0.07651, 35.07226, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0793777296",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000018",
                UserName = "daniel.githiomi@housing.go.ke",
                Email = "mungaidaniel2000@gmail.com",
                FirstName = "Daniel",
                LastName = "Githiomi",
                BaseLocation = new Location(0.00364, 36.22974, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0727284100",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000019",
                UserName = "edwin.ondeng@housing.go.ke",
                Email = "edwin.rosewine@gmail.com",
                FirstName = "Edwin",
                LastName = "Ondeng",
                BaseLocation = new Location(0.31536, 35.15473, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0729599685",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000020",
                UserName = "kelvin.kaptum@housing.go.ke",
                Email = "kelvinkaptum@gmail.com",
                FirstName = "Kelvin",
                LastName = "Kaptum",
                BaseLocation = new Location(-0.390172, 35.896316, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0758025847",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000021",
                UserName = "charity.chelagat@housing.go.ke",
                Email = "chrtchela@gmail.com",
                FirstName = "Charity",
                LastName = "Chelagat",
                BaseLocation = new Location(-0.63142, 35.19748, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0713104988",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000022",
                UserName = "phineas.lingera@housing.go.ke",
                Email = "lingeraphineas@gmail.com",
                FirstName = "Phineas",
                LastName = "Lingera",
                BaseLocation = new Location(-1.015488, 36.469896, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0702241125",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000023",
                UserName = "jeff.ongala@housing.go.ke",
                Email = "otijeff7@gmail.com",
                FirstName = "Jeff",
                LastName = "Ongala",
                BaseLocation = new Location(-0.371877, 35.684658, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0795688373",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000024",
                UserName = "betty.chebii@housing.go.ke",
                Email = "chebiibetty2@gmail.com",
                FirstName = "Betty",
                LastName = "Chebii",
                BaseLocation = new Location(0.427105, 35.69197, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0722390492",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000025",
                UserName = "emmanuel.wanyonyi@housing.go.ke",
                Email = "siwaemmanuel2019@gmail.com",
                FirstName = "Emmanuel",
                LastName = "Wanyonyi",
                BaseLocation = new Location(0.87394, 35.11992, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706321131",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000026",
                UserName = "stanslaus.njue@housing.go.ke",
                Email = "stanslausnesh@gmail.com",
                FirstName = "Stanslaus",
                LastName = "Njue",
                BaseLocation = new Location(-0.173871, 35.862151, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0791244635",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000027",
                UserName = "robert.ronoh@housing.go.ke",
                Email = "ronexrobert@gmail.com",
                FirstName = "Robert",
                LastName = "Ronoh",
                BaseLocation = new Location(-1.00028, 34.87665, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0725226299",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000028",
                UserName = "praise.lekesio@housing.go.ke",
                Email = "praiserenteyo@gmail.com",
                FirstName = "Praise",
                LastName = "Lekesio",
                BaseLocation = new Location(0.47306, 35.979379, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0791043002",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000029",
                UserName = "nickson.kirui@housing.go.ke",
                Email = "nickyreigns359@gmail.com",
                FirstName = "Nickson",
                LastName = "Kirui",
                BaseLocation = new Location(0.110638, 35.18415, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0713318016",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000030",
                UserName = "emmanuel.sikuku@housing.go.ke",
                Email = "emmanuelsikuku2019@gmail.com",
                FirstName = "Emmanuel",
                LastName = "Sikuku",
                BaseLocation = new Location(0.52823, 35.26206, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0741903285",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000031",
                UserName = "calvince.nyakinda@housing.go.ke",
                Email = "ocalvinx@gmail.com",
                FirstName = "Calvince",
                LastName = "Nyakinda",
                BaseLocation = new Location(-1.003578, 35.66316, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704998700",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000032",
                UserName = "irwin.jara@housing.go.ke",
                Email = "jarairwin630@gmail.com",
                FirstName = "Irwin",
                LastName = "Jara",
                BaseLocation = new Location(0.204281, 35.109664, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0720968180",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000033",
                UserName = "felix.onyonge@housing.go.ke",
                Email = "felixonyonge@gmail.com",
                FirstName = "Felix",
                LastName = "Onyonge",
                BaseLocation = new Location(4.279788, 35.892157, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0712906715",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000034",
                UserName = "brian.mosoti@housing.go.ke",
                Email = "mosotib@yahoo.com",
                FirstName = "Brian",
                LastName = "Mosoti",
                BaseLocation = new Location(-0.1431027, 36.1500524, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0708552764",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000035",
                UserName = "grace.wanjala@housing.go.ke",
                Email = "wanjalag405@gmail.com",
                FirstName = "Grace",
                LastName = "Wanjala Nafula",
                BaseLocation = new Location(0.983978, 34.984662, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706872216",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000036",
                UserName = "musa.erube@housing.go.ke",
                Email = "musaerube@gmail.com",
                FirstName = "Musa",
                LastName = "Erube",
                BaseLocation = new Location(4.227979, 35.892157, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0723204299",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000037",
                UserName = "peter.kakuko@housing.go.ke",
                Email = "peterkakuko1@gmail.com",
                FirstName = "Peter",
                LastName = "Kakuko",
                BaseLocation = new Location(0.164444, 35.528611, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0743411671",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000038",
                UserName = "dennis.nganga@housing.go.ke",
                Email = "dennisnganga2207@gmail.com",
                FirstName = "Dennis",
                LastName = "Ng'ang'a",
                BaseLocation = new Location(0.515961, 35.272758, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0702735769",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000039",
                UserName = "isaac.chege@housing.go.ke",
                Email = "isaacchege88@gmail.com",
                FirstName = "Isaac",
                LastName = "Chege",
                BaseLocation = new Location(-0.695147, 35.10801, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0795634708",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000040",
                UserName = "robert.kimutai@housing.go.ke",
                Email = "robkips@gmail.com",
                FirstName = "Robert",
                LastName = "Kimutai",
                BaseLocation = new Location(0.494873, 35.73708, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0725620100",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000041",
                UserName = "archimedes.mulumba@housing.go.ke",
                Email = "archimedesmmulumba@gmail.com",
                FirstName = "Archimedes",
                LastName = "Mulumba",
                BaseLocation = new Location(-0.70286, 35.334631, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0740852107",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000042",
                UserName = "stanley.ronoh@housing.go.ke",
                Email = "stanleyronoh28@gmail.com",
                FirstName = "Stanley",
                LastName = "Ronoh",
                BaseLocation = new Location(1.038503, 35.322287, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0722843096",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000043",
                UserName = "kevin.kiprono@housing.go.ke",
                Email = "kevinkiprono42@gmail.com",
                FirstName = "Kevin",
                LastName = "Kiprono",
                BaseLocation = new Location(0.494994, 35.235109, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0713181743",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000044",
                UserName = "kiprotich.dennis@housing.go.ke",
                Email = "kiprodens@gmail.com",
                FirstName = "Kiprotich",
                LastName = "Dennis",
                BaseLocation = new Location(0.508611, 35.266944, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0786804968",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000045",
                UserName = "duncan.maruti@housing.go.ke",
                Email = "marutiduncan3@gmail.com",
                FirstName = "Duncan",
                LastName = "Maruti",
                BaseLocation = new Location(-1.008222, 34.880222, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0758387650",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000046",
                UserName = "felix.osok@housing.go.ke",
                Email = "osokfelix17@gmail.com",
                FirstName = "Felix",
                LastName = "Osok",
                BaseLocation = new Location(0.999891, 35.058038, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0110073031",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000047",
                UserName = "abel.atebe@housing.go.ke",
                Email = "abelatebe@gmail.com",
                FirstName = "Abel",
                LastName = "Atebe",
                BaseLocation = new Location(0.494994, 35.235109, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0793988177",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000048",
                UserName = "cliftone.gimomodi@housing.go.ke",
                Email = "gimomodicliftone3@gmail.com",
                FirstName = "Cliftone",
                LastName = "Gimomodi",
                BaseLocation = new Location(0.9999, 35.0576, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0769660901",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000049",
                UserName = "sharon.jeptanui@housing.go.ke",
                Email = "sharonngebey@gmail.com",
                FirstName = "Sharon",
                LastName = "Jeptanui",
                BaseLocation = new Location(0.527778, 35.261944, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0746611463",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000050",
                UserName = "brian.kipruto@housing.go.ke",
                Email = "kiprutobrian82@gmail.com",
                FirstName = "Brian",
                LastName = "Kipruto",
                BaseLocation = new Location(0.296095, 35.325614, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0791806115",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000051",
                UserName = "albert.mulonzi@housing.go.ke",
                Email = "albertmutavi2018@gmail.com",
                FirstName = "Albert",
                LastName = "Mulonzi",
                BaseLocation = new Location(-0.176656, 36.245203, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0792354876",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000052",
                UserName = "philemon.koech@housing.go.ke",
                Email = "koechlobei5612@gmail.com",
                FirstName = "Philemon",
                LastName = "Koech",
                BaseLocation = new Location(0.096131, 35.5037, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724515924",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000053",
                UserName = "evans.kipserem@housing.go.ke",
                Email = "evanskipserem@gmail.com",
                FirstName = "Evans",
                LastName = "Kipserem",
                BaseLocation = new Location(0.961554, 34.932297, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715791000",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000054",
                UserName = "peter.otieno@housing.go.ke",
                Email = "peterotieno8889@gmail.com",
                FirstName = "Peter",
                LastName = "Otieno",
                BaseLocation = new Location(0.2039, 35.1063, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704692231",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000055",
                UserName = "francisca.kisyula@housing.go.ke",
                Email = "franywapy@gmail.com",
                FirstName = "Francisca",
                LastName = "Kisyula",
                BaseLocation = new Location(-0.57342, 35.61401, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0702967480",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000056",
                UserName = "charles.ekiarapa@housing.go.ke",
                Email = "charlesekirapa4@gmail.com",
                FirstName = "Charles",
                LastName = "Ekirapa",
                BaseLocation = new Location(0.005982, 35.310048, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0758154719",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000057",
                UserName = "mathias.munyendo@housing.go.ke",
                Email = "mathiasmunny@gmail.com",
                FirstName = "Mathias",
                LastName = "Munyendo",
                BaseLocation = new Location(1.213834, 34.741303, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0727019413",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000058",
                UserName = "alex.main@housing.go.ke",
                Email = "mainaalex892@gmail.com",
                FirstName = "Alex",
                LastName = "Maina",
                BaseLocation = new Location(1.43746, 35.35484, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724004791",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000059",
                UserName = "nakus.kachurkwel@housing.go.ke",
                Email = "nakusewosit@gmail.com",
                FirstName = "Nakus",
                LastName = "Kachurkwel",
                BaseLocation = new Location(1.255286, 35.09195, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0748414198",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000060",
                UserName = "milton.wamukota@housing.go.ke",
                Email = "miltonwafula40@gmail.com",
                FirstName = "Milton",
                LastName = "Wamukota",
                BaseLocation = new Location(0.893047, 34.924821, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0728237522",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000061",
                UserName = "duncan.okelo@housing.go.ke",
                Email = "okelloduncan8@gmail.com",
                FirstName = "Duncan",
                LastName = "Okelo",
                BaseLocation = new Location(0.893515, 34.925853, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0705396006",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000062",
                UserName = "collins.maina@housing.go.ke",
                Email = "lukoyemaina01@gmail.com",
                FirstName = "Collins",
                LastName = "Maina",
                BaseLocation = new Location(0.03925, 35.72821, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0794599554",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000063",
                UserName = "victor.kiprop@housing.go.ke",
                Email = "victorchumba309@gmail.com",
                FirstName = "Victor",
                LastName = "Kiprop",
                BaseLocation = new Location(0.367722, 35.557111, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0723404293",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000064",
                UserName = "timothy.matiy@housing.go.ke",
                Email = "matiytimothy@gmail.com",
                FirstName = "Timothy",
                LastName = "Matiy",
                BaseLocation = new Location(0.367722, 35.557111, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0727661014",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000065",
                UserName = "sammy.kipruto@housing.go.ke",
                Email = "kiprutosammy92@gmail.com",
                FirstName = "Sammy",
                LastName = "Kipruto",
                BaseLocation = new Location(0.166667, 35.15, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0721547063",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000066",
                UserName = "benjamin.wafula@housing.go.ke",
                Email = "bnamunane@gmail.com",
                FirstName = "Benjamin Levi",
                LastName = "Wafula",
                BaseLocation = new Location(0.106257, 35.183235, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0718737491",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000067",
                UserName = "felistus.chepkemoi@housing.go.ke",
                Email = "chepkemoifelistus002@gmail.com",
                FirstName = "Felistus",
                LastName = "Chepkemoi",
                BaseLocation = new Location(-0.16, 35.69, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715831528",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000068",
                UserName = "lilian.otieno@housing.go.ke",
                Email = "archietessy254@gmail.com",
                FirstName = "Lilian",
                LastName = "Otieno",
                BaseLocation = new Location(-1.153364, 35.761588, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0797060681",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000069",
                UserName = "felix.cheruiyot@housing.go.ke",
                Email = "cheruh.felix17@gmail.com",
                FirstName = "Felix",
                LastName = "Cheruiyot",
                BaseLocation = new Location(-0.70342, 36.72867, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0746338422",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000070",
                UserName = "evans.kipchumba@housing.go.ke",
                Email = "evanskk01@gmail.com",
                FirstName = "Evans Kipchumba",
                LastName = "Kipchumba",
                BaseLocation = new Location(-0.511809, 35.975922, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0725073317",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000071",
                UserName = "dennis.mvoi@housing.go.ke",
                Email = "maghangazdenismvoi@gmail.com",
                FirstName = "Dennis",
                LastName = "Mvoi",
                BaseLocation = new Location(-0.784635, 36.432858, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0708239091",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000072",
                UserName = "john.lopeyok@housing.go.ke",
                Email = "lopeyokjohn30@gmail.com",
                FirstName = "John",
                LastName = "Lopeyok",
                BaseLocation = new Location(3.716667, 35.833333, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0745833752",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000073",
                UserName = "victor.chelal@housing.go.ke",
                Email = "bartuinv@gmail.com",
                FirstName = "Victor",
                LastName = "Chelal",
                BaseLocation = new Location(0.82, 35.38, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715723705",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000074",
                UserName = "gaylord.nyasende@housing.go.ke",
                Email = "gaylordnyasende@gmail.com",
                FirstName = "Gaylord Innocent",
                LastName = "Nyasende",
                BaseLocation = new Location(0.548161, 35.286149, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704673226",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000075",
                UserName = "sheila.moraa@housing.go.ke",
                Email = "sheilagichaba@gmail.com",
                FirstName = "Sheila",
                LastName = "Moraa",
                BaseLocation = new Location(0.52823, 35.26206, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0790923606",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000076",
                UserName = "isaac.barasa@housing.go.ke",
                Email = "barasai282@gmail.com",
                FirstName = "Isaac",
                LastName = "Barasa",
                BaseLocation = new Location(1.213834, 34.741303, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0795815384",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000077",
                UserName = "dickson.losute@housing.go.ke",
                Email = "losutedickson619@gmail.com",
                FirstName = "Dickson",
                LastName = "Losute",
                BaseLocation = new Location(-0.246973, 36.149182, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0723831149",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000078",
                UserName = "cleophas.kibon@housing.go.ke",
                Email = "cleophaskibon71@gmail.com",
                FirstName = "Cleophas",
                LastName = "Kibon",
                BaseLocation = new Location(-0.9374, 35.4213, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0710189111",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000079",
                UserName = "robert.ouko@housing.go.ke",
                Email = "robertouko3290@gmail.com",
                FirstName = "Robert",
                LastName = "Ouko",
                BaseLocation = new Location(0.687716, 35.109314, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0728237919",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000080",
                UserName = "sostine.wanyonyi@housing.go.ke",
                Email = "sostineaseka@gmail.com",
                FirstName = "Sostine",
                LastName = "Wanyonyi",
                BaseLocation = new Location(1.218322, 34.735619, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0712833029",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000081",
                UserName = "faith.chebet@housing.go.ke",
                Email = "faithterer001@gmail.com",
                FirstName = "Faith",
                LastName = "Chebet",
                BaseLocation = new Location(0.448643, 35.235109, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0796834334",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000082",
                UserName = "kevin.kiprono2@housing.go.ke",
                Email = "kevkipurono@gmail.com",
                FirstName = "Kevin",
                LastName = "Kiprono",
                BaseLocation = new Location(0.448643, 35.235109, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0100802894",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000083",
                UserName = "benson.charagu@housing.go.ke",
                Email = "bensoncharaguk@gmail.com",
                FirstName = "Benson",
                LastName = "Charagu",
                BaseLocation = new Location(-0.784635, 36.432858, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0748859836",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000084",
                UserName = "collins.mudoga@housing.go.ke",
                Email = "mudogacollins2@gmail.com",
                FirstName = "Collins",
                LastName = "Mudoga",
                BaseLocation = new Location(1.24, 35.12, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0796284093",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000085",
                UserName = "timothy.bwayo@housing.go.ke",
                Email = "timobwayo@gmail.com",
                FirstName = "Timothy",
                LastName = "Bwayo",
                BaseLocation = new Location(1.49597, 35.47271, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706052039",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000086",
                UserName = "eric.kamau@housing.go.ke",
                Email = "1kihongekamau@gmail.com",
                FirstName = "Eric",
                LastName = "Kamau",
                BaseLocation = new Location(-0.229278, 36.134333, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0741721948",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000087",
                UserName = "emmanuel.kimwaki@housing.go.ke",
                Email = "e.w.kimwaki@gmail.com",
                FirstName = "Emmanuel",
                LastName = "Kimwaki",
                BaseLocation = new Location(0.00938, 36.2125, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0741027511",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000088",
                UserName = "duncel.etyang@housing.go.ke",
                Email = "etyangbrandan@gmail.com",
                FirstName = "Duncel",
                LastName = "Etyang",
                BaseLocation = new Location(1.21364, 34.743165, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0706443152",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000089",
                UserName = "denies.langat@housing.go.ke",
                Email = "denieslangat14@gmail.com",
                FirstName = "Denies",
                LastName = "Langat",
                BaseLocation = new Location(0.572345, 35.310227, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0702919196",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000090",
                UserName = "philemon.koech2@housing.go.ke",
                Email = "philemon1664@gmail.com",
                FirstName = "Philemon",
                LastName = "Koech",
                BaseLocation = new Location(0.670386, 35.5093, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724515924",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000091",
                UserName = "peter.kiplangat@housing.go.ke",
                Email = "peterbett2018@gmail.com",
                FirstName = "Peter",
                LastName = "Kiplangat",
                BaseLocation = new Location(-0.511928, 35.975946, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0745442668",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000092",
                UserName = "eregae.eporon@housing.go.ke",
                Email = "eporongeoffrey@gmail.com",
                FirstName = "Eregae Eporon",
                LastName = "Geoffrey",
                BaseLocation = new Location(3.069444, 35.614167, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0711440614",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000093",
                UserName = "celestine.jerono@housing.go.ke",
                Email = "celejerono@gmail.com",
                FirstName = "Celestine",
                LastName = "Jerono",
                BaseLocation = new Location(3.069444, 35.614167, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0792601276",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000094",
                UserName = "michael.lepartobiko@housing.go.ke",
                Email = "lepar@scriptingnomads.pro",
                FirstName = "Michael",
                LastName = "Lepartobiko",
                BaseLocation = new Location(1.785569, 36.789939, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0721294145",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000095",
                UserName = "jonah.barboi@housing.go.ke",
                Email = "jonahbarboi@gmail.com",
                FirstName = "Jonah",
                LastName = "Barboi",
                BaseLocation = new Location(0.670386, 35.5093, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0718082802",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000096",
                UserName = "ben.kangogo@housing.go.ke",
                Email = "benahkogei8@gmail.com",
                FirstName = "Ben",
                LastName = "Kangogo",
                BaseLocation = new Location(0.367722, 35.557111, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715240094",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000097",
                UserName = "odhiambo.ogeya@housing.go.ke",
                Email = "kevyn.ogeya@gmail.com",
                FirstName = "Odhiambo",
                LastName = "Ogeya",
                BaseLocation = new Location(1.78333, 36.78333, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0769633332",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000098",
                UserName = "robert.kimutai2@housing.go.ke",
                Email = "robkipbarmasai@gmail.com",
                FirstName = "Robert",
                LastName = "Kimutai",
                BaseLocation = new Location(0.322059, 35.17014, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0725620100",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000099",
                UserName = "cliff.wanjala@housing.go.ke",
                Email = "cliffwanjala2016@gmail.com",
                FirstName = "Cliff",
                LastName = "Wanjala",
                BaseLocation = new Location(0.663735, 37.667609, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715370236",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000100",
                UserName = "david.lemeteki@housing.go.ke",
                Email = "davidlemeteki8@gmail.com",
                FirstName = "David",
                LastName = "Lemeteki",
                BaseLocation = new Location(0.663735, 37.667609, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0718840880",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000101",
                UserName = "pharis.wafula@housing.go.ke",
                Email = "phariswafula4@gmail.com",
                FirstName = "Pharis Wafula",
                LastName = "Wafula",
                BaseLocation = new Location(0.663735, 37.667609, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0799766326",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000102",
                UserName = "ezra.rono@housing.go.ke",
                Email = "ezrarono32@gmail.com",
                FirstName = "Ezra",
                LastName = "Rono",
                BaseLocation = new Location(-0.966188, 35.190675, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0705265224",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000103",
                UserName = "ezra.ayabei@housing.go.ke",
                Email = "ayabeiezra@gmail.com",
                FirstName = "Ezra",
                LastName = "Ayabei",
                BaseLocation = new Location(0.0667, 35.05, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0724259412",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000104",
                UserName = "kennedy.kiprotich@housing.go.ke",
                Email = "kendykipz.kk@gmail.com",
                FirstName = "Kennedy",
                LastName = "Kiprotich",
                BaseLocation = new Location(-0.010056, 35.964128, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0723377364",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000105",
                UserName = "pascal.kimutai@housing.go.ke",
                Email = "pascalkimutai@gmail.com",
                FirstName = "Pascal",
                LastName = "Kimutai",
                BaseLocation = new Location(0.82, 35.38, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0727022736",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000106",
                UserName = "geophry.okeyo@housing.go.ke",
                Email = "okeyogeophry@gmail.com",
                FirstName = "Geophry",
                LastName = "Okeyo",
                BaseLocation = new Location(-0.792072, 35.332051, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0703615182",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000107",
                UserName = "clyite.kibet@housing.go.ke",
                Email = "clyitekibet71@gmail.com",
                FirstName = "Clyite",
                LastName = "Kibet",
                BaseLocation = new Location(1.486858, 35.472625, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0741989930",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000108",
                UserName = "brian.alkwiri@housing.go.ke",
                Email = "brianalkwiri@gmail.com",
                FirstName = "Brian",
                LastName = "Alkwiri",
                BaseLocation = new Location(0.071389, 35.050278, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0769971583",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000109",
                UserName = "salome.muthini@housing.go.ke",
                Email = "salomemutio03@gmail.com",
                FirstName = "Salome",
                LastName = "Muthini",
                BaseLocation = new Location(0.211886, 36.161838, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0112440354",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000110",
                UserName = "locha.lokwanamor@housing.go.ke",
                Email = "lochaphilip6@gmail.com",
                FirstName = "Locha",
                LastName = "Lokwanamor",
                BaseLocation = new Location(3.707505, 34.882983, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0759575493",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000111",
                UserName = "chepyegon.mercy@housing.go.ke",
                Email = "chepyegonmercy@gmail.com",
                FirstName = "Chepyegon",
                LastName = "Mercy",
                BaseLocation = new Location(-0.565011, 36.11705, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0701808378",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000112",
                UserName = "jane.wangeci@housing.go.ke",
                Email = "kamauwangeci1@gmail.com",
                FirstName = "Jane",
                LastName = "Wangeci",
                BaseLocation = new Location(-0.470784, 36.334415, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0759005335",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000113",
                UserName = "sheila.chelangat@housing.go.ke",
                Email = "sheilachelangat006@gmail.com",
                FirstName = "Sheila",
                LastName = "Chelang'at",
                BaseLocation = new Location(-1.08519, 35.87806, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0714734439",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000114",
                UserName = "sidney.serem@housing.go.ke",
                Email = "sidneyserem@gmail.com",
                FirstName = "Sidney",
                LastName = "Serem",
                BaseLocation = new Location(1.389017, 35.190992, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0726394397",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000115",
                UserName = "rahab.njoroge@housing.go.ke",
                Email = "rahabnjoroge89@gmail.com",
                FirstName = "Rahab",
                LastName = "Njoroge",
                BaseLocation = new Location(0.0601, 35.1035, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0715644005",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000116",
                UserName = "ronald.kirui@housing.go.ke",
                Email = "ronaldkiprotich9@gmail.com",
                FirstName = "Ronald",
                LastName = "Kirui",
                BaseLocation = new Location(0.669906, 35.506299, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0708040219",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000117",
                UserName = "emmanuel.kiprotich@housing.go.ke",
                Email = "emmanuelkiprotich.ek@gmail.com",
                FirstName = "Emmanuel",
                LastName = "Kiprotich",
                BaseLocation = new Location(-1.090546, 35.85415, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0792677689",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000118",
                UserName = "mercy.chelangat@housing.go.ke",
                Email = "mercychelangat3611@gmail.com",
                FirstName = "Mercy",
                LastName = "Chelangat",
                BaseLocation = new Location(-0.99771, 34.781502, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0704174803",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000119",
                UserName = "james.makheti@housing.go.ke",
                Email = "biketijames7@gmail.com",
                FirstName = "James",
                LastName = "Makheti",
                BaseLocation = new Location(0.670125, 35.5098, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0719229975",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000120",
                UserName = "paulinembugua@housing.go.ke",
                Email = "paumbugua98@gmail.com",
                FirstName = "Pauline",
                LastName = "Mbugua",
                BaseLocation = new Location(0.6703, 35.5075, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0741164616",
                PhoneNumberConfirmed = true
            },
            new ApplicationUser
            {
                Id = "COW00000-0000-0000-0000-000000000121",
                UserName = "getrude.chepkoech@housing.go.ke",
                Email = "getrudejepkoech99@gmail.com",
                FirstName = "Getrude",
                LastName = "Chepkoech",
                BaseLocation = new Location(0.671196, 35.51099, 1000),
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                EmailConfirmed = true,
                PhoneNumber = "0746138782",
                PhoneNumberConfirmed = true
            }
        };

        // Role assignments for users
        public static readonly List<(string UserId, string Role)> UserRolesMappings = new()
        {
            // Super Admin (1)
            ("ADMIN000-0000-0000-0000-000000000001", UserRoles.SuperAdmin),
            
            // Regional Lead (1)
            ("RL000000-0000-0000-0000-000000000001", UserRoles.RegionalLead),
            
            // Technical Leads (2)
            ("TL000000-0000-0000-0000-000000000001", UserRoles.TechnicalLead),
            ("TL000000-0000-0000-0000-000000000002", UserRoles.TechnicalLead),
            
            // Cluster Supervisors (8)
            ("CS000000-0000-0000-0000-000000000001", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000002", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000003", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000004", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000005", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000006", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000007", UserRoles.ClusterSupervisor),
            ("CS000000-0000-0000-0000-000000000008", UserRoles.ClusterSupervisor),
            
            // County Directors (7)
            ("CDH00000-0000-0000-0000-000000000001", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000002", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000003", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000004", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000005", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000006", UserRoles.CountyDirector),
            ("CDH00000-0000-0000-0000-000000000007", UserRoles.CountyDirector),
            
            // Clerk of Works (121 users from COW00001 to COW00121)
            ("COW00000-0000-0000-0000-000000000001", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000002", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000003", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000004", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000005", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000006", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000007", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000008", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000009", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000010", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000011", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000012", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000013", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000014", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000015", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000016", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000017", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000018", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000019", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000020", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000021", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000022", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000023", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000024", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000025", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000026", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000027", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000028", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000029", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000030", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000031", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000032", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000033", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000034", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000035", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000036", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000037", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000038", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000039", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000040", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000041", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000042", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000043", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000044", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000045", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000046", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000047", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000048", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000049", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000050", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000051", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000052", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000053", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000054", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000055", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000056", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000057", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000058", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000059", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000060", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000061", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000062", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000063", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000064", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000065", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000066", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000067", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000068", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000069", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000070", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000071", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000072", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000073", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000074", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000075", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000076", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000077", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000078", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000079", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000080", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000081", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000082", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000083", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000084", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000085", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000086", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000087", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000088", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000089", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000090", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000091", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000092", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000093", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000094", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000095", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000096", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000097", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000098", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000099", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000100", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000101", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000102", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000103", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000104", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000105", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000106", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000107", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000108", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000109", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000110", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000111", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000112", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000113", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000114", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000115", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000116", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000117", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000118", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000119", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000120", UserRoles.ClerkOfWorks),
            ("COW00000-0000-0000-0000-000000000121", UserRoles.ClerkOfWorks)
        };
    }
}
