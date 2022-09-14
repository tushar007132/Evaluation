using System.ComponentModel.DataAnnotations;

namespace EvaluationApp.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage ="please enter a valid First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Please enter a valid last name")] 
        public string LastName { get; set; }
        [Required(ErrorMessage ="Please enter a valid Password")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please enter a valid Land Line")]
        public string LandLine { get; set; }

        [Required(ErrorMessage ="Please Enter a valid cell number")]
        public string CellNumber { get; set; }

        [Required]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

    }
}
