using System.ComponentModel.DataAnnotations;

namespace FinalEx.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50), MinLength(3), Required]
        public string? Name { get; set; }
        [MaxLength(255), MinLength(10), Required]
        public string? Description { get; set; }
        [Required]
        public DateOnly? CreatedDate { get; set; }
    }
}
