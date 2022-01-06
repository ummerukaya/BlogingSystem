using BloginSystem.Models;
using BloginSystem.DataAccess;

namespace BloginSystem.Factories
{
    public interface IUserFactory
    {
        User PrepareUser(UserModel userModel);
        UserModel PrepareUserModel(User user);
    }
}