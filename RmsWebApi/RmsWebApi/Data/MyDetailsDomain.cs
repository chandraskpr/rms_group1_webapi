using System.ComponentModel.DataAnnotations;
namespace RMS.Domain.ResumeDomain
{
    public class MyDetailsDomain
    {
        public string ProfilePicture { get; set; }
        public float TotalExp { get; set; }

        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
