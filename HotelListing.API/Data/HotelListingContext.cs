using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Jamacia",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 3,
                    Name = "Ghana",
                    ShortName = "GH"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Blow Fish",
                    Address = "Victoria Island",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Marito Hotel",
                    Address = "Aluya Avenue",
                    CountryId = 3,
                    Rating = 6.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Squra",
                    Address = "Altanic Ocean",
                    CountryId = 2,
                    Rating = 5.5
                }
                );
        }
    }
}
