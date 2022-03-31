using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class EducationDetail
    {
        public int EducationId { get; set; }
        public string CourseName { get; set; } = null!;
        public string Specialization { get; set; } = null!;
        public string InstituteName { get; set; } = null!;
        public int PassingYear { get; set; }
        public double Marks { get; set; }
        public string? University { get; set; }
        public int? ResumeId { get; set; }

        public virtual Resume? Resume { get; set; }
    }
}
