using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class MyDetail
    {
        public int UserdetailsId { get; set; }
        public int? ResumeId { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public double? TotalExp { get; set; }
        public string Name { get; set; } = null!;
        public string Role { get; set; } = null!;

        public virtual Resume? Resume { get; set; }
    }
}
