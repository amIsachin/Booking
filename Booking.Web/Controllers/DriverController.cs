﻿using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
