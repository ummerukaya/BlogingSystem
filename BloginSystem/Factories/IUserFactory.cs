using BloginSystem.Entities;
using BloginSystem.Models;

namespace BloginSystem.Factories
{
    public interface IUserFactory
    {
        User PrepareUser(UserModel userModel);
        UserModel PrepareUserModel(User user);
    }
}