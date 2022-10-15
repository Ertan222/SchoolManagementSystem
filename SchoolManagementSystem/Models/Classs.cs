using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Classs
    {
        [Key]
        public int ClasssId { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Class"), StringLength(3, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string ClasssName { get; set; }
    }
}