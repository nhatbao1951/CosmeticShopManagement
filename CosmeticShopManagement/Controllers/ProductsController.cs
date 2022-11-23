using CosmeticShopManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CosmeticShopManagement.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducts = await _context.Products.ToListAsync();
            return View(allProducts);
        }
    }
}
