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
        private readonly ApplicationDbContext _driverCommand;
        public CreateDriverCommand(ApplicationDbContext driverService)
        {
            this._driverCommand = driverService;
        }

        public int InsertDriver(DriverSystemEntity driverSystemEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}
