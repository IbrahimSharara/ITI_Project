using Microsoft.AspNetCore.Mvc;

namespace El_Tamayez.Controllers
{
    public class MyCoursesController : Controller
    {
        public IActionResult MyCourses()
        {
            return View();
        }
        public IActionResult MyGroup()
        {
            return View();
        }
    }
}
