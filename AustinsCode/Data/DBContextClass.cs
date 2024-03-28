using FarmSite2API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<City> City { get; set; }
    }
}
