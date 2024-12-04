using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CabinetConroller : GenericController<Cabinet>
    {
        public CabinetConroller(Yp3Context context) : base(context) { }
    }
}
