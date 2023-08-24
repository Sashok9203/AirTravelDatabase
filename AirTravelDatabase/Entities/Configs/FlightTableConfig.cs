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
            builder.ToTable(t => t.HasCheckConstraint("Arrival", "Arrival < Departure").HasName("DATETIME_CHECK"));
            builder.HasOne(x => x.ArrivalCity).WithMany(x => x.ArivalFlights).HasForeignKey(x => x.ArrivalCityId);
            builder.HasOne(x => x.DepartureCity).WithMany(x => x.DepartureFlights).HasForeignKey(x => x.DepartureCityId);
            builder.HasOne(x => x.Plane).WithMany(x => x.Flights).HasForeignKey(x => x.PlaneId);
            builder.HasMany(x => x.Clients).WithMany(x => x.Flights);
        }
    }
}
