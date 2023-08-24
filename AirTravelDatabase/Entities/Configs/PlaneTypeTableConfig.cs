using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities.Configs
{
    internal class PlaneTypeTableConfig : IEntityTypeConfiguration<PlaneType>
    {
        public void Configure(EntityTypeBuilder<PlaneType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Type).IsUnique();
            builder.Property(x => x.Type).HasMaxLength(56);
        }
    }
}
