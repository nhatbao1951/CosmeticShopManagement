using CosmeticShopManagement.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CosmeticShopManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ProductPicture { get; set; }
        public ProductType Type { get; set; }    
        public DateTime ExpiriedDate { get; set; }

        //Relationships
        public List<Owner_Product> OwnerProducts { get; set; }

        //Company
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
