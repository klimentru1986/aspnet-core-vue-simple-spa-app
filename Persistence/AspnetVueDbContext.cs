using aspnet_vue.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_vue.Persistence
{
    public class AspnetVueDbContext : DbContext
    {
        public AspnetVueDbContext(DbContextOptions<AspnetVueDbContext> options) : base(options)
        { }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}