using Microsoft.EntityFrameworkCore;
using LMS.DOMAIN.Entities;

namespace LMS.INFASTRUCTURE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
