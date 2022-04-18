namespace RmsWebApi.Data
{
    public class TechStackValueDomain
    {
        public int ValueId { get; set; }
        public string? ValueName { get; set; }

        public int? TechStackId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
