using System;
using System.Collections.Generic;
using Assignment2.API.Models;

namespace Assignment2.API.Services
{
    public interface IStudentsService
    {
         List<StudentDTO> GetStudentsByCourseID(int id);
        // Student CreateStudentByCourseID(int id, Student stud);

        //TODO: Add more functions
    }
}
