using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()       
        {
            return View(); // Content("Sono la Index dell'Home Controller");
        }
    }
}