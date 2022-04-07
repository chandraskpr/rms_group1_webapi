using RmsWebApi.RMS_DB;
using System;
using System.Collections.Generic;

namespace RmsWebApi.Data
{
    public partial class UserResumeDomains
    {
        public int UserResumeId { get; set; }
        public int? UserId { get; set; }
        public int ResumeId { get; set; }

        public virtual Resume Resume { get; set; } = null!;
        public virtual UserInfo? User { get; set; }
    }
}
