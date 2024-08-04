using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ServiceMarketplace.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BusinessId { get; set; }
        [Required]
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public TimeSpan Duration { get; set; }
        public double Rating { get; set; }
        public List<Review> Reviews { get; set; }
        //public ServiceCalendar ServiceCalendar { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }

        public Service(int id, int businessId, string serviceName, string description, float price, TimeSpan duration)
        {
            this.TimeSlots = new List<TimeSlot>();

            this.Id = id;
            this.BusinessId = businessId;
            this.ServiceName = serviceName;
            this.Description = description;
            this.Price = price;
            this.Duration = duration;
            this.Rating = 0;
            this.Reviews = new List<Review>();

            DateTime startDateTime = new DateTime(2024, 8, 4, 9, 0, 0);
            DateTime endDateTime = new DateTime(2024, 8, 4, 17, 0, 0);
            TimeSlot slot = new TimeSlot(startDateTime, endDateTime);

            this.TimeSlots.Add(slot);
        }

        public Service()
        {
            ServiceName = string.Empty;
            Description = string.Empty;
            Reviews = new List<Review>();
        }

        public void CreateWeekLongTimeSlot()
        {
            this.TimeSlots.Clear();

            DateTime startDateTime = new DateTime(2024, 8, 4, 9, 0, 0);
            DateTime endDateTime = new DateTime(2024, 8, 4, 17, 0, 0);
            TimeSlot timeSlot = new TimeSlot(startDateTime, endDateTime);
            this.TimeSlots.Add(timeSlot);

            DateTime nextStart = startDateTime.AddDays(1);
            DateTime nextEnd = endDateTime.AddDays(1);
            TimeSlot nextTimeSlot = new TimeSlot(nextStart, nextEnd);
            this.TimeSlots.Add(nextTimeSlot);

            for (int i = 0; i < 6; i++)
            {
                nextStart = nextStart.AddDays(1);
                nextEnd = nextEnd.AddDays(1);

                nextTimeSlot = new TimeSlot(nextStart, nextEnd);
                this.TimeSlots.Add(nextTimeSlot);
            }
        }
    }
}
