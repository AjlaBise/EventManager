using EventManager.Dal.Configuration;
using EventManager.Dal.Domain;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Dal.Context
{
    public class EventManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        public EventManagerDbContext(DbContextOptions<EventManagerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    }
}