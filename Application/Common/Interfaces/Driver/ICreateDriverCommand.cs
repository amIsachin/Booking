using Domain.Entities.SystemEntities;
using System.Threading.Tasks;

namespace Application.Common.Interfaces.Driver
{
    /// <summary>
    /// This *(ICreateDriverCommand) interface is main *(service) which saves the driver data in the database directly.
    /// </summary>
    public interface ICreateDriverCommand
    {
        /// <summary>
        /// this method save the new driver in the database.
        /// if the driver inserted successfully then this method will be return 1, else return -1 if driver is not inserted.
        /// </summary>
        /// <param name="driverSystemEntity"></param>
        /// <returns></returns>
        Task<int> InsertDriver(DriverSystemEntity driverSystemEntity);
    }
}
