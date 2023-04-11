using System;
using System.ComponentModel.DataAnnotations;

namespace TicketsList.Models
{
    public class Tickets
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string Sprint { get; set; }

        [Required(ErrorMessage = "Please enter a point value.")]
        public string Point { get; set; }

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status Status { get; set; }

    }
}
