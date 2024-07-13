namespace ServiceMarketplace.Entities
{
    public class Address
    {
        private string Street { get; set; }
        private string City { get; set; }
        private string State { get; set; }
        private string Zipcode { get; set; }
        public Address(string street, string city, string state, string zipcode)
        {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
        }
    }
}
