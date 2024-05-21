using System.ComponentModel.DataAnnotations;

namespace FinalEx.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "Password isn't match.")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
