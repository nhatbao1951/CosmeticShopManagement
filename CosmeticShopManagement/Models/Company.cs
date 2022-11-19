using System.ComponentModel.DataAnnotations;

namespace CosmeticShopManagement.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPicture { get; set; }
        public string Bio { get; set; }

        // Relationships

        public List<Product> Products { get; set; }
    }
}
