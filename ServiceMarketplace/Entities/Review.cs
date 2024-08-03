using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Review
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int ParentReviewId { get; set; }
        [Required]
        public string CustomerId { get; set; }
        [Required]
        public int ServiceId { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public float Rating { get; set; }
        public string Comment { get; set; }

        public Review(int id, int parentReviewId, string customerID, int businessID, DateTime timeStamp, float rating, string comment)
        {
            this.Id = id;
            this.ParentReviewId = parentReviewId;
            this.CustomerId = customerID;
            this.ServiceId = businessID;
            this.TimeStamp = timeStamp;
            this.Rating = rating;
            this.Comment = comment;
        }

        public Review()
        {
            Comment = string.Empty;
        }
    }
}
