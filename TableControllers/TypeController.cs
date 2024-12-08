using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : GenericController<Models.Types>
    {
        public TypeController(Yp3Context context) : base(context) { }   
    }
}
