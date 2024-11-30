using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : GenericController<Material>
    {
        public MaterialController(Yp3Context context): base(context) { }
    }
}
