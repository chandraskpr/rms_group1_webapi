using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RmsWebApi.Data
{
    public class UserNotificationsDomain
    {   
        
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string NotificationDescription { get; set; } = null!;
        public byte[] CreationDate { get; set; } = null!;
        public string? NotificationState { get; set; }




    }
}

