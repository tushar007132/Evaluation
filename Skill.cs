using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluationApp.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public string Role { get; set; }
        public int Experience { get; set; }
        public string PostalCode { get; set; }


        // For Foreign Key Implementation 


        [ForeignKey("EmpId")]
        public virtual Employee Employees { get; set; }

        [Display(Name = "Employee")]
        public virtual int EmpId { get; set; }
    }
}
