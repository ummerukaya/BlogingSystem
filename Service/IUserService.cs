using BloginSystem.DataAccess;
namespace BloginSystem.Service
{
    public interface IUserService 
    {
        void InsertUser(User user);
        public User GetUserById(int id);
        public User Validate(string email, string password);
    }
}