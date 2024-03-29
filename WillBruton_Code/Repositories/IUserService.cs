using System.Threading.Tasks;
using FarmMaxSiteAPI.Entities;


namespace FarmMaxSiteAPI.Repositiories
{
    public interface IUserService
    {
        public Task<List<User>> InsertCityID(int CityID);
        
        

    }
}
