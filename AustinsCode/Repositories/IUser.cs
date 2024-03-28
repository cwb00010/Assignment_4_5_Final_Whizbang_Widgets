using FarmSite2API.Entities;

namespace FarmSite2API.Repositories
{
    public interface IUser
    {
        Task<string> AddUser(User user);
    }
}
