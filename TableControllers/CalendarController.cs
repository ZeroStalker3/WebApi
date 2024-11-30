using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : GenericController<Calendar>
    {
        public CalendarController(Yp3Context context) : base(context) { }
    }
}
