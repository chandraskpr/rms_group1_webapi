using System.ComponentModel.DataAnnotations;



namespace RmsWebApi.Data
{
    public class UserInfoDomain



    {
        public UserInfoDomain()
        {
            userResumeDomains = new List<UserResumeDomain>();
        }
        
        public int UserId { get; set; }
        
        public string UserName { get; set; }
        
        public string UserRole { get; set; }
       
        public string UserEmail { get; set; }
        public List<UserResumeDomain> userResumeDomains { get; set; }
    }
}


