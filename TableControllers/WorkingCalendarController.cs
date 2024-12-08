using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    public class WorkingCalendarController :  GenericController<WorkingCalendarController>
    {
        public WorkingCalendarController(Yp3Context context) : base(context) { }
    }
}
