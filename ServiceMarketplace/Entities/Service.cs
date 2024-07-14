using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Service
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int BusinessId {  get; set; }
        [Required]
        public string ServiceName {  get; set; }
        public string Description {  get; set; }
        public float Price { get; set; }
        public int Duration { get; set; } // Needs to change to a time format.
        public float Rating { get; set; }
        public List<Review> Reviews { get; set; }

        public Service(int id, int businessId, string serviceName, string description, float price, int duration)
        {
            this.Id = id;
            this.BusinessId = businessId;
            this.ServiceName = serviceName;
            this.Description = description;
            this.Price = price;
            this.Duration = duration;
            this.Rating = 0;
            this.Reviews = new List<Review>();
        }

        public Service()
        {
            ServiceName = string.Empty;
            Description = string.Empty;
            Reviews = new List<Review>();
        }

        //These will be done in the Repository class
        //public void addReview(Review review)
        //{
        //    this.Reviews.Add(review);
        //}
        //private void UpdateRating()
        //{

        //}
    }
}
