using System.ComponentModel.DataAnnotations;



namespace RmsWebApi.Data
{
    public class UserInfoDomain

    {
       public UserInfoDomain()
        {
            //NotificationList = new List<UserNotificationsDomain>();
            userResumeList = new List<UserResumeDomain>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserRole { get; set; }
        [Required]
        public string UserEmail { get; set; }


        //public List<UserNotificationsDomain> NotificationList { get; set; }
        public List<UserResumeDomain> userResumeList { get; set; }
    }
}
