using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class TechStackValue
    {
        public int ValueId { get; set; }
        public string? ValueName { get; set; }
        public int? TechStackId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TechStackMaster? TechStack { get; set; }
    }
}