using Domain.Entities.Global_Entities;
using Infrastructure.Persistence;

namespace Application.Drivers.Commands.CreateDriver
{
    public class CreateDriverService
    {
        private readonly ApplicationDbContext _driverService;
        private CreateDriverCommand _driverCommand;
        public CreateDriverService(ApplicationDbContext _driverService)
        {
            this._driverCommand = new CreateDriverCommand(_driverService);
        }

        public int CreateDriver(DriverGlobalEntity driverGlobalEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
