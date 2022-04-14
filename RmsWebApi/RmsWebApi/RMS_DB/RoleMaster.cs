using System;
using System.Collections.Generic;

namespace RmsWebApi.RMS_DB
{
    public partial class RoleMaster
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDesc { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
