// src/eBills.API/Controllers/ExampleController.cs
using Microsoft.AspNetCore.Mvc;

namespace eBills.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello, world!" });
        }
    }
}
