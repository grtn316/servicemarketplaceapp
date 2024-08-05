
using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class BusinessUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BusinessId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public bool IsAdmin { get; set; } = false;
        public Business? businesses { get; set; }

        public BusinessUser()
        {
            UserId = String.Empty;
            IsAdmin = false;
            BusinessId = 0;

        }
    }


}
