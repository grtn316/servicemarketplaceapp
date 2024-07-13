namespace ServiceMarketplace.Entities
{
    public class Booking
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private string ServiceId { get; set; }
        private string CustomerID { get; set; }
        private string BusinessID { get; set; }
        private float Cost { get; set; }
        private BookingStatus Status { get; set; }

        public Booking(DateTime startTime, DateTime endTime, string serviceId, string customerID, string businessID, float cost, BookingStatus status)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ServiceId = serviceId;
            this.CustomerID = customerID;
            this.BusinessID = businessID;
            this.Cost = cost;
            this.Status = status;
        }
    }
}