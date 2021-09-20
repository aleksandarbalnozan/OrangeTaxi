using OrangeTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Data.Interfaces
{
    interface IRiderRepo
    {
        Rider CreateRider(Rider rider);
        void RemoveRider(int riderId);
        Rider UpdateRider(Rider rider);
    }
}
