using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEx.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }

        [Required, RegularExpression(@"^(090|098|091|031|035|038)\d{7}$", ErrorMessage = "Invalid phone number.")]
        public string? PhoneNumber { get; set; }

        [Required, EmailAddress(ErrorMessage = "Invalid Email.")]
        public string? Email { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string? Position { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

        [Required(ErrorMessage = "Salary is required.")]
        public long Salary { get; set; }
    }
}
