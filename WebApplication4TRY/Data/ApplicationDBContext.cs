using Microsoft.EntityFrameworkCore;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using WebApplication4TRY.Models;

namespace CrudApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }
    }
}
