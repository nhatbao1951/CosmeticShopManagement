using CosmeticShopManagement.Data;
using CosmeticShopManagement.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace CosmeticShopManagement.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IOwnersService _service;

        public OwnerController(IOwnersService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
