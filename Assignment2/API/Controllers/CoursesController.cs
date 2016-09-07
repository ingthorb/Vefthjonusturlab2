using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.API.Models;
using Assignment2.API.Services;

namespace Assignment2.API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;


        public CoursesController(ICoursesService service){
            _service = service;
        }

        // [HttpGet]
        // [Route("{semester:string}",Name="GetCoursesOnSemester")]
        // public List<coursesDTO> GetCoursesOnSemester(string semester)
        // {
        //     return _service.GetCoursesBySemester(semester);  
        // }

        [HttpGet]
        [Route("{id:int}",Name="GetCourse")]
        public IActionResult GetCourseByID(int id) {
            return _service.GetCourseByID(id);
        }

/*         [HttpGet]
         public List<coursesDTO> GetCourse()
         {
             return _service.GetCourses();  
         }
*/
    }
}