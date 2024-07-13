namespace ServiceMarketplace.Entities
{
    public class Service
    {
        private int Id {  get; set; }
        private int BusinessId {  get; set; }
        private string ServiceName {  get; set; }
        private string Description {  get; set; }
        private float Price { get; set; }
        private int Duration { get; set; } // Needs to change to a time format.
        private float Rating { get; set; }
        private List<Review> Reviews { get; set; }

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
        public void addReview(Review review)
        {
            this.Reviews.Add(review);
        }
        private void UpdateRating()
        {

        }
    }
}
