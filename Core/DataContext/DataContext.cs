using Core;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Principal;


namespace Core
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categorys { get; set; }
        public DbSet<City> Citys { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<FlyCompany> FlyCompanys { get; set; }
        public DbSet<FoodSystem> FoodSystems { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRoom> OrderRooms { get; set; }
        public DbSet<PhotosHotel> PhotosHotels { get; set; }
        public DbSet<PhotosRoom> PhotosRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TypeOfRoom> TypeOfRooms { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var bd = "Server=.; Database=SWTDB; Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(bd);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(o => o.Client)
                      .WithMany(c => c.Orders)
                      .HasForeignKey(o => o.ClientID)
                      .OnDelete(DeleteBehavior.Restrict); // Заміна каскаду

                entity.HasOne(o => o.Tour)
                      .WithMany(t => t.Orders)
                      .HasForeignKey(o => o.TourID)
                      .OnDelete(DeleteBehavior.Restrict); 
            });
        }


    }
}