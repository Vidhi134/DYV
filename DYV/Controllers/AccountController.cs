using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [AllowAnonymous]  // Anyone can access Login page
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]  // Anyone can access Register page
    public IActionResult SignUp()
    {
        return View();
    }
    
        [HttpGet] // Ensure this is a GET request
        public IActionResult ForgotPassword()
        {
            return View();
        }
    


    [Authorize]  // Requires login
    public IActionResult Profile()
    {
        return View();
    }
    public IActionResult Wishlist()
    {
        return View();
    }
}
