using System.ComponentModel.DataAnnotations;

namespace FinalEx.ViewModels
{
    public class UpdProfile
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }

        public string? Image { get; set; }
    }
}
