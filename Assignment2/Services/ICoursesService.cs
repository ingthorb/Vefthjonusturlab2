using System;
using System.Collections.Generic;
using Assignment2.API.Models;

namespace Assignment2.API.Services
{
    public interface ICoursesService
    {

         List<coursesDTO> GetCourses(string Semester = null);


         List<coursesDTO> GetCoursesBySemester(string semester);

         coursesDTO GetCourseByID(int ID);
         /*
         coursesDTO DeleteCourse(int ID);
         coursesDTO UpdateCourse(int ID, Course course);
*/
        //TODO: Add more functions
    }
}
