using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
