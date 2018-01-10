using Microsoft.EntityFrameworkCore;

namespace WhiskyInventory.Data.Models
{
    public partial class WhiskyStoreContext : DbContext
    {
        public WhiskyStoreContext(DbContextOptions<WhiskyStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }

        public virtual DbSet<Distillery> Distillery { get; set; }

        public virtual DbSet<Inventory> Inventory { get; set; }

        public virtual DbSet<Region> Region { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Distillery>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Distillery)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Distillery_Region");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DistilleryId).HasColumnName("DistilleryID");

                entity.Property(e => e.Information).HasMaxLength(2000);

                entity.Property(e => e.WhiskyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Account");

                entity.HasOne(d => d.Distillery)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.DistilleryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_Distillery");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
