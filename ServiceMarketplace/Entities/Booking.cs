using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Required]
        public string ServiceId { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public string BusinessID { get; set; }
        public float Cost { get; set; }
        public BookingStatus Status { get; set; }

        public Booking(DateTime startTime, DateTime endTime, string serviceId, string customerID, string businessID, float cost, BookingStatus status)
        {

            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ServiceId = serviceId;
            this.CustomerID = customerID;
            this.BusinessID = businessID;
            this.Cost = cost;
            this.Status = status;
        }

        public Booking() {
            ServiceId = string.Empty;
            CustomerID = string.Empty;
            BusinessID = string.Empty;
        }
    }
}