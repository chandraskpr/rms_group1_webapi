using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class Resume
    {
        public Resume()
        {
            AboutMes = new HashSet<AboutMe>();
            Achievements = new HashSet<Achievement>();
            EducationDetails = new HashSet<EducationDetail>();
            Memberships = new HashSet<Membership>();
            MyDetails = new HashSet<MyDetail>();
            Skills = new HashSet<Skill>();
            UserResumes = new HashSet<UserResume>();
            WorkExperiences = new HashSet<WorkExperience>();
        }

        public int ResumeId { get; set; }
        public string ResumeTitle { get; set; } = null!;
        public string ResumeStatus { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }

        public virtual ICollection<AboutMe> AboutMes { get; set; }
        public virtual ICollection<Achievement> Achievements { get; set; }
        public virtual ICollection<EducationDetail> EducationDetails { get; set; }
        public virtual ICollection<Membership> Memberships { get; set; }
        public virtual ICollection<MyDetail> MyDetails { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<UserResume> UserResumes { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
