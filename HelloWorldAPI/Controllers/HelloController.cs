using Microsoft.AspNetCore.Mvc;
using System;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("api/hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet("{name}")]
        public IActionResult SayHello(String name)
        {
            return Ok(new Greeting() { Name = name, Message = "hello " });
        }
    }

    public class Greeting
    {
        public String Name { get; set; }
        public String Message { get; set; }
    }
}
