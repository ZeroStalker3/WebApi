﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models;

namespace WebApi.TableControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : GenericController<Employee>
    {
        public EmployeeController(Yp3Context context): base(context) { }
    }
}
