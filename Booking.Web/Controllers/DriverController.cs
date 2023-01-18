using Application.Common.Interfaces.Driver;
using Domain.Entities.SystemEntities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Booking.Web.Controllers
{
    public class DriverController : Controller
    {
        #region DependencyInjection
        private readonly ICreateDriverCommand _driverCommand;
        public DriverController(ICreateDriverCommand driverCommand)
        {
            this._driverCommand = driverCommand;
        } 
        #endregion

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new DriverSystemEntity());
        }

        [HttpPost]
        public async Task<IActionResult> Registration(DriverSystemEntity driverSystemEntity)
        {
            int isInserted = await _driverCommand.InsertDriver(driverSystemEntity);

            if (isInserted > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(driverSystemEntity);
            }
        }
    }
}