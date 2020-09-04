using Microsoft.AspNetCore.Mvc;
using System; 
namespace TimeDisplay
{   
    public class HomeController :Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {

            return View("Index");
        }
    }
}