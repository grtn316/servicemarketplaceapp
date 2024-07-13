namespace ServiceMarketplace.Entities
{
    public class Review
    {
        private int Id {  get; set; }
        private int ParentId { get; set; }
        private int CustomerID { get; set; }
        private int BusinessID { get; set; }
        private DateTime TimeStamp { get; set; }
        private float Rating { get; set; }
        private string Comment { get; set; }

        public Review(int id, int parentId, int customerID, int businessID, DateTime timeStamp, float rating, string comment)
        {
            this.Id = id;
            this.ParentId = parentId;
            this.CustomerID = customerID;
            this.BusinessID = businessID;
            this.TimeStamp = timeStamp;
            this.Rating = rating;
            this.Comment = comment;
        }
    }
}
