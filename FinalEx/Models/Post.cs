using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalEx.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required, StringLength(150, MinimumLength = 20)]
        public string? Title { get; set; }

        [Required, StringLength(150, MinimumLength = 10)]
        public string? Content { get; set; }

        public DateTime PostedDate { get; set; }

        public string? UserId { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }

        public string? Image { get; set; }
    }
}
