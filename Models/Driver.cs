using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<DriverVehicle> DriverVehicles { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
