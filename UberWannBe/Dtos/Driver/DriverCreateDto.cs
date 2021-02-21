using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UberWannBe.Dtos.Driver
{
    public class DriverCreateDto
    {
        public int? UserId { get; set; }

        public DateTime DateOfCreating { get; set; }
        public bool IsActive { get; set; }
    }
}
