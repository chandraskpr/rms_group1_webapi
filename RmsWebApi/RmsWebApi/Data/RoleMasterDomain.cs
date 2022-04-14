namespace RmsWebApi.Data
{
    public class RoleMasterDomain
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
