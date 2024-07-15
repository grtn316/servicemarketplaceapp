using Microsoft.EntityFrameworkCore;

namespace ServiceMarketplace.Entities
{
    [Owned]
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        //public Address(string street, string city, string state, string zipcode)
        //{
        //    this.Street = street;
        //    this.City = city;
        //    this.State = state;
        //    this.Zipcode = zipcode;
        //}

        //public Address()
        //{
        //    Street = string.Empty;
        //    City = string.Empty;
        //    State = string.Empty;
        //    Zipcode = string.Empty;
        //}
    }
}
