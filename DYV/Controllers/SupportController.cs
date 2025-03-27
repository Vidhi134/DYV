using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult FAQs()
        {
            return View();
        }
        public IActionResult ShippingAndReturn()
        {
            return View();
        }
        public IActionResult TermsAndCondition()
        {
            return View();
        }
    }
    
}
