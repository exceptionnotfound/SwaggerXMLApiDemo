using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerXMLApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetByID(int id)
        {
            return "Found Employee";
        }

        [HttpGet]
        public ActionResult<string> GetByName(string firstName, string lastName)
        {
            return "Found another employee";
        }
    }
}