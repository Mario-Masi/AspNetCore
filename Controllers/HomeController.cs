using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()       
        {
            return Content("Sono la Index dell'Home Controller");
        }
    }
}