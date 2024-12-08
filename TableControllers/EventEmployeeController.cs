using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    public class EventEmployeeController : GenericController<EventEmployee>
    {
        public EventEmployeeController(Yp3Context context) : base(context) { }
    }
}
