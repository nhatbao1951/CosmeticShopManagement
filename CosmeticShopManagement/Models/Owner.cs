using System.ComponentModel.DataAnnotations;

namespace CosmeticShopManagement.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPicture { get; set; }
        public string Bio { get; set; }

        // Relashionship
        public List<Owner_Product> Owner_Products { get; set; }
    }
}
