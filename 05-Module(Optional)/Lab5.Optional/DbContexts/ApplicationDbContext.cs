using Lab5.Optional.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Optional.DbContexts
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions
        <ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Clothing> Clothing { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>(entity => {
                entity.HasKey(f => f.Id);
            }); 
            modelBuilder.Entity<Clothing>(entity => {
                entity.HasKey(c => c.Id);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
