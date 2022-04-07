using System;

namespace RMS.Domain.ResumeDomain
{
    public class WorkExperienceDomain
    {
        public string ClientDescription { get; set; }

        public string Country { get; set; }

        public string ProjectName { get; set; }

        public string ProjectRole { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string BusinessSolution { get; set; }

        public string TechnologyStack { get; set; }

        public string ProjectResponsibilities { get; set; }
    }
}