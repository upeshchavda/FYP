using System;

namespace ClassLibrary
{
    public class clsCourseDetails
    {
        public string Course { get; set; }
        public int CourseId { get; set; }
        public string Department { get; set; }
        public int Points { get; set; }
        public int Tuition { get; set; }

        public bool Valid(string CourseName, string department, int pointScore, int tuitionFee)
        {
            bool Ok = true;

            //course name validation 
            if (CourseName.Length < 4)
            {
                Ok = false;
            }
            //error message
            else if (CourseName.Length > 20)
            {
                Ok = false;
            }
            //end of course name validation

            //department validation 
            if (department.Length < 4)
            {
                Ok = false;
            }
            //error message
            else if (department.Length > 20)
            {
                Ok = false;
            }
            //end of department validation

            //point score validation 
            if (pointScore <200)
            {
                Ok = false;
            }
            //error message 
            else if (pointScore >350)
            {
                Ok = false; 
            }
            //end of point score validation

            //tution fee validation 
            if (tuitionFee != 9000)
            {
                Ok = false;
            }
           //end of tuition fee validation 

            return Ok;
        }
    }
}