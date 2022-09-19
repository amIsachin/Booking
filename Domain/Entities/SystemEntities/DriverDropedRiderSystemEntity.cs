namespace Domain.Entities.SystemEntities
{
    internal class DriverDropedRiderSystemEntity
    {
        public uint Droped_ID { get; set; }
        public uint DriverID { get; set; }
        public uint RiderID { get; set; }

        public DriverSystemEntity DriverSystemEntity { get; set; }
        public RiderSystemEntity RiderSystemEntity { get; set; }
    }
}
