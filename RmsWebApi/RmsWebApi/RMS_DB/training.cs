using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class training
    {
        public int? ResumeId { get; set; }
        public int TrainingId { get; set; }
        public string? Trainingname { get; set; }

        public virtual Resume? Resume { get; set; }
    }
}