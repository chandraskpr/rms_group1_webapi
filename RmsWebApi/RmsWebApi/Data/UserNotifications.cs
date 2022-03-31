using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Domain.UserDomain
{
    public class UserNotifications
    {   
        [Key]
        public int UserNotificationsId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public byte NotificationStatus { get; set; }


       
        
    }
}

