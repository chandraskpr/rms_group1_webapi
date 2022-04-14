using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class ProjectMaster
    {
        public int ProjectId { get; set; }
        public string? ProjectName { get; set; }
        public string? ProjectDescription { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
