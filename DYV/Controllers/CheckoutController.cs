using DYV.Models;
using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            var checkoutModel = new CheckoutViewModel
            {
                CartTotal = 1750 // Example total, you should get this from the cart service
            };
            return View(checkoutModel);
        }

        [HttpPost]
        public IActionResult PlaceOrder(CheckoutViewModel model)
        {
            Console.WriteLine("PlaceOrder method called!"); // Debugging
            if (ModelState.IsValid)
            {
                // Simulate saving the order
                return RedirectToAction("OrderSuccess");
            }

            // If validation fails, reload the checkout page
            return View("Index", model);
        }

    }
}
