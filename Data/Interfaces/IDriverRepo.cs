using OrangeTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Data.Interfaces
{
    interface IDriverRepo
    {
        Driver CreateDriver(Driver driver);
        void RemoveDriver(int driverId);
        Driver UpdateDrvier(Driver driver);
    }
}
