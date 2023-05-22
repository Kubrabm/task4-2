using Microsoft.AspNetCore.Mvc;

namespace task4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
