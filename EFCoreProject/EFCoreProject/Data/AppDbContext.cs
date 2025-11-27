using Microsoft.EntityFrameworkCore;

namespace EFCoreProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            
        }
    }
}
