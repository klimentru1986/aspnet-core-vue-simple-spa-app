using aspnet_vue.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_vue.Persistence
{
    public class AspnetVueDbContext : DbContext
    {

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<VehicleFeature> VehicleFeature { get; set; }
        public AspnetVueDbContext(DbContextOptions<AspnetVueDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>()
            .HasKey(vf => new { vf.VehicleId, vf.FeatureId });
        }
    }
}