using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Contact
    {
        // EF Core will configure the database to generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        public string Note { get; set; }

    }
}
