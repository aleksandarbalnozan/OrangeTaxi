using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Entity;

namespace UberWannBe.Services.Interfaces
{
    interface IDriverRepository
    {
        IEnumerable<Driver> GetAllDrivers();
        Driver GetDriver(int driverId);
        void CreateDriver(Driver driver);
        void RemoveDriver(int driverId);
        Driver EditDriver(Driver driver);
    }
}
