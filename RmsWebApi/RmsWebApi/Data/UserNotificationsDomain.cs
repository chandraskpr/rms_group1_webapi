using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rms.Domain.UserInfo
{
    public class UserNotificationsDomain
    {   
        [Key]
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string NotificationDescription { get; set; } = null!;
        public byte[] CreationDate { get; set; } = null!;
        public string? NotificationState { get; set; }




    }
}

