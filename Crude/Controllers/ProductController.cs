using Microsoft.AspNetCore.Mvc;

namespace Crude.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
