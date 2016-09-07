using System;
using System.Collections.Generic;
using Assignment2.API.Models;
using System.Linq;

namespace Assignment2.API.Services
{
    public class StudentService : IStudentsService
    {

        private readonly AppDataContext _db;
        public StudentService(AppDataContext db){
            _db = db;
        }
        public  List<StudentDTO> GetStudentsByCourseID(int id){
            //TODO
            return null;
      
     }
}
}
