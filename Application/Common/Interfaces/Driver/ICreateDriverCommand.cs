using Domain.Entities.SystemEntities;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Driver
{
    /// <summary>
    /// This *(ICreateDriverCommand) interface is main *(service) which saves the driver data in the database directly.
    /// </summary>
    public interface ICreateDriverCommand
    {
        Task<int> InsertDriver(DriverSystemEntity driverSystemEntity);
    }
}
