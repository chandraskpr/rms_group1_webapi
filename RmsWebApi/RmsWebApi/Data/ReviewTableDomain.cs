namespace RmsWebApi.Data
{
    public class ReviewTableDomain
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public int ReviewId { get; set; }
        public int? ResumeId { get; set; }
        public string? ReviewComment { get; set; }
        public int? ReviewerId { get; set; }
    }
}
