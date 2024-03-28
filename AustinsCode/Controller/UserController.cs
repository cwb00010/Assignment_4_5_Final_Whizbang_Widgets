using Microsoft.AspNetCore.Mvc;
using FarmSite2API.Data;
using FarmSite2API.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Controllers
{ }
[Route("api/[controller]")]
[ApiController]
public class UserController(DbContext context) : ControllerBase
{
    private readonly UserDbContext _context = (UserDbContext)context;

    [HttpPost]
    public async Task<ActionResult> AddUser([FromBody] User user)
    {
        try
        {
            // Check if the username already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.UserName == user.UserName);

            if (existingUser != null)
            {
                return Conflict("Username already exists in the system.");
            }

            // Call the stored procedure to insert the user
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC InsertUser @UserName, @FarmType, @CityID",
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@FarmType", user.FarmType),
                new SqlParameter("@CityID", user.CityId)
            );

            return Ok("User inserted successfully.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }
}
