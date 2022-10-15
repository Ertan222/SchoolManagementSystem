using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Gender"), StringLength(60, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string GenderName { get; set; }
    }
}
