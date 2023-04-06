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
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo", Name = "To do" },
                new Status { StatusId = "inprogress", Name = "In progress" },
                new Status { StatusId = "qualityassuranceqa", Name = "Quality assurance(qa)" },
                new Status { StatusId = "done", Name = "Done" }
            );
        }
    }
}
