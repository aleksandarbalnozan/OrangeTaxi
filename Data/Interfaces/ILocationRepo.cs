using OrangeTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Data.Interfaces
{
    interface ILocationRepo
    {
        Location CreateLocation(Location location);
    }
}
