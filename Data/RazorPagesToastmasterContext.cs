using Microsoft.EntityFrameworkCore;

namespace RazorPagesToastmaster.Models
{
    public class RazorPagesToastmasterContext : DbContext
    {
        public RazorPagesToastmasterContext (DbContextOptions<RazorPagesToastmasterContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
