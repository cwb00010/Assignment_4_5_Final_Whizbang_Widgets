using FarmSite2API.Data;
using FarmSite2API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DbContextClass _context;

        public CityController(DbContextClass context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddCity([FromBody] City city)
        {
            try
            {
                // Check if the city already exists
                var existingCity = await _context.City.FirstOrDefaultAsync(c =>
                    c.CityName == city.CityName && c.State == city.State && c.Country == city.Country);

                if (existingCity != null)
                {
                    return Conflict("City already exists in the system.");
                }

                // Call the stored procedure to insert the city
                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC InsertCity @CityName, @State, @Country",
                    new SqlParameter("@CityName", city.CityName),
                    new SqlParameter("@State", city.State),
                    new SqlParameter("@Country", city.Country)
                );

                return Ok("City inserted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
