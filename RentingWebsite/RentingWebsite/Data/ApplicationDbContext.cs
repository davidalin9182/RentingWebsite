using Microsoft.EntityFrameworkCore;
using RentingWebsite.Models;

namespace RentingWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<AddAnouncements> AddAnouncements { get; set; }
        public DbSet<Anouncements> Anouncements { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Home> Home { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Register> Register { get; set; }
    }
}
