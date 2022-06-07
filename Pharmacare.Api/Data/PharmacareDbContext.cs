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
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Ból",
            });
            modelBuilder.Entity<Drug>().HasData(new Drug
            {
                DrugId = 1,
                TradeName = "Nazwa leku",
                Dosage = "1 tabletka",
                PackSize = "50 tabletek",
                ImageURL = "https://www.sennik.biz//o/l/z/w336/lzndk3ruq8xh.jpg",
                Price = new decimal(31.99),
                CategoryId = 1,
                Quantity = 59,
                ActiveSubstanceId = 1,
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