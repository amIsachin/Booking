using Application.Common.Interfaces.Driver;
using Domain.Entities.SystemEntities;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class DriverController : Controller
    {
        private readonly ICreateDriverCommand _driverCommand;
        public DriverController(ICreateDriverCommand driverCommand)
        {
            this._driverCommand = driverCommand;
        }

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
        public IActionResult Registration(DriverSystemEntity driverSystemEntity)
        {
            _driverCommand.InsertDriver(driverSystemEntity);

            //if (_driverCommand.InsertDriver(driverSystemEntity) > 0)
            //{

            //}


            return View();
        }
    }
}