using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Models.İnterfaces;

namespace SchoolManagementSystem.Models
{
    public class Parentt : IHuman
    {
        [Key]
        public int HumanId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "First and Second Name"), StringLength(50, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string FirstandSecondName { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Lastname"), StringLength(50, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Date is not in corect form")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Address"), StringLength(50, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string Address { get; set; }
        public int StudentId { get; set; }
        public int GenderId { get; set; }
        public Student Student { get; set; }
    }
}
