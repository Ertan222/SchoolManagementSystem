using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.ViewModel
{
    public class TeacherViewModel
    {
        public Teacher Teacher { get; set; }
        public List<Gender> GenderList { get; set; }
        public List<Classs> ClasssList { get; set; }

    }
}
