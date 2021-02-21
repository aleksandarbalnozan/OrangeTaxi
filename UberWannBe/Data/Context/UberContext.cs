using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UberWannBe.Data.Entity;

namespace UberWannBe.Data.Context
{
    public partial class UberContext : DbContext
    {
        public virtual DbSet<Call> Calls { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public UberContext(DbContextOptions<UberContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Call>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DriverId })
                    .HasName("PK__Calls__4893D09C9B9EE996");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calls__DriverId__44FF419A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Calls)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calls__UserId__440B1D61");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Drivers__UserId__412EB0B6");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
