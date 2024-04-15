using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, World! My name is Ujjwal Kushwaha" });
        }
    }
}
