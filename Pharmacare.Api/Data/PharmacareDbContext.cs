using Microsoft.EntityFrameworkCore;
using Pharmacare.Api.Entities;
using Pharmacare.Entities;

namespace Pharmacare.Data
{
    public class PharmacareDbContext : DbContext
    {
        public PharmacareDbContext(DbContextOptions<PharmacareDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 1,
                Name = "Kwas klawulanowy",
                InternationalName = "Amoxicillin clavulanate",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 2,
                Name = "Dipropionian beklometazonu",
                InternationalName = "Beclometasone",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 3,
                Name = "Klarytromycyna",
                InternationalName = "Clarithromycin",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 4,
                Name = "Amoksycylina",
                InternationalName = "Amoxicillin",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 5,
                Name = "Salbutamol",
                InternationalName = "Salbutamol",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 6,
                Name = "Cefiksym",
                InternationalName = "Cefixime",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 7,
                Name = "Azytromycyna",
                InternationalName = "Azithromycin",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 8,
                Name = "Betametazon",
                InternationalName = "Betametasone",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 9,
                Name = "Cefaklor",
                InternationalName = "Cefaclor",
                Description = "Opis",
            });
            modelBuilder.Entity<ActiveSubstance>().HasData(new ActiveSubstance
            {
                SubstanceId = 10,
                Name = "Cetyryzyna",
                InternationalName = "Cetirizine",
                Description = "Opis",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Ból",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Dla diabetyków",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Dermatologia",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Homeopatia",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 5,
                Name = "Układ krążenia",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 6,
                Name = "Odporność",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 7,
                Name = "Przeziębienie i grypa",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 8,
                Name = "Zdrowie mężczyny",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 9,
                Name = "Seks i antykoncepcja",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10,
                Name = "Alergia",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 11,
                Name = "Układ pokarmowy",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 12,
                Name = "Układ mięśniowo-szkieletowy",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 13,
                Name = "Oczy",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 14,
                Name = "Układ moczowo-płciowy",
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 15,
                Name = "Układ nerwowy",
            });

            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 1,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(31.99),
                CategoryId = 0,
                Quantity = 59,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 2,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(70.99),
                CategoryId = 0,
                Quantity = 165,
                ActiveSubstanceId = 4,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 3,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(39.99),
                CategoryId = 0,
                Quantity = 857,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 4,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "20 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(62.99),
                CategoryId = 0,
                Quantity = 225,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 5,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "20 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(117.99),
                CategoryId = 0,
                Quantity = 853,
                ActiveSubstanceId = 3,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 6,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(49.99),
                CategoryId = 1,
                Quantity = 671,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 7,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(63.99),
                CategoryId = 1,
                Quantity = 724,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 8,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(32.99),
                CategoryId = 1,
                Quantity = 90,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 9,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(149.99),
                CategoryId = 1,
                Quantity = 808,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 10,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(74.99),
                CategoryId = 1,
                Quantity = 871,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 11,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(79.99),
                CategoryId = 2,
                Quantity = 616,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 12,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(60.99),
                CategoryId = 2,
                Quantity = 341,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 13,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(62.99),
                CategoryId = 2,
                Quantity = 96,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 14,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(137.99),
                CategoryId = 2,
                Quantity = 92,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 15,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(57.99),
                CategoryId = 2,
                Quantity = 855,
                ActiveSubstanceId = 8,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 16,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "20 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(27.99),
                CategoryId = 3,
                Quantity = 543,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 17,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(32.99),
                CategoryId = 3,
                Quantity = 861,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 18,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "20 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(76.99),
                CategoryId = 3,
                Quantity = 942,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 19,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(120.99),
                CategoryId = 3,
                Quantity = 390,
                ActiveSubstanceId = 4,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 20,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(115.99),
                CategoryId = 3,
                Quantity = 688,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 21,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(149.99),
                CategoryId = 4,
                Quantity = 569,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 22,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(106.99),
                CategoryId = 4,
                Quantity = 130,
                ActiveSubstanceId = 3,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 23,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(138.99),
                CategoryId = 4,
                Quantity = 625,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 24,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(122.99),
                CategoryId = 4,
                Quantity = 123,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 25,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(98.99),
                CategoryId = 4,
                Quantity = 388,
                ActiveSubstanceId = 3,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 26,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(105.99),
                CategoryId = 5,
                Quantity = 145,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 27,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(24.99),
                CategoryId = 5,
                Quantity = 552,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 28,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(97.99),
                CategoryId = 5,
                Quantity = 502,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 29,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(59.99),
                CategoryId = 5,
                Quantity = 907,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 30,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(57.99),
                CategoryId = 5,
                Quantity = 794,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 31,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(59.99),
                CategoryId = 6,
                Quantity = 83,
                ActiveSubstanceId = 3,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 32,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(22.99),
                CategoryId = 6,
                Quantity = 534,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 33,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(121.99),
                CategoryId = 6,
                Quantity = 134,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 34,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(96.99),
                CategoryId = 6,
                Quantity = 395,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 35,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(97.99),
                CategoryId = 6,
                Quantity = 525,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 36,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(72.99),
                CategoryId = 7,
                Quantity = 899,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 37,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(30.99),
                CategoryId = 7,
                Quantity = 23,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 38,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(24.99),
                CategoryId = 7,
                Quantity = 194,
                ActiveSubstanceId = 8,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 39,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(85.99),
                CategoryId = 7,
                Quantity = 909,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 40,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(106.99),
                CategoryId = 7,
                Quantity = 912,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 41,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(24.99),
                CategoryId = 8,
                Quantity = 675,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 42,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(98.99),
                CategoryId = 8,
                Quantity = 913,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 43,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(91.99),
                CategoryId = 8,
                Quantity = 263,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 44,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(20.99),
                CategoryId = 8,
                Quantity = 861,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 45,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(95.99),
                CategoryId = 8,
                Quantity = 289,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 46,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(53.99),
                CategoryId = 9,
                Quantity = 331,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 47,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(63.99),
                CategoryId = 9,
                Quantity = 268,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 48,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(58.99),
                CategoryId = 9,
                Quantity = 933,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 49,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(73.99),
                CategoryId = 9,
                Quantity = 274,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 50,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(112.99),
                CategoryId = 9,
                Quantity = 553,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 51,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(145.99),
                CategoryId = 10,
                Quantity = 341,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 52,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(123.99),
                CategoryId = 10,
                Quantity = 71,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 53,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "20 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(126.99),
                CategoryId = 10,
                Quantity = 293,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 54,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(19.99),
                CategoryId = 10,
                Quantity = 849,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 55,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(43.99),
                CategoryId = 10,
                Quantity = 286,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 56,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "200 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(19.99),
                CategoryId = 11,
                Quantity = 654,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 57,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(55.99),
                CategoryId = 11,
                Quantity = 375,
                ActiveSubstanceId = 0,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 58,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(144.99),
                CategoryId = 11,
                Quantity = 767,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 59,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(133.99),
                CategoryId = 11,
                Quantity = 869,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 60,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(51.99),
                CategoryId = 11,
                Quantity = 253,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 61,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(136.99),
                CategoryId = 12,
                Quantity = 475,
                ActiveSubstanceId = 2,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 62,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(119.99),
                CategoryId = 12,
                Quantity = 116,
                ActiveSubstanceId = 4,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 63,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(21.99),
                CategoryId = 12,
                Quantity = 329,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 64,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(48.99),
                CategoryId = 12,
                Quantity = 749,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 65,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "75 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(98.99),
                CategoryId = 12,
                Quantity = 458,
                ActiveSubstanceId = 1,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 66,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(102.99),
                CategoryId = 13,
                Quantity = 912,
                ActiveSubstanceId = 4,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 67,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(98.99),
                CategoryId = 13,
                Quantity = 51,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 68,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(71.99),
                CategoryId = 13,
                Quantity = 87,
                ActiveSubstanceId = 9,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 69,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(146.99),
                CategoryId = 13,
                Quantity = 197,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 70,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "150 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(129.99),
                CategoryId = 13,
                Quantity = 499,
                ActiveSubstanceId = 8,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 71,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(41.99),
                CategoryId = 14,
                Quantity = 565,
                ActiveSubstanceId = 7,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 72,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(64.99),
                CategoryId = 14,
                Quantity = 212,
                ActiveSubstanceId = 5,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 73,
                TradeName = "Nazwa leku",
                Dosage = "3 tabletki",
                PackSize = "100 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(78.99),
                CategoryId = 14,
                Quantity = 735,
                ActiveSubstanceId = 6,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 74,
                TradeName = "Nazwa leku",
                Dosage = "2 tabletki",
                PackSize = "30 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(110.99),
                CategoryId = 14,
                Quantity = 158,
                ActiveSubstanceId = 4,
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 75,
                TradeName = "Nazwa leku",
                Dosage = "5 tabletek",
                PackSize = "10 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(96.99),
                CategoryId = 14,
                Quantity = 872,
                ActiveSubstanceId = 8,
            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserGuid = 1
            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserGuid = 2
            });
        }

        public DbSet<ActiveSubstance> ActiveSubstances { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}