using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class Trip
    {
        public int Id { get; set; }

        public int? DriverId { get; set; }
        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }

        public int? RiderId { get; set; }
        [ForeignKey("RiderId")]
        public Rider Rider { get; set; }

        public int? StartLocationId { get; set; }
        [ForeignKey("StartLocationId")]
        [InverseProperty("Trips")]
        public Location StartLocation { get; set; }

        public int? EndLocationId { get; set; }
        [ForeignKey("EndLocationId")]
        public Location EndLocation { get; set; }

        public int? DriverVehicleId { get; set; }
        [ForeignKey("DriverVehicleId")]
        [InverseProperty("Trips")]
        public DriverVehicle DriverVehicle { get; set; }
    }
}
