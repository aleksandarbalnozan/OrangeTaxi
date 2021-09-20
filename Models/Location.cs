using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string Longitude { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
