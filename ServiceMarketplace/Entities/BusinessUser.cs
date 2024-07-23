
using System.ComponentModel.DataAnnotations;

namespace ServiceMarketplace.Entities
{
    public class BusinessUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public bool IsAdmin { get; set; } = false;
        [Required]
        public int BusinessId;

        public BusinessUser()
        {
        }
    }


}
