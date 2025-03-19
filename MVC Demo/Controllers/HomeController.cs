using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        //BaseURL/Home/Index
        public IActionResult Index()
        {
            return View();

     
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
