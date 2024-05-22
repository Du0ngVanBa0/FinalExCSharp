using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalEx.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [Required, StringLength(150, MinimumLength = 20)]
        public string? Title { get; set; }

        [Required, StringLength(150, MinimumLength = 10)]
        public string? Content { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public string? Image { get; set; }
    }
}
