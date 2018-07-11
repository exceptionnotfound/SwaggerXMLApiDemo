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
        /// <summary>
        /// Retrieve the employee by their ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public ActionResult<string> GetByID(int id)
        {
            return "Found Employee";
        }

        [HttpGet]
        [Route("byname/{firstName}/{lastName}")]
        public ActionResult<string> GetByName(string firstName, string lastName)
        {
            return "Found another employee";
        }
    }
}