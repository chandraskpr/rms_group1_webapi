using System.ComponentModel.DataAnnotations;

namespace RmsWebApi.Data
{
    public class UserInfoDomain
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserRole { get; set; }

        [Required]
        public string UserEmail { get; set; }
    }
}