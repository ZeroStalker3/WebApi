using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentController : GenericController<Departament>
    {
        public DepartamentController(Yp3Context context) : base(context) { }
    }
}
