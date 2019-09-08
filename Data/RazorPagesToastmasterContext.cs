using Microsoft.EntityFrameworkCore;

namespace RazorPagesToastmaster.Models
{
    public class RazorPagesToastmasterContext : DbContext
    {
        public RazorPagesToastmasterContext (DbContextOptions<RazorPagesToastmasterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(x => x.Username).IsUnique();
        }

        public DbSet<User> User { get; set; }
    }
}
