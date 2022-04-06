using System.ComponentModel.DataAnnotations;

namespace RmsWebApi.Data
{
    public class UserInfoDomain

    {
        public UserInfoDomain()
        {
            userResumeDomains = new List<UserResumeDomain>();
        }
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserRole { get; set; }
        [Required]
        public string UserEmail { get; set; }
        public List<UserResumeDomain> userResumeDomains { get; set; }
    }
}
