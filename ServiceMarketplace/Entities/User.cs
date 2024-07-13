namespace ServiceMarketplace.Entities
{
    public class User
    {
        protected int Id { get; set; }
        protected Type AccountType { get; set; }
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string Email { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string PhoneNumber { get; set; }

        public User(int id, Type accountType, string username, string password, string email, string firstName, string lastName, string phoneNumber)
        {
            this.Id = id;
            this.AccountType = accountType;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }
    }
}