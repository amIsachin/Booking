using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BooKingNow()
        {
            return View();
        }
    }
}