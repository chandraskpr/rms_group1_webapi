using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RMS.Domain.ResumeDomain
{
    public class EducationDetails
    {
        [Key]
        public int EducationDetailsId { get; set; } 
        public string CourseName { get; set; }  
        public string Stream { get; set; }  
        public string InstitutionName { get; set; }
        public int PassingYear { get; set; }
        
        [Display(Name = "Percentage/CGPA")]
        public double Marks { get; set; }

        [Display(Name = "University/BOARD")]
        public string University { get; set; }

    }
}