using DYV.Models;
using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
{
    public class AccountController : Controller
    {
        private static List<User> users = new List<User>(); // Temporary storage (replace with DB later)

        // Display the Sign-Up Form
        public IActionResult SignUp()
        {
            return View();
        }

        // Handle the Sign-Up Form Submission
        [HttpPost]
        public IActionResult SignUp(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model); // Add user to list (replace with DB logic)
                return RedirectToAction("Login"); // Redirect to Login Page
            }
            return View(model);
        }

        // Login Page
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
