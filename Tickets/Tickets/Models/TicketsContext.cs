using Microsoft.EntityFrameworkCore;

namespace TicketsList.Models
{
    public class TicketsContext : DbContext
    {
        public TicketsContext(DbContextOptions<TicketsContext> options)
            : base(options) { }

        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusConfig());
        }
    }
}
