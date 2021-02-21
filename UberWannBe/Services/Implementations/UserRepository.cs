using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberWannBe.Data.Context;
using UberWannBe.Data.Entity;
using UberWannBe.Services.Interfaces;

namespace UberWannBe.Services.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly UberContext context;

        public UserRepository(UberContext context)
        {
            this.context = context;
        }

        public void CreateUser(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public void EditUser(int userId, User user)
        {
            context.Update(user);
            context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public User GetUser(int userId)
        {
            return context.Users.FirstOrDefault(u=>u.UserId ==userId);
        }

        public void RemoveUser(int userId)
        {
            var user = context.Users.FirstOrDefault(u => u.UserId == userId);
            context.Remove(user);
            context.SaveChanges();
        }
    }
}
