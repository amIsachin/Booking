namespace Domain.Entities.SystemEntities
{
    public sealed class DriverDropedRiderSystemEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public uint Droped_ID { get; set; }
        public uint DriverID { get; set; }
        public uint RiderID { get; set; }

        public DriverSystemEntity DriverSystemEntity { get; set; }
        public RiderSystemEntity RiderSystemEntity { get; set; }
    }
}
