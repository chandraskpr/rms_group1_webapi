namespace RmsWebApi.Data
{
    public class ReviewTableDomain
    {
        public int ReviewId { get; set; }
        public int? ResumeId { get; set; }
        public string? ReviewComment { get; set; }
        public int? ReviewerId { get; set; }
    }
}
