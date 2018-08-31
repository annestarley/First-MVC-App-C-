using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers 
{
    public class UsersController : Controller   
    {
        [HttpGet]       
        [Route("users")]     
        public IActionResult UsersDetails()
        {
            Users users = new Users()
            {
                SomeUsers = new string[5] { "Moose Phillips", "Lebowski", "The Dude", "Jerry", "Rene Ricky" }
            };

            return View(users);

        }
    }
}