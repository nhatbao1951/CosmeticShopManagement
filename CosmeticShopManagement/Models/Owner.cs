using System.ComponentModel.DataAnnotations;

namespace CosmeticShopManagement.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        [Display(Name = "OwnerName")]
        public string OwnerName { get; set; }
        
        [Display(Name = "Profile OwnerPicture URL")]
        public string OwnerPicture { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        // Relashionship
        public List<Owner_Product> Owner_Products { get; set; }
    }
}
