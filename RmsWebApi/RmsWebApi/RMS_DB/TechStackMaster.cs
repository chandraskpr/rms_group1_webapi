using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class TechStackMaster
    {
        public TechStackMaster()
        {
            TechStackValues = new HashSet<TechStackValue>();
        }

        public int TechStackId { get; set; }
        public string? Category { get; set; }

        public virtual ICollection<TechStackValue> TechStackValues { get; set; }
    }
}