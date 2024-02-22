using System.ComponentModel.DataAnnotations;
namespace Mission06_Phethean.Models
{
    public class CategoryClass
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        
        public string Category { get; set; }
    }
}
