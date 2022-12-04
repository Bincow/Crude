using Crude.Models;
using Microsoft.AspNetCore.Mvc;
using Crude.Entity;
using Crude.SQL;

namespace Crude.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(Product model)
        {

            ProductBUS productBUS = new ProductBUS();

            try
            {
                ProductEntity productEntity = productBUS.GetProductById(model.ProductId);


                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
    }
}
