using System;

namespace ClassLibrary
{
    public class clsSubjectDetails
    {
        public string Subject { get; set; }
        public int SubjectCode { get; set; }

        public bool Valid(string subjectCode, string subjectName)
        {
            bool Ok = true;

            //subject code validation 
            if (subjectCode.Length != 8)
            {
                Ok = false;
            }
            //end of subject code validation

            //subject name validation 
            if (subjectName.Length < 5)
            {
                Ok = false;
            }
            //error message
            else if (subjectName.Length > 20)
            {
                Ok = false;
            }
            //end of subject name validation

            return Ok;

        }
    }
}