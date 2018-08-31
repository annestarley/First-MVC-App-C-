using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers 
{
    public class MessageController : Controller   
    {
        [HttpGet]       
        [Route("message")]     
        public IActionResult MessageDetail()
        {
            Message message = new Message()
            {
                MessageText = "Lebowski ipsum when will you find these guys? I mean, do you have any promising leads? Hey, relax man, I'm a brother shamus. You might fool the guys in the league office, but you don't fool Jesus! It's all a goddamn fake. Like Lenin said, look for the person who will benefit."
            };

            return View(message);

        }
    }
}