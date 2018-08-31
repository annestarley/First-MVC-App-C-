using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers 
{
    public class UserController : Controller   
    {
        [HttpGet]       
        [Route("user")]     
        public IActionResult UserDetail()
        {
            // While being hard-coded here, this user instance will eventually come from our DB
            User user = new User()
            {
                FirstName = "Devon",
                LastName = "Newsom"
            };
            // Here we pass this instance to our View
            return View(user);
            // If we also need to include the name of our View, we pass our instance as a second argument
            // return View("OtherView", user);
        }

        [HttpGet]
        [Route("pleasework")]     
        public string Index()
        {
            return $"You gonna work?";
        }
    }
}