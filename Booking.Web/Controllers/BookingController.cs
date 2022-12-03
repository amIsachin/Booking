using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BookingCityTaxi()
        {
            return View();
        }

        public IActionResult BooKingRentals()
        {
            return View();
        }
    }
}