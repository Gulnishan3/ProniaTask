using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Models
{
    public class BaseEnitity : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
