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
                ViewBag.Message = "No previous data";
            }
            else
            {
                ViewBag.Product = product;
            }
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    var filePath = Path.Combine(uploads, imageFile.FileName);

                    if (!Directory.Exists(uploads))
                    {
                        Directory.CreateDirectory(uploads);
                    }

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }

                    product.ImagePath = $"/images/{imageFile.FileName}";
                }

                HttpContext.Session.Set("Product", product); 
                return RedirectToAction("CreateProduct"); 
            }

            return View(product);
        }
    }
}
