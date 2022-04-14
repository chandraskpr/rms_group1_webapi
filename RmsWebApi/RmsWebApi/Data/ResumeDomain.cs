
using RMS.Domain.ResumeDomain;
namespace RmsWebApi.Data
{
    public class ResumeDomain
    {   
        public ResumeDomain()
        {
            SkillList = new List<SkillsDomain>();
            aboutMe = new List<AboutMeDomain>();
            //eduBackground = new List<EducationalBackgroundDomain>();
            educationDetails = new List<EducationDetailsDomain>();
            achivements = new List<AchievementsDomain>();
            memberships = new List<MembershipsDomain>();
            myDetails = new List<MyDetailsDomain>();
            workExperience = new List<WorkExperienceDomain>();
            userResumes = new List<UserResumeDomain>();
            certifications = new List<CertificationDomain>();
            trainings = new List<TrainingDomain>();
        }
        public int ResumeId { get; set; }
        public string ResumeTitle { get; set; } 
        public string ResumeStatus { get; set; } 
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }

        public List<SkillsDomain> SkillList { get; set; }
        public List<AboutMeDomain>  aboutMe { get; set; }
        //public List<EducationalBackgroundDomain> eduBackground { get; set; }
        public List<EducationDetailsDomain> educationDetails { get; set; }
        public List<AchievementsDomain> achivements { get; set; }
        public List<MembershipsDomain> memberships { get; set; }
        public List<MyDetailsDomain> myDetails { get; set; }  
        public List<WorkExperienceDomain> workExperience { get; set; }       

        public List<UserResumeDomain> userResumes { get; set; }

        public List<CertificationDomain> certifications { get; set; }

        public List<TrainingDomain> trainings { get; set; }

    }
}
