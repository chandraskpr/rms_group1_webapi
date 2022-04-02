namespace RmsWebApi.Data
{
    public class ResumeDomain
    {
        public int ResumeId { get; set; }
        public string ResumeTitle { get; set; } 
        public string ResumeStatus { get; set; } 
        public DateTime CreationDate { get; set; }
        public DateTime UpdationDate { get; set; }
    }
}
