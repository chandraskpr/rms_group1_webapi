using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class Certification
    {
        public int? ResumeId { get; set; }
        public int CertificationId { get; set; }
        public string? CertificationName { get; set; }

        public virtual Resume? Resume { get; set; }
    }
}
