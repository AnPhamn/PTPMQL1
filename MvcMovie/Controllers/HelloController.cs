using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers{
 
     public class HelloController : Controller {

        public IActionResult Index() {
             
             return View();
              }

     }

}