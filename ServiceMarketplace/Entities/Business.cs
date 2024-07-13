namespace ServiceMarketplace.Entities
{
    public class Business
    {
        private string BusinessId { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private Address Address { get; set; }
        private PhoneNumber PhoneNumber { get; set; }

        public Business(string businessId, string name, string description, Address address, PhoneNumber phoneNumber)
        {
            BusinessId = businessId;
            Name = name;
            Description = description;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
