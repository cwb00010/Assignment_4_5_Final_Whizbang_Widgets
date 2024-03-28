using FarmSite2API.Data;
using FarmSite2API.Entities;
using FarmSite2API.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Repositories
{
    public class UserService : IUser
    {
        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public async Task<string> AddUser(User user)
        {
            try
            {
                // Check if the username already exists
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName);

                if (existingUser != null)
                {
                    return "Username already exists in the system.";
                }

                // Call the stored procedure to insert the user
                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC InsertUser @UserName, @FarmType, @CityID",
                    new SqlParameter("@UserName", user.UserName),
                    new SqlParameter("@FarmType", user.FarmType),
                    new SqlParameter("@CityID", user.CityId)
                );

                return "User inserted successfully.";
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
