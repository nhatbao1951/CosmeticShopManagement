using CosmeticShopManagement.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CosmeticShopManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Products Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        public string Price { get; set; }
        [Display(Name = "Products Picture")]
        public string ProductPicture { get; set; }
        public string Type { get; set; }    
        public string ExpiriedDate { get; set; }
        public int amount { get; set; }


        //Relationships
        public List<Owner_Product>? OwnerProducts { get; set; }

        //Company
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
    }
}
