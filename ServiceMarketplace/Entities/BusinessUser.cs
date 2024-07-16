
using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class BusinessUser : User
    {
        public BusinessUser(int id, AccountType accountType, string username, string password, string email, string firstName, string lastName, string phoneNumber) : base(id, accountType, username, password, email, firstName, lastName, phoneNumber)
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

        [Required]
        public bool IsAdmin { get; set; } = false;
        [Required]
        public int BusinessId;

        public BusinessUser()
        {
        }
    }


}
