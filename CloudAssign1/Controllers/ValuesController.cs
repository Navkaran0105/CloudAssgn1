using CloudAssign1.Models;
using CloudAssignment1.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CloudAssign1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            try
            {
                // get all employees
                List<Employee> EmployeeList = new EmployeeBusinessLayer().GetEmployeeDetails();
                return Ok(EmployeeList);
            }
            catch (Exception ex)
            {
                return Ok("Unable to connect to DAL Server, try again later");
            }

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
