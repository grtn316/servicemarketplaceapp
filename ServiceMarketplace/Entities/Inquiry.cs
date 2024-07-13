namespace ServiceMarketplace.Entities
{
    public class Inquiry
    {
        private int Id {  get; set; }
        private int CustomerId {  get; set; }
        private int BusinessId { get; set; }
        private int ParentInquiriesId { get; set; }
        private string Response {  get; set; }
        private DateTime TimeStamp { get; set; }
        
        public Inquiry(int id, int customerId, int businessId, int parentInquiriesId, string response, DateTime timeStamp)
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.BusinessId = businessId;
            this.ParentInquiriesId = parentInquiriesId;
            this.Response = response;
            this.TimeStamp = timeStamp;
        }
    }
}
