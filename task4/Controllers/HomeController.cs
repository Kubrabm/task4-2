using Microsoft.AspNetCore.Mvc;

namespace task4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
