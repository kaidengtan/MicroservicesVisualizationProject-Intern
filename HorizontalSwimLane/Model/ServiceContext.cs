using Microsoft.EntityFrameworkCore;

namespace HorizontalSwimLane.Model
{
    public class ServiceContext : DbContext
    {
        //Table name
        public DbSet<Service> Services { get; set; }

        //Configuration
        public ServiceContext(DbContextOptions options) : base(options)
        {
        }
    }
}
