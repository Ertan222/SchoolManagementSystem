using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagementSystem.Models
{
    public class Markk
    {
        [Key]
        public int MarkID { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Student")]
        public int HumanId { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Mark Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Date is not in corect form")]
        public string Emaill { get; set; }
        public DateTime AddedTime { get; set; }
        [NotMapped]
        public Student Student { get; set; }

    }
}
