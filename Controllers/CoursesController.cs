using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class CoursesController: Controller
    {
        
        public IActionResult Index()       
        {
            return View(); //Content("Sono la Index del Courses Controller");
        }

        public IActionResult Detail(string id)       
        {
            return Content($"Sono la Detail, ho ricevuto l'id {id}");
        }
    }
}