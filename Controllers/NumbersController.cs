using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers 
{
    public class NumbersController : Controller   
    {
        [HttpGet]       
        [Route("numbers")]     
        public IActionResult NumbersDetails()
        {
            Numbers numbers = new Numbers()
            {
                SomeNumbers = new int[3] { 11, 6, 2 }
            };

            return View(numbers);

        }
    }
}