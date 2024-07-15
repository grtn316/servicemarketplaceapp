using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class ServiceAvailability
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public ServiceAvailability(int id, int serviceId, DateTime startTime, DateTime endTime)
        {
            Id = id;
            ServiceId = serviceId;
            StartTime = startTime;
            EndTime = endTime;
            Duration = this.EndTime - this.StartTime;
        }
        public void UpdateDuration() {
            this.Duration = this.EndTime - this.StartTime;
        }
        public ServiceAvailability() { }

    }
}
