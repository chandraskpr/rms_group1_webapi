using System.ComponentModel.DataAnnotations;

namespace RmsWebApi.Data
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string Email { get; set; }
    }
}