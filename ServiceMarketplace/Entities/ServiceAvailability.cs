namespace ServiceMarketplace.Entities
{
    public class ServiceAvailability
    {
        private int Id {  get; set; }
        private int ServiceId { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public ServiceAvailability(int id, int serviceId, DateTime startTime, DateTime endTime)
        {
            Id = id;
            ServiceId = serviceId;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
