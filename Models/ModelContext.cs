using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<DriverVehicle> DriverVehicles { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
