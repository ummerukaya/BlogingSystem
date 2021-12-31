using BloginSystem.Entities;
using BloginSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Factories
{
    public class UserFactory : IUserFactory
    {
        public User PrepareUser(UserModel userModel)
        {
            var entity = new User();
            entity.Id = userModel.Id;
            entity.Firstname = userModel.Firstname;
            entity.Lastname = userModel.Lastname;
            entity.PhoneNumber = userModel.PhoneNumber;
            entity.Email = userModel.Email;
            entity.Password = userModel.Password;
            return entity;
        }

        public UserModel PrepareUserModel(User user)
        {
            var model = new UserModel();
            model.Id = user.Id;
            model.Firstname = user.Firstname;
            model.Lastname = user.Lastname;
            model.PhoneNumber = user.PhoneNumber;
            model.Email = user.Email;
            model.Password = user.Password;
            return model;
        }

    }
}
