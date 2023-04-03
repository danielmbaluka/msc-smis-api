using Microsoft.EntityFrameworkCore;

namespace SMIS.Models
{
    public class SmisDbContext : DbContext
    {
        public SmisDbContext()
        {
        }

        public SmisDbContext(DbContextOptions<SmisDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("Student_pkey");

                entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            });
        }
    }
}
