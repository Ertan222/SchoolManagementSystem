using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class StudentHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
