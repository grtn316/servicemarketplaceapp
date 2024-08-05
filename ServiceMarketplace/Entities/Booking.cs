using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        //public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        //public TimeSpan Duration { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public string CustomerId { get; set; }
        [Required]
        public int TimeSlotId { get; set; }
        //[Required]
        //public int BusinessID { get; set; }
        //public float Cost { get; set; }
        public BookingStatus Status { get; set; }

        public TimeSlot? TimeSlot { get; set; }

        public Booking(DateTime startTime, DateTime endTime, int serviceId, string customerId, int timeSlotId, int businessId, float cost, BookingStatus status)
        {

            //this.StartTime = startTime;
            //this.EndTime = endTime;
            //this.Duration = this.EndTime - this.StartTime;
            this.ServiceId = serviceId;
            this.CustomerId = customerId;
            this.TimeSlotId = timeSlotId;
            //this.BusinessID = businessID;
            //this.Cost = cost;
            this.Status = status;
        }

        public Booking()
        {
        }

    }
}