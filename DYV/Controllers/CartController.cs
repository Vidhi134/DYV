using DYV.Models;
using Microsoft.AspNetCore.Mvc;

namespace DYV.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddToCart()
        {
            var cartItems = new List<CartItem>
        {
            new CartItem { Id = 1, Name = "LCD Monitor", ImageUrl = "/images/lcd-monitor.jpg", Price = 650, Quantity = 1 },
            new CartItem { Id = 2, Name = "H1 Gamepad", ImageUrl = "/images/gamepad.jpg", Price = 550, Quantity = 2 }
        };

            return View(cartItems);

        }
    }
}
