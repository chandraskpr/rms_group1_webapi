using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class DesginationMasterDomain
    {
        public int DesginationId { get; set; }
        public string? DesginationName { get; set; }
        public string? DesginationDescription { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
