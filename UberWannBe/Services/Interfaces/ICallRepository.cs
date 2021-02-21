using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Entity;

namespace UberWannBe.Services.Interfaces
{
    interface ICallRepository
    {
        IEnumerable<Call> GetCallsFromUser(int userId);
        IEnumerable<Call> GetCallsFromDriver(int driverId);

        void CreateCall(Call call);
    }
}
