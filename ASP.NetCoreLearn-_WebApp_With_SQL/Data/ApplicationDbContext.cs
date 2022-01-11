using ASP.NetCoreLearn__WebApp_With_SQL.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NetCoreLearn__WebApp_With_SQL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
