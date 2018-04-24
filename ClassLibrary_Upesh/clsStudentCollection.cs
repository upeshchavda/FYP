using ClassLibrary_Upesh;
using System;
using System.Collections.Generic;

namespace ClassLibrary_Upesh
{
    public class clsStudentCollection
    {
        //private data member
        public List<clsStudent> mAllStudents = new List<clsStudent>();
        clsStudent mThisStudent = new clsStudent();
        public List<clsStudent> AllStudents
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

        public List<clsStudent> StudentList
        {
            get
            {
                //create array list of type clsStudent
                List<clsStudent> mStudentList = new List<clsStudent>();
                Int32 recordCount;
                Int32 index = 0;
                clsDataConnection dBConnection = new clsDataConnection();
                //send a studentID to the query
                dBConnection.AddParameter("@personID", "");
                //execute the query
                dBConnection.Execute("sproc_FilterByPersonID");
                //get count of records
                recordCount = dBConnection.Count;
                //keep looping until all records are processed;
                while (index < recordCount)
                {
                    clsStudent BlankPage = new clsStudent();
                    //copy data from the table
                    BlankPage.StudentID = Convert.ToInt32(dBConnection.DataTable.Rows[index]["personID"]);
                    BlankPage.FirstName = Convert.ToString(dBConnection.DataTable.Rows[index]["firstName"]);
                    BlankPage.LastName = Convert.ToString(dBConnection.DataTable.Rows[index]["lastName"]);
                    BlankPage.AddressLine1 = Convert.ToString(dBConnection.DataTable.Rows[index]["addressLine1"]);
                    BlankPage.AddressLine2 = Convert.ToString(dBConnection.DataTable.Rows[index]["addressLine2"]);
                    BlankPage.City = Convert.ToString(dBConnection.DataTable.Rows[index]["city"]);
                    BlankPage.PostCode = Convert.ToString(dBConnection.DataTable.Rows[index]["postCode"]);
                    BlankPage.Email = Convert.ToString(dBConnection.DataTable.Rows[index]["email"]);
                    BlankPage.Telephone = Convert.ToString(dBConnection.DataTable.Rows[index]["telephone"]);
                    BlankPage.DateOfBirth = Convert.ToDateTime(dBConnection.DataTable.Rows[index]["dateOfBirth"]);
                    //add blank page to array
                    mStudentList.Add(BlankPage);
                    //increase index
                    index++;
                }
                return mStudentList;
            }
        }

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllStudents.Count;
            }
            set
            {
                //
            }
        }

        public clsStudentCollection()
        {
            //create an instance of the student class to store a student
            clsStudent aStudent = new clsStudent();
            //Set the 
        }

        public clsStudent ThisStudent
        {
            get
            {
                return mThisStudent;
            }
            set
            {
                mThisStudent = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter db
            //var for the index
            int index = 0;
            //var for the record count
            int recordCount;
            //get theocount of records
            recordCount = DB.Count;
            //clear the private array list
            mAllStudents = new List<clsStudent>();
            //while there are records to process
            while (index < recordCount)
            {
                //create a blank  template
                clsStudent AStudent = new clsStudent();
                //read the fields from the current records
                AStudent.StudentID = Convert.ToInt32(DB.DataTable.Rows[index]["personID"]);
                AStudent.FirstName = Convert.ToString(DB.DataTable.Rows[index]["firstName"]);
                AStudent.LastName = Convert.ToString(DB.DataTable.Rows[index]["lastName"]);
                AStudent.AddressLine1 = Convert.ToString(DB.DataTable.Rows[index]["addressLine1"]);
                AStudent.AddressLine2 = Convert.ToString(DB.DataTable.Rows[index]["addressLine2"]);
                AStudent.City = Convert.ToString(DB.DataTable.Rows[index]["city"]);
                AStudent.PostCode = Convert.ToString(DB.DataTable.Rows[index]["postCode"]);
                AStudent.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[index]["dateOfBirth"]);
                AStudent.Email = Convert.ToString(DB.DataTable.Rows[index]["email"]);
                AStudent.Telephone = Convert.ToString(DB.DataTable.Rows[index]["telephone"]);
                
                //add the record to the private data member
                mAllStudents.Add(AStudent);
                //increase index
                index++;
            }
        }

        public int AddStudent()
        {
            clsDataConnection DB = new clsDataConnection();
            {
                DB.AddParameter("@firstName", mThisStudent.FirstName);
                DB.AddParameter("@lastName", mThisStudent.LastName);
                DB.AddParameter("@addressLine1", mThisStudent.AddressLine1);
                DB.AddParameter("@addressLine2", mThisStudent.AddressLine2);
                DB.AddParameter("@city", mThisStudent.City);
                DB.AddParameter("@postCode", mThisStudent.PostCode);
                DB.AddParameter("@dateOfBirth", mThisStudent.DateOfBirth);
                DB.AddParameter("@telephone", mThisStudent.Telephone);
                DB.AddParameter("@email", mThisStudent.Email);

                return DB.Execute("sproc_addPerson");
            }
        }


    }
}