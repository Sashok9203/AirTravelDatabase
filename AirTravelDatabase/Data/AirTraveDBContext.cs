using AirTravelDatabase.Entities;
using AirTravelDatabase.Entities.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravelDatabase.Data
{
    public class AirTraveDBContext : DbContext
    {
        public AirTraveDBContext()
        {
            Database.EnsureDeleted();
            if (Database.EnsureCreated())
            {
                foreach (var item in Flights)
                {
                    int count = Data.Planes[item.PlaneId - 1].PassengersCount;
                    for (int k = 0; k <= count; k++)
                        item.Clients.Add(Data.Clients[new Random().Next(0, 50)]);
                }
                SaveChanges();
            };
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Account>(new AccountTableConfig());
            modelBuilder.ApplyConfiguration<City>(new CityTableConfig());
            modelBuilder.ApplyConfiguration<Country>(new CountryTableConfig());
            modelBuilder.ApplyConfiguration<Gender>(new GenderTableConfig());
            modelBuilder.ApplyConfiguration<Plane>(new AirPlaneTableConfig());
            modelBuilder.ApplyConfiguration<Client>(new ClientTableConfig());
            modelBuilder.ApplyConfiguration<Flight>(new FlightTableConfig());

            Data.Initializer(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<PlaneType> PlaneTypes { get; set; }
        public DbSet<Plane> AirPlanes { get; set; }
        public DbSet<Flight> Flights { get; set; }
    }
}
