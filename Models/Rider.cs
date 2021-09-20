using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Models
{
    public class Rider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Phone { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Country { get; set; }

        public ICollection<Trip> Trips { get; set; }
    }
}
