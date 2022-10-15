using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.ViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Gender> GenderList { get; set; }
        public List<Classs> ClasssList { get; set; }

    }
}
