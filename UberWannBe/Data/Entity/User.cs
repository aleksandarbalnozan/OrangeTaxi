using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UberWannBe.Data.Entity
{
    public partial class User
    {
        public User()
        {
            Calls = new HashSet<Call>();
            Drivers = new HashSet<Driver>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [InverseProperty(nameof(Call.User))]
        public virtual ICollection<Call> Calls { get; set; }
        [InverseProperty(nameof(Driver.User))]
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}
