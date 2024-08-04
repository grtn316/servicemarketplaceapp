using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class ServiceAvailability
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        public string DaysAvailable { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public ServiceAvailability(int id, int serviceId, string daysAvailable, DateOnly startDate, DateOnly endDate, TimeOnly startTime, TimeOnly endTime)
        {
            DaysAvailable = "";

            Id = id;
            ServiceId = serviceId;

            foreach (var day in daysAvailable)
            {
                if (!DaysAvailable.Contains(day)) { DaysAvailable.Append(day); }
            }

            StartDate = startDate;
            EndDate = endDate;
            StartTime = startTime;
            EndTime = endTime;
            Duration = this.EndTime - this.StartTime;
        }
        public void UpdateDuration()
        {
            this.Duration = this.EndTime - this.StartTime;
        }
        public ServiceAvailability()
        {
            DaysAvailable = "";
        }

    }
}
