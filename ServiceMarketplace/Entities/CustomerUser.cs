
namespace ServiceMarketplace.Entities
{
    public class CustomerUser : User
    {
        public List<Booking> Bookings;

        public CustomerUser(int id, AccountType accountType, string username, string password, string email, string firstName, string lastName, string phoneNumber) : base(id, accountType, username, password, email, firstName, lastName, phoneNumber)
        {
            this.Id = id;
            this.AccountType = accountType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Bookings = new List<Booking>();
        }

        public CustomerUser()
        {
            Bookings = new List<Booking>();
        }
    }
}
