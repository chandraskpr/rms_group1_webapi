namespace RmsWebApi.Data
{
    public class DesignationMasterDomain
    {
        public int DesignationId { get; set; }
        public string? DesignationName { get; set; }
        public string? DesignationDescription { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
