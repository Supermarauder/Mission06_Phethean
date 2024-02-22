using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Phethean.Models
{
    public class AddMovieModel
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(1900, 2100, ErrorMessage = "Please enter a year between 1900 and 2100.")]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string? LentTo { get; set; }

        public bool? CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
