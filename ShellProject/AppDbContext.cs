using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Domain.Entities;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Data
{
    // DbContext class for the application
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<UserSettings> UserSettings { get; set; }
        public DbSet<DistributedCacheEntry> DistributedCache { get; set; }
    }
}
