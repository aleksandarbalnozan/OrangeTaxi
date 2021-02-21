
using System;

namespace UberWannBe.Dtos.Driver
{
    public class DriverReadDto
    {

        public int DriverId { get; set; }
        public int? UserId { get; set; }

        public DateTime DateOfCreating { get; set; }
        public bool IsActive { get; set; }

    }
}
