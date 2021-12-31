using BloginSystem.Entities;
using BloginSystem.Models;

namespace BloginSystem.Services
{
    public interface IUserService
    {
        void InsertUser(User user);
        public User GetUserById(int id);
        public User Validate(LoggedinUserModel loggedinUserModel);
    }
}