using OrangeTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeTaxi.Data.Interfaces
{
    interface IDriverVehicleRepo
    {
        DriverVehicle CreateVehicle(DriverVehicle vehicle);
        void RemoveVehicle(int vehicleId);
        DriverVehicle UpdateVehicle(DriverVehicle vehicle);
    }
}
