using System.ComponentModel.DataAnnotations;

namespace RMS.Domain.ResumeDomain
{
    public class MyDetails
    {
        public byte[] ProfilePicture { get; set; }  
        public double? TotalExp { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}