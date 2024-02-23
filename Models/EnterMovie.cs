using System.ComponentModel.DataAnnotations;

namespace Mission6_HaydenEnloe.Models
{
    public class EnterMovie
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Range(1900, 9999, ErrorMessage = "Year must be a valid year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? Lent_to { get; set; }

        [StringLength(255, ErrorMessage = "Notes cannot exceed 255 characters.")]
        public string? Notes { get; set; }
    }
}

