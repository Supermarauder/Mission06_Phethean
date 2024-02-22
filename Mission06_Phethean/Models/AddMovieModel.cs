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
        public int? CategoryId { get; set; }
        public CategoryClass? Category { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2100, ErrorMessage = "Please enter a year between 1888 and 2100.")]
        public int Year { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please specify if this movie was edited.")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Please specify if this movie was copied to plex")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
