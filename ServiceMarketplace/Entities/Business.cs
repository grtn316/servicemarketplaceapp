using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Business
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public Business(int businessId, string name, string description, Address address, string phoneNumber)
        {
            Id = businessId;
            Name = name;
            Description = description;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public Business()
        {
            Name = string.Empty;
            Description = string.Empty;
            PhoneNumber= string.Empty;
        }

    }
}
