using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Booking.Web.Controllers
{
    public class SharedController : Controller
    {
        [HttpPost]
        public IActionResult UploadImage()
        {
            var pictures = Request.Form.Files[0];

            for (int i = 0; i < pictures.Length; i++)
            {
                var picture = pictures;
                var fileName = picture.FileName + Path.GetExtension(picture.FileName);
            }
            
            return View();
        }
    }
}
