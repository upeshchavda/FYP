using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_Upesh;
using System.Collections.Generic;

namespace TestFramework_Upesh
{
    [TestClass]
    public class tstStudentCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //Create an instance of the class we want to create
            clsStudentCollection AllStudent = new clsStudentCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStudent);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsStudentCollection AllStudent = new clsStudentCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStudent.Count = SomeCount;
            //test to see if the two values match
            Assert.AreEqual(AllStudent.Count, SomeCount);
        }

        [TestMethod]
        public void AllStudentsOk()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Student = new clsStudentCollection();
            //create a list of data to assign to the property
            List<clsStudent> TestList = new List<clsStudent>();
            //add item to the list
            clsStudent TestItem = new clsStudent();
            //set its properties
            TestItem.FirstName = "Upesh";
            TestItem.LastName = "Chavda";
            TestItem.AddressLine1 = "40 Western Road";
            TestItem.AddressLine2 = "Flat1245";
            TestItem.City = "Leicester";
            TestItem.PostCode = "LE3 0GH";
            TestItem.DateOfBirth = new DateTime(1996, 02, 08);
            TestItem.Telephone = "07885547885";
            TestItem.Email = "testemail@testing.co.uk";
            //Add items to the list
            TestList.Add(TestItem);
            //assign the data to the property
            Student.AllStudents = TestList;
            //test to see if they are equal
            Assert.AreEqual(Student.AllStudents, TestList);

        }

        [TestMethod]
        public void CountMatchesTestList()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Student = new clsStudentCollection();
            //create a list of data to assign to the property
            List<clsStudent> TestList = new List<clsStudent>();
            //add item to the list
            clsStudent TestItem = new clsStudent();
            //set its properties
            TestItem.FirstName = "Upesh";
            TestItem.LastName = "Chavda";
            TestItem.AddressLine1 = "40 Western Road";
            TestItem.AddressLine2 = "Flat1245";
            TestItem.City = "Leicester";
            TestItem.PostCode = "LE3 0GH";
            TestItem.DateOfBirth = new DateTime(1996, 02, 08);
            TestItem.Telephone = "07885547885";
            TestItem.Email = "testemail@testing.co.uk";
            //Add items to the list
            TestList.Add(TestItem);
            //assign the data to the property
            Student.AllStudents = TestList;
            //test to see if they are equal
            Assert.AreEqual(Student.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoStudentsPresent()
        {
            //Create an instance of the class we want to create
            clsStudentCollection Student = new clsStudentCollection();
            //test to see if they are equal
            Assert.AreEqual(Student.Count, 2);

        }
    }
}
