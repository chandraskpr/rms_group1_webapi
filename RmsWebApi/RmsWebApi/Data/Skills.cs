using System.ComponentModel.DataAnnotations;

namespace RMS.Domain.ResumeDomain
{
    public class Skills
    {
        public string? SkillName { get; set; }
        public string Category { get; set; }
    }
}