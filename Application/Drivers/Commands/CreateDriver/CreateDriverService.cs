using Domain.Entities.Global_Entities;
using Infrastructure.Persistence;

namespace Application.Drivers.Commands.CreateDriver
{
    public class CreateDriverService
    {
        private readonly CreateDriverCommand _driverCommand;
        private readonly ApplicationDbContext _context;
        public CreateDriverService(CreateDriverCommand driverCommand, ApplicationDbContext context)
        {
            _context = context;
            this._driverCommand = new CreateDriverCommand(_context);
        }

        public int CreateDriver(DriverGlobalEntity driverGlobalEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
