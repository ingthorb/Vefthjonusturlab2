using System;

namespace Assignment2.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class coursesDTO
    {
      /// <summary>
      /// Database generated ID of the course 
      /// </summary>
      public int ID {get; set;}

      /// <summary>
      /// The name of the Course.
      /// Example: "Web Services"
      /// </summary>
      public string CourseID {get;set;}

      /// <summary>
      /// Example "20151" -> spring 2015, 
      /// "20152" -> summer 2015,
      /// "20153" -> fall 2015). 
      /// </summary>
      public string Semester {get; set;}

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
