using System;

namespace Assignment2.API.Services.Entities
{
    public class Course{

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ID { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string CourseID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Semester { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string EndDate { get; set; }
    }
}