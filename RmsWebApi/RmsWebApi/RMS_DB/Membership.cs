using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class Membership
    {
        public int MembershipId { get; set; }
        public int? ResumeId { get; set; }
        public string? MembershipName { get; set; }

        public virtual Resume? Resume { get; set; }
    }
}
