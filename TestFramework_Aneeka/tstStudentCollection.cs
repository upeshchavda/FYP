using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace TestFrameWork
{
    [TestClass]
    public class tstStudentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Students = new clsStudentCollection();
            //test to see that it exists
            Assert.IsNotNull(Students);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Students = new clsStudentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            Students.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(Students.Count, SomeCount);
        }
        [TestMethod]
        public void AllStudentsOK()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Students = new clsStudentCollection();
            //create some test data to assign to the property
            List<clsStudentDetails> TestList = new List<clsStudentDetails>();
            //add an item to the list
            //create the item of test data
            clsStudentDetails TestItem = new clsStudentDetails();
            //set its properties
            TestItem.Firstname = "aneeka";
            TestItem.Lastname = "neee";
            TestItem.Emailaddress = "aneeka@hotmail.com";
            TestItem.Mobilenumber = "77882226121";
            TestItem.Gender = "male";
            TestItem.Datebirth = DateTime.Now.Date;
            TestItem.AddressName = "233";
            TestItem.Cityname = "leicester";
            TestItem.Postcode = "le5 6tf";
            TestItem.Streetname = "dmu street";
            //add the items to the test list 
            TestList.Add(TestItem);
            //asign the data to the property
            Students.AllStudents = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Students.AllStudents, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Students = new clsStudentCollection();
            //create some test data to assign to the property
            List<clsStudentDetails> TestList = new List<clsStudentDetails>();
            //add an item to the list
            //create the item of test data 
            clsStudentDetails TestItem = new clsStudentDetails();
            //set its properties
            TestItem.Firstname = "aneeka";
            TestItem.Lastname = "neee";
            TestItem.Emailaddress = "aneeka@hotmail.com";
            TestItem.Mobilenumber = "77882226121";
            TestItem.Gender = "male";
            TestItem.Datebirth = DateTime.Now.Date;
            TestItem.AddressName = "233";
            TestItem.Cityname = "leicester";
            TestItem.Postcode = "le5 6tf";
            TestItem.Streetname = "dmu street";
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Students.AllStudents = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Students.AllStudents, TestList);
        }
    }
    }

