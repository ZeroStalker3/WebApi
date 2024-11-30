using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : GenericController<Post>
    {
        public PostController(Yp3Context context): base(context) { }
    }
}
