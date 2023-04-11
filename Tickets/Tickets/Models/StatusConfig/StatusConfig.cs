using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TicketsList.Models
{
    internal class StatusConfig : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> entity)
        {
            entity.HasData(
               new Status { StatusId = "todo", Name = "To do" },
               new Status { StatusId = "inprogress", Name = "In progress" },
               new Status { StatusId = "qualityassuranceqa", Name = "Quality assurance(qa)" },
               new Status { StatusId = "done", Name = "Done" }
            );
        }
    }
}
