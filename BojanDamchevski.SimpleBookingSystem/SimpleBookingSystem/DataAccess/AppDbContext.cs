using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed
            modelBuilder.Entity<Resource>()
                .HasData(
                new Resource()
                {
                    Id = 1,
                    Name = "Resource_1",
                    Quantity = 500
                },
                new Resource()
                {
                    Id = 2,
                    Name = "Resource_2",
                    Quantity = 0
                },
                new Resource()
                {
                    Id = 3,
                    Name = "Resource_3",
                    Quantity = 500
                },
                new Resource()
                {
                    Id = 4,
                    Name = "Resource_4",
                    Quantity = 10
                },
                new Resource()
                {
                    Id = 5,
                    Name = "Resource_5",
                    Quantity = 500
                }
                );

            modelBuilder.Entity<Booking>()
                .HasData(
                new Booking()
                {
                    Id = 1,
                    BookedQuantity = 12,
                    ResourceId = 1,
                    DateFrom = DateTime.Now.AddDays(10),
                    DateTo = DateTime.Now.AddDays(15)
                },
                new Booking()
                {
                    Id = 2,
                    BookedQuantity = 5,
                    ResourceId = 3,
                    DateFrom = DateTime.Now.AddDays(10),
                    DateTo = DateTime.Now.AddDays(15)
                },
                new Booking()
                {
                    Id = 3,
                    BookedQuantity = 4,
                    ResourceId = 4,
                    DateFrom = DateTime.Now.AddDays(10),
                    DateTo = DateTime.Now.AddDays(15)
                }, new Booking()
                {
                    Id = 4,
                    BookedQuantity = 2,
                    ResourceId = 5,
                    DateFrom = DateTime.Now.AddDays(10),
                    DateTo = DateTime.Now.AddDays(15)
                }
                );

            //Relations
            modelBuilder.Entity<Resource>()
                .HasMany(x => x.Bookings)
                .WithOne(x => x.Resource)
                .HasForeignKey(x => x.ResourceId);

            modelBuilder.Entity<Booking>()
                .HasOne(x => x.Resource)
                .WithMany(x => x.Bookings)
                .HasForeignKey(x => x.ResourceId);
        }
    }
}
