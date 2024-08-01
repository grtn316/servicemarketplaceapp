using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities {
    public class TimeSlot {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int CustomerID { get; set; }
        public bool IsAvailable { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public TimeSpan Duration { get; set; }

        public TimeSlot(DateOnly dateOnly, TimeOnly startTime, TimeOnly endTime, TimeSpan duration) {
            IsAvailable = true;

            Date = dateOnly;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
        }
        public void MakeAvailable() {
            IsAvailable = true;
            CustomerID = 0;
        }
        public void MakeNotAvailable() {
            IsAvailable = false;
        }
        public void MakeNotAvailable(int customerID) {
            IsAvailable = false;
            CustomerID = customerID;
        }
    }
}
