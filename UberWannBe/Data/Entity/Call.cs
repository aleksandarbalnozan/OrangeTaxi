using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UberWannBe.Data.Entity
{
    public partial class Call
    {
        [Key]
        public int UserId { get; set; }
        [Key]
        public int DriverId { get; set; }

        [ForeignKey(nameof(DriverId))]
        [InverseProperty("Calls")]
        public virtual Driver Driver { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Calls")]
        public virtual User User { get; set; }
    }
}
