using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities {
    public class TimeSlot {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        //public string CustomerId { get; set; }
        //public bool IsAvailable { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public TimeSlot(DateTime startTime, DateTime endTime) {
            //IsAvailable = true;
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSlot() { }
        public void MakeAvailable() {
            //IsAvailable = true;
            //CustomerId = String.Empty;
        }
        public void MakeNotAvailable() {
            //IsAvailable = false;
        }
        public void MakeNotAvailable(string customerID) {
            //IsAvailable = false;
            //CustomerId = customerID;
        }
    }
}
