using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RuneSolverUI.Models
{
    public partial class runesolverContext : DbContext
    {
        public runesolverContext()
        {
        }

        public runesolverContext(DbContextOptions<runesolverContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=runesolver.database.windows.net;database=runesolver;user id=Svc_runesolver_admin;password=EA4y6fC75eLhtQdj;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.PkSessionId);

                entity.Property(e => e.PkSessionId).HasColumnName("pkSessionId");

                entity.Property(e => e.FkUserId).HasColumnName("fkUserId");

                entity.Property(e => e.Expiry).HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Sessions)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sessions_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.PkUserId);

                entity.Property(e => e.PkUserId).HasColumnName("pkUserId");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Expiry).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
