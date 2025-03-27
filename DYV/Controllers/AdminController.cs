using DYV.Models;
using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@store.com" && password == "admin123")
            {
                return RedirectToAction("Dashboard"); // Redirect to Admin Dashboard
            }
            ViewBag.ErrorMessage = "Invalid credentials. Please try again.";
            return View();
        }

        public IActionResult Dashboard()
        {
            return View(); // Create a dashboard page later
        }
        public IActionResult Product()
        {
            // Sample Product List (Replace with DB data)


            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Coupon()

        {
            return View();
        }
        public IActionResult Orders()
        {
            return View();
        }
        }


    }
