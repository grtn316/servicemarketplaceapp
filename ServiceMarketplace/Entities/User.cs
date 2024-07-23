using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ServiceMarketplace.Entities
{
    public class User: IdentityUser
    {
        //[Key]
        //public int Id { get; set; }
        [Required]
        public AccountType AccountType { get; set; }
        //[Required]
        //public string Username { get; set; }
        //[Required]
        //public string Password { get; set; }
        //[Required]
        //public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        //[Required]
        //public string PhoneNumber { get; set; }

        public User(int id, AccountType accountType, string username, string password, string email, string firstName, string lastName, string phoneNumber)
        {
            //this.Id = id;
            this.AccountType = accountType;
            //this.Username = username;
            //this.Password = password;
            //this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            //this.PhoneNumber = phoneNumber;
        }

        public User() {
            AccountType = AccountType.Standard;
            //Username = string.Empty;
            //Password = string.Empty;
            //Email = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            PhoneNumber = string.Empty;
        }
    }
}