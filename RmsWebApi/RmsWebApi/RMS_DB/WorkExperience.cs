using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class WorkExperience
    {
        public int WorkExperienceId { get; set; }
        public int? ResumeId { get; set; }
        public string ClientDescription { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string ProjectName { get; set; } = null!;
        public string ProjectRole { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BusinessSolution { get; set; } = null!;
        public string TechnologyStack { get; set; } = null!;
        public string ProjectResponsibilities { get; set; } = null!;

        public virtual Resume? Resume { get; set; }
    }
}
