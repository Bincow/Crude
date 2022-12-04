using Crude.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Crude.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult AddProduct(Product model)
        {
            try
            {
                return null;
            }

            catch (Exception ex)
            {
                throw ex;
            }     
        }

        public ActionResult EditProduct(Product model)
        {

            try 
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}