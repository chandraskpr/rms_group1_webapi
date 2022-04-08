using RMS.Domain.ResumeDomain;
using RmsWebApi.RMS_DB;

namespace RmsWebApi.Data
{
    public class ResumeDomain
    {
        public ResumeDomain()
        {
            SkillList = new List<Skills>();
            aboutMes = new List<AboutMes>();
            achievements = new List<Achievements>();
            educationDetails = new List<EducationDetails>();
            memberships = new List<Memberships>();
            myDetails = new List<MyDetails>();
            workExperienceDomains = new List<WorkExperienceDomain>();
        }
        public int ResumeId { get; set; }
        public string ResumeTitle { get; set; }
        public string ResumeStatus { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }
        public List<Skills> SkillList { get; set; }
        public List<AboutMes> aboutMes { get; set; }
        public List<Achievements> achievements { get; set; }
        public List<EducationDetails> educationDetails { get; set; }
        public List<Memberships> memberships { get; set; }
        public List<MyDetails> myDetails { get; set; }
        public List<WorkExperienceDomain> workExperienceDomains { get; set; }
    }
}
