using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : GenericController<Status>
    {
        public StatusController(Yp3Context context) : base(context) { }
    }
}
