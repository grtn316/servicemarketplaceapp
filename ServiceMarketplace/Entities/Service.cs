using System.ComponentModel.DataAnnotations;

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

        public Service(int id, int businessId, string serviceName, string description, float price, TimeSpan duration)
        {
            this.Id = id;
            this.BusinessId = businessId;
            this.ServiceName = serviceName;
            this.Description = description;
            this.Price = price;
            this.Duration = duration;
            this.Rating = 0;
            this.Reviews = new List<Review>();
            //this.ServiceCalendar = new ServiceCalendar();
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
