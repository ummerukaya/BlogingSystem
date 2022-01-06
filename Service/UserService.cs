using BloginSystem.DataAccess;
using BloginSystem.Repository;
using System.Linq;

namespace BloginSystem.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public void InsertUser(User user)
        {
            _repository.Insert(user);
        }
        public User GetUserById(int id)
        {
            return _repository.GetById(id);
        }
        public User Validate(string email, string password)
        {
            var user = _repository.GetAll().Where(x => x.Email.Equals(email)
                       && x.Password.Equals(password)).FirstOrDefault();
            return user;
        }
    }
}
