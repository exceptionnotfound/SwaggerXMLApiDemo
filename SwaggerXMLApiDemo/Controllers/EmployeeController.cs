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
        /// <param name="id">The ID of the desired Employee</param>
        /// <returns>A string status</returns>
        [HttpGet]
        [Route("{id}")]
        public ActionResult<string> GetByID(int id)
        {
            return "Found Employee";
        }

        /// <summary>
        /// Returns a group of Employees matching the given first and last names.
        /// </summary>
        /// <remarks>
        /// Here is a sample remarks placeholder.
        /// </remarks>
        /// <param name="firstName">The first name to search for</param>
        /// <param name="lastName">The last name to search for</param>
        /// <returns>A string status</returns>
        [HttpGet]
        [Route("byname/{firstName}/{lastName}")]
        public ActionResult<string> GetByName(string firstName, string lastName)
        {
            return "Found another employee";
        }
    }
}