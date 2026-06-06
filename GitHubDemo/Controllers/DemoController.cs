using Microsoft.AspNetCore.Mvc;

namespace GitHubDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                mensaje = "Hola Mundo"
            });
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST ejecutado");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok($"PUT ejecutado para {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"DELETE ejecutado para {id}");
        }
    }
}
