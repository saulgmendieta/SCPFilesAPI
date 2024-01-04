using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCPFilesAPI.Entities;

namespace SCPFilesAPI
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<SCP> SCP { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<IncidentLog> IncidentLog { get; set; }
        public DbSet<ContentionArea> ContentionArea { get; set; }
    }
}
