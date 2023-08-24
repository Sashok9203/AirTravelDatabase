using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities.Configs
{
    internal class FlightTableConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Model).HasMaxLength(56);
            builder.HasOne(x => x.ArrivalCity).WithMany(x => x.ArivalFlights).HasForeignKey(x => x.ArrivalCityId);
            builder.HasOne(x => x.DepartureCity).WithMany(x => x.DepartureFlights).HasForeignKey(x => x.DepartureCityId);
            builder.HasOne(x => x.AirPlane).WithMany(x => x.Flights).HasForeignKey(x => x.AirPlaneId);
        }
    }
}
