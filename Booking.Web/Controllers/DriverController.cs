using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class DriverController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int a)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }


    }
}
