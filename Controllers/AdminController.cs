using ASP1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP1.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult CreateProduct()
        {
            var product = HttpContext.Session.Get<Product>("Product");
            if (product == null)
            {
                ViewBag.Message = "Немає попередніх даних";
            }
            else
            {
                ViewBag.Product = product;
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.Set("Product", product); 
                return RedirectToAction("CreateProduct"); 
            }

            return View(product);
        }
    }
}
