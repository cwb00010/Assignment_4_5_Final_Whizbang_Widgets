using FarmSite2API.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmSite2API.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        { }



    public DbSet<User> Users { get; set; }
    } }
