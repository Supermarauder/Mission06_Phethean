using System.ComponentModel.DataAnnotations;
namespace Mission06_Phethean.Models
{
    public class CategoryClass
    {
        [Key]
        public int CategoryId { get; set; }
        
        public string? CategoryName { get; set; }
    }
}
