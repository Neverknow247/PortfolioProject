using Microsoft.AspNetCore.Mvc;
namespace portfolioI.Controllers
{
    public class HelloControllers : Controller
    {
        // [Route("")]
        [HttpGet("")]
        public string Index(){
            return "This is my Index!";
        }
        // [Route("hello")]
        [HttpGet("projects")]
        public string Projects(){
            return "These are my projects";
        }
        [HttpGet("contact")]
        public string Contact(){
            return "This is my contact!";
        }
    }
}