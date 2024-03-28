using FarmSite2API.Data;
using FarmSite2API.Entities;
using FarmSite2API.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Repositories
{ }
public class CityService : ICity
{
    private readonly DbContextClass _context;

    public CityService(DbContextClass context)
    {
        _context = context;
    }

    public async Task<string> AddCity(City city)
    {
        try
        {
            // Check if the city already exists
            var existingCity = await _context.City.FirstOrDefaultAsync(c =>
                c.CityName == city.CityName && c.State == city.State && c.Country == city.Country);

            if (existingCity != null)
            {
                return "City already exists in the system.";
            }

            // Call the stored procedure to insert the city
            await _context.Database.ExecuteSqlRawAsync(
                "EXEC InsertCity @CityName, @State, @Country",
                new SqlParameter("@CityName", city.CityName),
                new SqlParameter("@State", city.State),
                new SqlParameter("@Country", city.Country)
            );

            return "City inserted successfully.";
        }
        catch (Exception ex)
        {
            return $"An error occurred: {ex.Message}";
        }
    }
}
