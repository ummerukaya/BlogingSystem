using BloginSystem.Entities;
using BloginSystem.Models;
using BloginSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Services
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
        public User Validate(LoggedinUserModel loggedinUserModel)
        {
            var user = _repository.GetAll().Where(x => x.Email.Equals(loggedinUserModel.Email)
                       && x.Password.Equals(loggedinUserModel.Password)).FirstOrDefault();
            return user;
        }
    }
}
