using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Net.NetworkInformation;



namespace FirstResponsiveWebAppMesecher.Models
{
    public class PastDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = (DateTime)value;
            if (DateTime.Now.CompareTo(value) >= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date must be in the past.");
            }
        }
    }
    public class FirstResponsiveWebAppModel
    {
        
        [Required(ErrorMessage = "Please enter a name.")]
        public String? Name { get; set; }

        [PastDate]
        public DateTime Birthdate { get; set; }

        public int? CalculateAge(int DaysInAYear)
        {

            DateTime Today = DateTime.Now;
            TimeSpan DateDiff = Today - Birthdate;
            var Age = DateDiff.Days/DaysInAYear;

            if (Birthdate > Today.AddYears(-Age))
            Age--;
            return Age;
        }
    }
}
