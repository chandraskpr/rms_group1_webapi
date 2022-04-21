using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class Skill
    {
        public int SkillId { get; set; }
        public int? ResumeId { get; set; }
        public string Category { get; set; } = null!;
        public string? SkillName { get; set; }
        public virtual Resume? Resume { get; set; }
    }
}
