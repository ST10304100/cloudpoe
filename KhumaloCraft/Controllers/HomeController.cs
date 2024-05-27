using KhumaloCraft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KhumaloCraft.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }





        public IActionResult ContactUs()


        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult MyWork()
        {
            {
                // Create a list of WorkItemModel objects using object initializer syntax
                List<product> products = new List<product>
    {
        new product
        {
        Id = 1,
        Name = "Work Item 1",
        Description = "Description 1",
        ImageUrl = "https://example.com/image1.jpg",
        Price = 10.99
    },
    new product
    {
        Id = 2,
        Name = "Work Item 2",
        Description = "Description 2",
        ImageUrl = "https://example.com/image2.jpg",
        Price = 19.99
    },
    new product
    {
        Id = 3,
        Name = "Work Item 3",
        Description = "Description 3",
        ImageUrl = "https://example.com/image3.jpg",
        Price = 29.99
    }
};
                return View(products);
            }

        }
    }
}
