using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.ViewModel;

namespace SchoolManagementSystem.Controllers
{
    [Authorize(Roles = "Teacher,Admin")]
    public class StudentController : Controller
    {
        private readonly SchoolManagementSystemDbContext _context;

        public StudentController(SchoolManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> GetAllStudents()
        {
            List<Student> allStudents = await _context.Students.Include(a => a.Classs).Include(a => a.Gender).ToListAsync();

            return View(allStudents);
        }
        public async Task<IActionResult> AddStudent()
        {
            StudentViewModel studentViewModel = new();
            studentViewModel.Student = new Student();
            studentViewModel.GenderList = await _context.Genders.ToListAsync();
            studentViewModel.ClasssList = await _context.Classses.ToListAsync();
            return View(studentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStudent([Bind("FirstandSecondName", "Lastname", "GenderId", "DOB", "ClasssId", "PhoneNumber", "JoinDate", "Email,Address")] Student student)
        {
            if (ModelState.IsValid)
            {
                await _context.Students.AddAsync(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetAllStudents", "Student");
            }

            StudentViewModel studentViewModel = new();
            studentViewModel.Student = student;
            studentViewModel.GenderList = await _context.Genders.ToListAsync();
            studentViewModel.ClasssList = await _context.Classses.ToListAsync();
            return View(studentViewModel);
        }



        public async Task<IActionResult> GetStudentInfo(int id)
        {
            Student selectedInfoStudent = await _context.Students.Include(a => a.Gender).Include(a => a.Classs).FirstOrDefaultAsync(a => a.HumanId == id);
            
            if (selectedInfoStudent == null)
            {
                return View("NotFound");
                 
            }
            return View(selectedInfoStudent);
        }


        public async Task<IActionResult> DeleteStudent(int id)
        {
            Student deleteStudent = await _context.Students.Include(a => a.Gender).Include(a => a.Classs).FirstOrDefaultAsync(a => a.HumanId == id);

            if (deleteStudent == null)
            {
                return View("NotFound");
            }

            return View(deleteStudent);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RealDeleteStudent(int id)
        {
            Student selectedDeleteStudent = await _context.Students.FirstOrDefaultAsync(a => a.HumanId == id);
            _context.Students.Remove(selectedDeleteStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllStudents", "Student");
        }

        public async Task<IActionResult> EditStudent(int id)
        {
            StudentViewModel studentViewModel = new();
            studentViewModel.Student = await _context.Students.FirstOrDefaultAsync(a => a.HumanId == id);
            studentViewModel.GenderList = await _context.Genders.ToListAsync();
            studentViewModel.ClasssList = await _context.Classses.ToListAsync();

            if (studentViewModel == null)
            {
                return View("NotFound");
            }
            return View(studentViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> EditStudent(int id, [Bind("FirstandSecondName", "Lastname", "GenderId", "DOB", "ClasssId", "PhoneNumber", "JoinDate", "Email,Address")] Student student)
        {
            if (ModelState.IsValid)
            {
                student.HumanId = id;
                _context.Students.Update(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("GetAllStudents", "Student");
            }


            StudentViewModel studentViewModel = new();
            studentViewModel.Student = student;
            studentViewModel.GenderList = await _context.Genders.ToListAsync();
            studentViewModel.ClasssList = await _context.Classses.ToListAsync();
            return View(studentViewModel);

        }

    }
}
