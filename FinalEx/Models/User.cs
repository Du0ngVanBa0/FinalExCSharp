using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FinalEx.Models
{
    public class User : IdentityUser
    {
        [Required]
        public String? Name { get; set; }
    }
}
