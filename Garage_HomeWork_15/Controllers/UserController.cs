using Microsoft.AspNetCore.Mvc;

namespace Garage_HomeWork_15.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Abdulsalam";
            ViewData["Surname"] = "Abdullayev";
            ViewData["Age"] = 25;
            ViewData["Country"] = "Azerbaijan";
            ViewData["PhoneNumber"]= "+994705641234";
            return View();
        }
    }
}
