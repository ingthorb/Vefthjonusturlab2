using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
namespace Assignment2.API.Controllers
{
    [Route("api/controller")]
    public class CourseController : Controller
    {
        // GET api/values
        [HttpGet]
        public List<CourseLiteDTO> GetCoursesOnSemester(string semester = null)
        {
            return new List<CourseLiteDTO>
            {
                new CourseLiteDTO
                {
                    ID = 1,
                    Name = "Vef",
                    Semester = "20163"

                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
