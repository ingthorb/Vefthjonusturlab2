using System;
using System.Collections.Generic;
using Assignment2.API.Models;
using System.Linq;

namespace Assignment2.API.Services
{
    public class CoursesService : ICoursesService
    {

        private readonly AppDataContext _db;
        public CoursesService(AppDataContext db){
            _db = db;
        }

        public  List<coursesDTO> GetCourses(string Semester = null){
            var Sem = "";
             if( Semester == null) 
             {
                 Sem = "20163";
             }
             else {
                 Sem = Semester;
             }

             return (from x in _db.Courses
             where x.Semester == Sem
             select new coursesDTO{
                 ID = x.ID,
                 CourseID = x.CourseID,
                 Semester = x.Semester
             }).ToList();
         }
        public  List<coursesDTO> GetCoursesBySemester(string semester){
           /*  return (from x in _db.Courses
             select new coursesDTO{
                 ID = x.ID,
                 Semester = x.Semester
             }).ToSingleOrDefault();
        */
            var courses = _db.Courses.Where()
        
         }

        public coursesDTO GetCourseByID(int ID){
             return (from x in _db.Courses
             where x.ID == ID
             select new coursesDTO{
                 ID = x.ID,
                 CourseID = x.CourseID,
                 Semester = x.Semester,
                 StartDate  = x.StartDate,
                 EndDate = x.EndDate
             });

/*
        public coursesDTO DeleteCourse(int ID){
             Course cor =  (from x in _db.Courses
             where x.ID == ID
             select new coursesDTO{
                 ID = x.ID,
                 CourseID = x.CourseID,
                 Semester = x.Semester,
                 StartDate  = x.StartDate,
                 EndDate = x.EndDate
             });
             
             if(cor == null)
             {
                 return 404
             }
             else
             {
                 //Remove from database
             }
             
             
            
             return null;

        }*/
        
/*
        public coursesDTO UpdateCourse(int ID, Course course){
             Course cor =  (from x in _db.Courses
             where x.ID == ID
             select new coursesDTO{
                 ID = x.ID,
                 CourseID = x.CourseID,
                 Semester = x.Semester,
                 StartDate  = x.StartDate,
                 EndDate = x.EndDate
             });
             
             if(cor == null)
             {
                 return 404
             }
             else if(course.ID != cor.ID)
             {
                 //Villa
             }
             else if(course.CourseID != cor.Id)
             {
                 //Villa
             }
             else if(course.Semester != cor.Semester)
             {
                 //Villa
             }
             else
             {
                 if(course.StartDate != null)
                 {
                     //update
                 }
                 else if(course.EndDate != null)
                 {
                     //update
                 }
             }
             
             
             return null;

        }*/
     }
}
