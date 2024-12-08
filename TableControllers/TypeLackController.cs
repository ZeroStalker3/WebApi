using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    public class TypeLackController : GenericController<TypeLack>
    {
        public TypeLackController(Yp3Context context) : base(context) { }
    }
}
