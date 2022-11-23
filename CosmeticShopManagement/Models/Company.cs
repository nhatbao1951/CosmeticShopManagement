using System.ComponentModel.DataAnnotations;

namespace CosmeticShopManagement.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Display(Name = "Profile CompanyName")]
        public string? CompanyName { get; set; }
        
        [Display(Name = "Profile Picture")]
        public string? CompanyPicture { get; set; }

        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        // Relationships

        public List<Product>? Products { get; set; }
    }
}
