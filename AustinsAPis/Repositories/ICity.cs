using FarmSite2API.Entities;

namespace FarmSite2API.Repositories
{
    public interface ICity
    {
        Task<string> AddCity(City city);

    }
}
