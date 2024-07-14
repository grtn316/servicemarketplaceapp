using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class Business
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
        public PhoneNumber PhoneNumber { get; set; }

        public Business(string businessId, string name, string description, Address address, PhoneNumber phoneNumber)
        {
            Id = businessId;
            Name = name;
            Description = description;
            Address = address;
            PhoneNumber = phoneNumber;
        }
        public Business()
        {
            Id = string.Empty;
            Name = string.Empty;
            Description = string.Empty;
            Address = new Address();
            PhoneNumber = new PhoneNumber();
        }

    }
}
