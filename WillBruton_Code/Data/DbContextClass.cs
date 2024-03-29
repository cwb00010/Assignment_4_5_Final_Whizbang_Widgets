using FarmMaxSiteAPI.Entities;
using Microsoft.EntityFrameworkCore; 


namespace FarmMaxSiteAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        { }
        public DbSet<User> User { get; set; }
        public DbSet<Seed> Seed { get; set; }
    }
}
