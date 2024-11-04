using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System.Collections.Generic;
namespace OnlineStore.Controllers
    {
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Cedrick Brown R34 Western Boot", Price = 149.99m, Description = "Handmade in Nayarit, Mexico. The heart of World Class Artisan boot makers."},
            new Product { Id = 2, Name = "Alligator Black E22 Western Boot", Price = 129.99m, Description = "Limited Edition. Crafted with real alligator skin. Handmade in Nayarit, Mexico."},
            new Product { Id = 3, Name = "Blazing Red T14 Western Boot", Price = 129.99m, Description = "This BLAZING red will make your fit stand out in the perfect way! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Mocha Tan Y33 Western Boot", Price = 129.99m, Description = "The most perfect shade of Mocha to fit your every day wear! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Shimmer White W2 Western Boot", Price = 149.99m, Description = "White as the snow! This design was inspired by the leopart print. Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Modern Brown M1 Western Boot", Price = 119.99m, Description = "Classic every day style! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Sage Green Dragon Print D7 Western Boot", Price = 149.99m, Description = "Limited Edition. This velvet shade of green is an all time favorite! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Shimmering Barbie B4 Western Boot", Price = 89.99m, Description = "Barbie inspired! Shimmering heels and toe design to match any outfit! Handmade in Nayarit, Mexico"}
            new Product { Id = 3, Name = "Modern Black B1 Western Boot K", Price = 79.99m, Description = "The perfect every day look! Basic black design! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Blooming Blue H7 Western Boot", Price = 89.99m, Description = "Blue as the ocean! Dark navy vibes! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Mocha Tan Y33 Western Boot", Price = 69.99m, Description = "The most perfect shade of Mocha to fit your every day wear! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Blazing Brown L8 Western Boot", Price = 89.99m, Description = "A deeper brown for your birthday parties! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Black Brown BB1 Western Boot", Price = 149.99m, Description = "A good every day boot for your every day needs! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Muted Beige F6 Western Boot", Price = 149.99m, Description = "This is a pale brown, perfect for those casual afternoons! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Blackest Black Crocodile Print CC13 Western Boot", Price = 169.99m, Description = "Made with real crocodile skin, with a hint of black velvet fabric! Handmade in Nayarit, Mexico."}
            new Product { Id = 3, Name = "Tan Brown TB33 Western Boot", Price = 149.99m, Description = "A good balance of a ever day look, or a night out! Handmade in Nayarit, Mexico."}
        };

        public IActionResult Index()
        {
            return View(products);
        }}}

namespace OnlineStore.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> cartItems = new List<CartItem>();

        public IActionResult Index()
        {
            return View(cartItems);
        }

        public IActionResult AddToCart(int id)
        {
            var product = ProductController.products.Find(p => p.Id == id);

            if (product != null)
            {
                var cartItem = cartItems.Find(ci => ci.Product.Id == id);
                if (cartItem != null)
                {
                    cartItem.Quantity++;
                }
                else
                {
                    cartItems.Add(new CartItem { Product = product, Quantity = 289});
                }
            }

            return RedirectToAction("Index");
        }}}
