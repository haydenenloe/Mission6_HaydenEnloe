using System.ComponentModel.DataAnnotations;

namespace Mission6_HaydenEnloe.Models
{
    public class EnterMovie
    {
        [Key]
        [Required]
        public int MovieID { get; set; } // I dont understand this get set thing
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? Lent_to { get; set; }
        public string? Notes { get; set; }
    }
}
