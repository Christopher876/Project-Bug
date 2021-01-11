using Microsoft.AspNetCore.Mvc;

namespace ProjectBug.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Bug : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
    }
}