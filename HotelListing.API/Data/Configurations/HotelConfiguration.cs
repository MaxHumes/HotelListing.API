using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { Id = 1, Name = "Sandals Resort", Address = "Negril", CountryId = 1, rating = 4.5 }
                , new Hotel { Id = 2, Name = "Comfort Suites", Address = "George Town", CountryId = 3, rating = 4.1 }
                , new Hotel { Id = 3, Name = "Grand Palldium", Address = "Nassau", CountryId = 2, rating = 5 }
            );
        }
    }
}
