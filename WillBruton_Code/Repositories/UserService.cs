using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using FarmMaxSiteAPI.Data;
using FarmMaxSiteAPI.Entities;

namespace FarmMaxSiteAPI.Repositiories
{
    public class UserDetails : IUserService
    {
        private readonly DbContextClass _dbContextClass;
        public UserDetails(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<User>> InsertCityID(int CityID)
        {
            var param = new SqlParameter("@CityID", CityID);
            var UserDetails = await Task.Run(() => _dbContextClass.User.FromSqlRaw("exec spGetUserDetailsByCity @CityID", param).ToListAsync());
            return UserDetails;
        }
    }
}
       
