using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class DriverVehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Plates { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Brand { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Model { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Type { get; set; }

        public int DriverId { get; set; }
        [ForeignKey("DriverId")]
        public Driver Drivers { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
