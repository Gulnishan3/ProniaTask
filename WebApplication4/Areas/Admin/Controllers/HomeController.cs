using Microsoft.AspNetCore.Mvc;
using WebApplication4.Repositories.Implementation;

namespace WebApplication4.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            SlideRepository repository = new();
            var sliders = await repository.GetAllAsync();
            return View(sliders);
        }
    }
}
