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
        #region InitializedDriverDataBaseInstance
        private readonly ApplicationDbContext _driverCommand;
        public CreateDriverCommand(ApplicationDbContext driverCommand)
        {
            _driverCommand = driverCommand;
        } 
        #endregion

        /// <summary>
        /// this method save the new driver in the database.
        /// if the driver inserted successfully then this method will be return 1, else return -1 if driver is not inserted.
        /// </summary>
        /// <param name="driverSystemEntity"></param>
        /// <returns></returns>
        public async Task<int> InsertDriver(DriverSystemEntity driverSystemEntity)
        {

            driverSystemEntity.Created = TimeManagement.Instance.DateTimeNow();
            // this line will be remove when the authentication functionality done.
            driverSystemEntity.CreatedBy = "UnKnown";

            driverSystemEntity.LastModified = TimeManagement.Instance.LastModified();
            // this line will be remove when the authentication functionality done.
            driverSystemEntity.LastModifiedBy = "UnKnown";

            // this line will be remove when the image uploading functionality done.
            driverSystemEntity.ImageUrl = "Functionality not implemented";
            // this line will be remove when the driving licence functionality done.
            driverSystemEntity.DrivingLicence = "Functionality not implemented";

            try
            {
                await _driverCommand.Drivers.AddAsync(driverSystemEntity);
                int isInserted = await _driverCommand.SaveChangesAsync();

                // driver inserted successfully return 1. otherwise return -1.
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