using Microsoft.AspNetCore.Mvc;

namespace El_Tamayez.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult SaveEdit()
        {
            return View();
        }
    }
}
