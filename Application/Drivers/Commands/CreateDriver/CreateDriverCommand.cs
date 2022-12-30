using Application.Common.Interfaces.Driver;
using Domain.Entities.SystemEntities;
using Infrastructure.Persistence;

namespace Application.Drivers.Commands.CreateDriver
{
    /// <summary>
    /// This *(CreateDriverCommand) class is main *(service) which saves the driver data in the database directly.
    /// </summary>
    public sealed class CreateDriverCommand : ICreateDriverCommand
    {
        private readonly ApplicationDbContext _driverService;
        public CreateDriverCommand(ApplicationDbContext driverService)
        {
            this._driverService = driverService;
        }

        public int InsertDriver(DriverSystemEntity driverSystemEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
