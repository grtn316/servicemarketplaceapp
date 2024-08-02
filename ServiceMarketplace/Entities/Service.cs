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
            //this.ServiceCalendar = new ServiceCalendar();

            TimeSlot slot = new TimeSlot(new DateOnly(2024, 8, 1), new TimeOnly(00, 30, 00), new TimeOnly(00, 00, 00), new TimeSpan(00, 30, 00));
            this.TimeSlots.Add(slot);
        }

        public Service()
        {
            ServiceName = string.Empty;
            Description = string.Empty;
            Reviews = new List<Review>();
            //ServiceCalendar = new ServiceCalendar();
        }
    }
}
