using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStudentCollection
    {
        //private data memeber for the allstudents list
        private List<clsStudentDetails> mAllStudents = new List<clsStudentDetails>();
        public int Count { get; set; }
        public List<clsStudentDetails> AllStudents { get; set; }

        //public property for count
        public int count
        {
            get
            {
                //return the student property of the private list
                return mAllStudents.Count;
            }
            set
            {
                //look at later
            }
        }
        //public proeprty for allstudents
        public List<clsStudentDetails> Allstudents
        {
            get
            {
                //return the private data member
                return mAllStudents;
            }
            set
            {
                //assign the incoming value to the private data member
                mAllStudents = value;
            }
        }
       
    }
}