

using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
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
                    ID = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    ID = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    ID = 3,
                    Name = "Cayman Islands",
                    ShortName = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    Rating = 4.5,
                    CountryID = 1
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Grand Palladium",
                    Address = "Nassau",
                    Rating = 4,
                    CountryID = 2
                },
                new Hotel
                {
                    ID = 3,
                    Name = "Comfort Suites",
                    Address = "Seven Mile Beach",
                    Rating = 4.3,
                    CountryID = 3
                }
            );
        }
    }
}
