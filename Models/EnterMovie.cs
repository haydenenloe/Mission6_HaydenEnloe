using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_HaydenEnloe.Models
{
    public class EnterMovie
    {
        [Key]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required]
        [Range(1900, 9999, ErrorMessage = "Year must be a valid year.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copy to flex field is required")]
        public int CopiedToPlex { get; set; }

        [StringLength(255, ErrorMessage = "Notes cannot exceed 255 characters.")]
        public string? Notes { get; set; }

    }
}

