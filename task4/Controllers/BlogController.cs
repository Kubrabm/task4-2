using Microsoft.AspNetCore.Mvc;

namespace task4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
