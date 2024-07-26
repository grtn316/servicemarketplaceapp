using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public int BusinessID { get; set; }
        public float Cost { get; set; }
        public BookingStatus Status { get; set; }

        public Booking(DateTime startTime, DateTime endTime, int serviceId, string customerID, int businessID, float cost, BookingStatus status)
        {

            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = this.EndTime - this.StartTime;
            this.ServiceId = serviceId;
            this.CustomerID = customerID;
            this.BusinessID = businessID;
            this.Cost = cost;
            this.Status = status;
        }

        public Booking() {
        }
    }
}