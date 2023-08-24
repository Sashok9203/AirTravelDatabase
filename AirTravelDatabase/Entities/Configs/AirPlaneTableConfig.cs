using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities.Configs
{
    internal class AirPlaneTableConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable(t => t.HasCheckConstraint("PassengersCount", "PassengersCount >= 0"));
            builder.Property(x => x.Model).HasMaxLength(56);
            builder.Property(x => x.PassengersCount).HasDefaultValue(0);
            builder.HasOne(x => x.PlaneType).WithMany(x => x.AirPlanes).HasForeignKey(x=>x.PlaneTypeId);
            builder.HasOne(x => x.Country).WithMany(x => x.AirPlanes).HasForeignKey(x => x.CountryId);
        }
    }
}
