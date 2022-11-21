using CosmeticShopManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticShopManagement.Controllers
{
    public class OwnerController : Controller
    {
        private readonly AppDbContext _context;

        public OwnerController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var data = _context.Owners.ToList();
            return View();
        }
    }
}
