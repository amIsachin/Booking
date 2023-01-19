using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class SharedController : Controller
    {
        [HttpPost]
        public IActionResult UploadImage()
        {
            
            return View();
        }
    }
}
