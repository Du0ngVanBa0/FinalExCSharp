using System.ComponentModel.DataAnnotations;

namespace FinalEx.ViewModels
{
    public class ChangePassVM
    {
        [Required(ErrorMessage = "Please enter your old password.")]
        [DataType(DataType.Password)]
        public string? OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter a new password.")]
        [DataType(DataType.Password)]
        public string?NewPassword { get; set; }

        [Required(ErrorMessage = "Please confirm your new password.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string? ConfirmNewPassword { get; set; }
    }
}
