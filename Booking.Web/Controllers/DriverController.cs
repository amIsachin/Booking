using Domain.Entities.Global_Entities;
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
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(DriverGlobalEntity driverGlobalEntity)
        {
            return View();
        }
    }
}