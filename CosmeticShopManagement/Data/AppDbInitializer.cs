using CosmeticShopManagement.Models;

namespace CosmeticShopManagement.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            ProductName = "Hair Lotion",
                            Description = "The brand that makes the most classy and classic products",
                            Price = "50$",
                            ProductPicture = "https://clmensstore.com/wp-content/uploads/2021/05/Oil_NobleOud_1800x1800-768x768.jpg",
                            Type = ProductType.Hair,
                            ExpiriedDate = DateTime.Now,
                        }
                    });
                    context.SaveChanges();
                }
                //Company
                if (!context.Companies.Any())
                {
                    context.Companies.AddRange(new List<Company>()
                    {
                        new Company()
                        {
                            CompanyName = "18.21 Man Made",
                            CompanyPicture = "https://clmensstore.com/wp-content/uploads/2021/05/Oil_NobleOud_1800x1800-768x768.jpg",
                            Bio = "The brand that makes the most classy and classic products"
                        }
                    });
                }
                //Owner
                if (!context.Owners.Any())
                {
                    context.Owners.AddRange(new List<Owner>()
                    {
                        new Owner()
                        {
                            OwnerName = "Owner1",
                            OwnerPicture = "https://clmensstore.com/wp-content/uploads/2021/05/Oil_NobleOud_1800x1800-768x768.jpg",
                            Bio = "The brand that makes the most classy and classic products"
                        }
                    });
                    context.SaveChanges();
                }
                //Owner & Product
                if (!context.Owner_Products.Any())
                {
                    context.Owner_Products.AddRange(new List<Owner_Product>()
                    {
                        new Owner_Product()
                        {
                            OwnerId = 1,
                            ProductId = 1
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
