namespace Domain.Entities.SystemEntities
{
    /// <summary>
    /// This entity is system entity please dont use for global application.
    /// this Enitty use only main service which store data in the database. not any other services.
    /// </summary>
    public sealed class DriverDropedRiderSystemEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Droped_ID { get; set; }
        public int DriverID { get; set; }
        public int RiderID { get; set; }

        public DriverSystemEntity Driver { get; set; }
        public RiderSystemEntity Rider { get; set; }
    }
}
