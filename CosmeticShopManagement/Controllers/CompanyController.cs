using CosmeticShopManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CosmeticShopManagement.Controllers
{
    public class CompanyController : Controller
    {
        private readonly AppDbContext _context;

        public CompanyController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allCompany = await _context.Companies.ToListAsync();
            return View(allCompany);
        }
    }
}
