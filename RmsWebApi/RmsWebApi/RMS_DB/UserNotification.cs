using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class UserNotification
    {
        public int NotificationId { get; set; }
        public int UserId { get; set; }
        public string NotificationDescription { get; set; } = null!;
        public byte[] CreationDate { get; set; } = null!;
        public string? NotificationState { get; set; }

        public virtual UserInfo User { get; set; } = null!;
    }
}
