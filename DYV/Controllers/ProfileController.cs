using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
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
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
