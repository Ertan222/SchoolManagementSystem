using System.ComponentModel.DataAnnotations;
using SchoolManagementSystem.Models.İnterfaces;
using SchoolManagementSystem.Models.SchoolMemberEntites;

namespace SchoolManagementSystem.Models
{
    public class Student : ClassMembersBaseEntity, IHuman
    {
        [Key]
        public int HumanId { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "First and second name"), StringLength(40, MinimumLength = 3, ErrorMessage = "{0} {2} - {1} needs to be in range .")]
        public string FirstandSecondName { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Lastname"), StringLength(30, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Address"), StringLength(500, MinimumLength = 2, ErrorMessage = "{0} {2} - {1} needs to be in range.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Date is not in corect form")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Gender"), Range(1, 99, ErrorMessage = "{0} must be chosen")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }


    }
}
