using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.ViewModel;

namespace SchoolManagementSystem.Controllers;
[Authorize(Roles = "Admin,Supervisor")]
public class TeacherController : Controller
{

    private readonly SchoolManagementSystemDbContext _context;

    public TeacherController(SchoolManagementSystemDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> GetAllTeachers()
    {
        List<Teacher> allTeachers = await _context.Teachers.Include(a => a.Classs).Include(a => a.Gender).ToListAsync();

        return View(allTeachers);
    }
    public async Task<IActionResult> AddTeacher()
    {
        TeacherViewModel teacherViewModel = new();
        teacherViewModel.Teacher = new Teacher();
        teacherViewModel.GenderList = await _context.Genders.ToListAsync();
        teacherViewModel.ClasssList = await _context.Classses.ToListAsync();
        return View(teacherViewModel);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddTeacher([Bind("FirstandSecondName", "Lastname", "GenderId", "DOB", "ClasssId", "PhoneNumber", "JoinDate", "Email,Address")] Teacher teacher)
    {
        if (ModelState.IsValid)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllTeachers", "Teacher");
        }

        TeacherViewModel teacherViewModel = new();
        teacherViewModel.Teacher = teacher;
        teacherViewModel.GenderList = await _context.Genders.ToListAsync();
        teacherViewModel.ClasssList = await _context.Classses.ToListAsync();
        return View(teacherViewModel);
    }

    public async Task<IActionResult> GetTeacherInfo(int id)
    {
        Teacher selectedInfoTeacher = await _context.Teachers.Include(a => a.Gender).Include(a => a.Classs).FirstOrDefaultAsync(a => a.HumanId == id);
        return View(selectedInfoTeacher);
    }

    public async Task<IActionResult> DeleteTeacher(int id)
    {
        Teacher deleteTeacher = await _context.Teachers.Include(a => a.Gender).Include(a => a.Classs).FirstOrDefaultAsync(a => a.HumanId == id);

        if (deleteTeacher == null)
        {
            return NotFound();
        }

        return View(deleteTeacher);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> RealDeleteTeacher(int id)
    {
        Teacher selectedDeleteTeacher = await _context.Teachers.FirstOrDefaultAsync(a => a.HumanId == id);
        _context.Teachers.Remove(selectedDeleteTeacher);
        await _context.SaveChangesAsync();
        return RedirectToAction("GetAllTeachers", "Teacher");
    }


    public async Task<IActionResult> EditTeacher(int id)
    {
        TeacherViewModel teacherViewModel = new();
        teacherViewModel.Teacher = await _context.Teachers.FirstOrDefaultAsync(a => a.HumanId == id);
        teacherViewModel.GenderList = await _context.Genders.ToListAsync();
        teacherViewModel.ClasssList = await _context.Classses.ToListAsync();

        if (teacherViewModel == null)
        {
            return NotFound();
        }
        return View(teacherViewModel);

    }


    [HttpPost]
    [ValidateAntiForgeryToken]

    public async Task<IActionResult> EditTeacher(int id, [Bind("FirstandSecondName", "Lastname", "GenderId", "DOB", "ClasssId", "PhoneNumber", "JoinDate", "Email,Address")] Teacher teacher)
    {
        if (ModelState.IsValid)
        {
            teacher.HumanId = id;
            _context.Teachers.Update(teacher);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetAllTeachers", "Teacher");
        }


        TeacherViewModel teacherViewModel = new();
        teacherViewModel.Teacher = teacher;
        teacherViewModel.GenderList = await _context.Genders.ToListAsync();
        teacherViewModel.ClasssList = await _context.Classses.ToListAsync();
        return View(teacherViewModel);

    }



}
