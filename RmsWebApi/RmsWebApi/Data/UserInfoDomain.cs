
namespace RmsWebApi.Data
{
    public class UserInfoDomain

    {
       public UserInfoDomain()
        {
            NotificationList = new List<UserNotificationsDomain>();
            userResumeList = new List<UserResumeDomain>();
        }

     
        public int UserId { get; set; }
   
        public string UserName { get; set; }
  
        public string UserRole { get; set; }

        public string UserEmail { get; set; }


        public virtual List<UserNotificationsDomain> NotificationList { get; set; }
        public virtual List<UserResumeDomain> userResumeList { get; set; }
    }
}
