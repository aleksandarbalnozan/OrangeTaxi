using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UberWannBe.Data.Entity
{
    public partial class Driver
    {
        public Driver()
        {
            Calls = new HashSet<Call>();
        }

        [Key]
        public int DriverId { get; set; }
        public int? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfCreating { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Drivers")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Call.Driver))]
        public virtual ICollection<Call> Calls { get; set; }
    }
}
