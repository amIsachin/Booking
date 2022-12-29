namespace Domain.Entities.Global_Entities
{
    public class DriverDropedRiderGlobalEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public uint Droped_ID { get; set; }
        public uint DriverID { get; set; }
        public uint RiderID { get; set; }

        public DriverGlobalEntity Driver { get; set; }
        public RiderGlobalEntity Rider { get; set; }
    }
}
