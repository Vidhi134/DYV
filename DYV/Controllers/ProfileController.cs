using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
