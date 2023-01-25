using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
        : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Jeff",
                Phone = "123-456-7890",
                Address = "1111 1st St. Los Angeles, CA",
                Note = "School"
            },
            new Contact
            {
                ContactId = 2,
                Name = "Jim",
                Phone = "098-765-4321",
                Address = "1000 NE 20th St. Apt. 1 Des Moines, IA",
                Note = "Family"
            },
            new Contact
            {
                ContactId = 3,
                Name = "John",
                Phone = "111-222-3333",
                Address = "1234 Brown St. New York, NY",
                Note = "Work"
            }
            );
        }
    }
}