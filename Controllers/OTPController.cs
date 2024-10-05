using ASP1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP1.Controllers
{
    public class OTPController : Controller
    {
        private readonly IOTPService _otpService;

        public OTPController(IOTPService otpService)
        {
            _otpService = otpService;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Index");
            string otp = _otpService.GenerateOTP();
            
            ViewBag.OTP = otp;
            return View();
        }
    }
}
