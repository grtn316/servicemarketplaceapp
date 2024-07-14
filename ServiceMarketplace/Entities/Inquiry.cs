using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Inquiry
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        public int CustomerId {  get; set; }
        [Required]
        public int BusinessId { get; set; }
        [Required]
        public int ParentInquiriesId { get; set; } = 0;
        public string Response {  get; set; }
        [Required]
        public DateTime TimeStamp { get; set; } = DateTime.Now;


        public Inquiry(int id, int customerId, int businessId, int parentInquiriesId, string response, DateTime timeStamp)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.BusinessId = businessId;
            this.ParentInquiriesId = parentInquiriesId;
            this.Response = response;
            this.TimeStamp = timeStamp;
        }
        public Inquiry()
        {
            ParentInquiriesId = 0;
            TimeStamp = DateTime.Now;
            Response = string.Empty;
        }
    }
}
