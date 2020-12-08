using Microsoft.AspNetCore.Mvc;
namespace portfolioI.Controllers
{
    public class HelloControllers : Controller
    {
        // [Route("")]
        [HttpGet("")]
        public ViewResult Index(){
            return View();
        }
        // [Route("hello")]
        [HttpGet("projects")]
        public ViewResult Projects(){
            return View();
        }
        [HttpGet("contact")]
        public ViewResult Contact(){
            return View();
        }
    }
}