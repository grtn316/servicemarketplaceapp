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
        public string Coordinate { get; set; } = string.Empty;
    }
}
