using CloudAssign1.Models;
using CloudAssignment1.BusinessLayer;
using CloudAssignment1.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CloudAssign1.Controllers
{
    public class DepController : ApiController
    {
        // GET: api/Dep
        public IHttpActionResult Get()
        {
            try
            {
                // get all departments
                List<Department> DepartmentList = new DepartmentBusinessLayer().GetAllDepartments();
                return Ok(DepartmentList);
            }
            catch (Exception ex)
            {
                return Ok("Unable to connect to DAL Server, try again later");
            }
        }

        // GET: api/Dep/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dep
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dep/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dep/5
        public void Delete(int id)
        {
        }
    }
}
