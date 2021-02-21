using System.Collections.Generic;
using UberWannBe.Data.Entity;

namespace UberWannBe.Services.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUser(int userId);
        void CreateUser(User user);
        void RemoveUser(int userId);
        void EditUser(int userId, User user);
    }
}
