using Domain.Entities.SystemEntities;

namespace Application.Common.Interfaces.Driver
{
    /// <summary>
    /// This *(ICreateDriverCommand) interface is main *(service) which saves the driver data in the database directly.
    /// </summary>
    public interface ICreateDriverCommand
    {
        int InsertDriver(DriverSystemEntity driverSystemEntity);
    }
}
