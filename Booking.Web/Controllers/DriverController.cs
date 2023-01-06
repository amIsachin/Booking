using Application.Drivers.Commands.CreateDriver;
using Domain.Entities.Global_Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Web.Controllers
{
    public class DriverController : Controller
    {
        InvalidOperationException: Unable to resolve service for type 'Application.Drivers.Commands.CreateDriver.CreateDriverService' 
            while attempting to activate 'Booking.Web.Controllers.DriverController'.

        private readonly CreateDriverService _driverService;
        private readonly ApplicationDbContext _context;
        private readonly CreateDriverCommand _command;
        public DriverController(CreateDriverService driverService, ApplicationDbContext context, CreateDriverCommand command)
        {
            _command = command;
            _context = context;
            _driverService = new CreateDriverService(command);
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
        public IActionResult Registration(DriverGlobalEntity driverGlobalEntity)
        {
            _driverService.CreateDriver(driverGlobalEntity);

            return View();
        }
    }
}