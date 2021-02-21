using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Entity;
using UberWannBe.Services.Interfaces;

namespace UberWannBe.Services.Implementations
{
    public class CallRepository : ICallRepository
    {
        public void CreateCall(Call call)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Call> GetCallsFromDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Call> GetCallsFromUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
