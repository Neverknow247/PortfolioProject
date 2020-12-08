using Microsoft.AspNetCore.Mvc;
namespace portfolioI.Controllers
{
    public class HomeController : Controller
    {
        // [Route("")]
        [HttpGet("")]
        public ViewResult Index(){
            return View("Index");
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