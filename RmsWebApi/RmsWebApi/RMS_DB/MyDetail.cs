using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class MyDetail
    {
        public int UserdetailsId { get; set; }
        public int? ResumeId { get; set; }
        public string? ProfilePicture { get; set; }
        public double? TotalExp { get; set; }

        public virtual Resume? Resume { get; set; }
    }
}
