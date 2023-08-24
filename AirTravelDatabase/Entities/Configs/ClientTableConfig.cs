using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Entities.Configs
{
    internal class ClientTableConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(56);
            builder.Property(x => x.Surname).HasMaxLength(56);
            builder.Property(x => x.Email).HasMaxLength(256);
            builder.Ignore(x=>x.FullName);
            builder.HasOne(x => x.Account).WithMany(x => x.Clients).HasForeignKey(x => x.AccountId);
            builder.HasOne(x => x.Gender).WithMany(x => x.Clients).HasForeignKey(x => x.GenderId);
        }
    }
}
