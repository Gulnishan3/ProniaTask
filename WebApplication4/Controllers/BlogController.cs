using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
