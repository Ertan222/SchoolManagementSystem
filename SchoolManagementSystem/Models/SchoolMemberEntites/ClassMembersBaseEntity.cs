using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SchoolManagementSystem.Models.SchoolMemberEntites
{
    public class ClassMembersBaseEntity
    {
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Class"), Range(1, 99, ErrorMessage = "{0} must be chosen")]
        public int ClasssId { get; set; }
        public Classs Classs { get; set; }
        [Required(ErrorMessage = "{0} must be filled."), Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Date is not in corect form")]
        public DateTime JoinDate { get; set; }

    }
}
