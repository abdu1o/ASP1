using Microsoft.AspNetCore.Mvc;

namespace ASP1.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.CurrentDate = DateTime.Now;

            return View();
        }
    }
}
