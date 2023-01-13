using Application.Common.Interfaces.Driver;
using Application.Common.Logics;
using Domain.Entities.SystemEntities;
using Infrastructure.Persistence;
using System.Threading.Tasks;

namespace Application.Drivers.Commands.CreateDriver
{
    /// <summary>
    /// This *(CreateDriverCommand) class is main *(service) which saves the driver data in the database directly.
    /// </summary>
    public sealed class CreateDriverCommand : ICreateDriverCommand
    {
        private readonly ApplicationDbContext _driverCommand;
        public CreateDriverCommand(ApplicationDbContext driverCommand)
        {
            _driverCommand = driverCommand;
        }

        public async Task<int> InsertDriver(DriverSystemEntity driverSystemEntity)
        {
            driverSystemEntity.Created = TimeManagement.Instance.DateTimeNow();
            driverSystemEntity.CreatedBy = "UnKnown";

            driverSystemEntity.LastModified = TimeManagement.Instance.LastModified();
            driverSystemEntity.LastModifiedBy = "UnKnown";

            driverSystemEntity.ImageUrl = "Functionality not implemented";
            driverSystemEntity.DrivingLicence = "Functionality not implemented";


            try
            {
                await _driverCommand.Drivers.AddAsync(driverSystemEntity);
                int isInserted = await _driverCommand.SaveChangesAsync();

                if (isInserted > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}