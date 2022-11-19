namespace CosmeticShopManagement.Models
{
    public class Owner_Product
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
