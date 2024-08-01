using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities {
    public class ServiceCalendar {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        public List<TimeSlot> TimeSlots = new List<TimeSlot>();
        
        public ServiceCalendar() { }
        public void SetAvailability(ServiceAvailability availability) {
            CreateTimeSlots(availability);
        }
        private void CreateTimeSlots(ServiceAvailability availability) {
            DateOnly dateIterator = availability.StartDate;
            TimeOnly timeIterator = availability.StartTime;
            TimeSpan duration = availability.Duration;

            while (dateIterator <= availability.EndDate) {
                while ((timeIterator.AddMinutes(duration.TotalMinutes)) <= availability.EndTime) {
                    if (availability.DaysAvailable.Contains(dateIterator.Day.ToString())) {
                        TimeSlot timeSlot = new TimeSlot(dateIterator, timeIterator, timeIterator.AddMinutes(duration.TotalMinutes), availability.Duration);
                        this.TimeSlots.Add(timeSlot);
                    }
                }
                dateIterator.AddDays(1);
            }
        }
        private void ClearTimeSlots() {
            TimeSlots.Clear();
        }

    }
}
