using CmsServer.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CmsServer.Infrastructure.Data
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext(DbContextOptions<CmsDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}