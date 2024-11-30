using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            var data = new { Message = "Hello from ASP.NET API", Timestamp = DateTime.UtcNow };
            return Ok(data);
        }

        [HttpPost]
        public IActionResult PostData([FromBody] Model model)
        {
            if (model == null) return BadRequest("Invalid data");
            // Обработка данных
            return Ok(new { Status = "Success", Received = model });
        }
    }
}
