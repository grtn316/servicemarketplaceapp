using System.ComponentModel.DataAnnotations;
using System.Net;
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
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public User(AccountType accountType, string firstName, string lastName, string address, string city, string state, string zipcode, string phoneNumber)
        {
            //this.Id = id;
            this.AccountType = accountType;
            //this.Username = username;
            //this.Password = password;
            //this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipcode;
            this.PhoneNumber = phoneNumber;
        }

        public User() {
            AccountType = AccountType.Standard;
            //Username = string.Empty;
            //Password = string.Empty;
            //Email = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
            PhoneNumber = string.Empty;
        }
    }

    public class RegisterUser
    {
        public AccountType AccountType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}