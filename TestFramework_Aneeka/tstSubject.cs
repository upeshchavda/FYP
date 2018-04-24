using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstSubject
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsSubjectDetails AStudent = new clsSubjectDetails();
            //test to see that it exists
            Assert.IsNotNull(AStudent);
        }
        [TestMethod]
        public void SubjectCodePropertyOK()
        {
            //instance of the class
            clsSubjectDetails TestSubjectName = new clsSubjectDetails();
            //create some test data to assign to the property 
            string SomeData = "ctec3405";
            //assign the data to the property
            TestSubjectName.Subject = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestSubjectName.Subject, SomeData);
        }
        [TestMethod]
        public void SubjectNamePropertyOK()
        {
            //instance of the class
            clsSubjectDetails TestSubjectName = new clsSubjectDetails();
            //create some test data to assign to the property 
            string SomeData = "telematics";
            //assign the data to the property
            TestSubjectName.Subject = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestSubjectName.Subject, SomeData);
        }
        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hujkg";
                //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec340";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectCodeMin()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec34055";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec790";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectCodeMax()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec34055";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectCodeMid()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec4";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec678905";
            string SubjectName = "hujkg";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hunk";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectNameMin()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hunks";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hunksj";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "dhfudjdodjdojjosdoj";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectNameMax()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "dhfudjdodjdaojjosdoj";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "dhfudjdodjdaojjosdoja";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void SubjectNameMid()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "hujmsoldui";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void SubjectNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSubjectDetails ASubject = new clsSubjectDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string SubjectCode = "ctec3405";
            string SubjectName = "dhfudjdodjdojjosdojsyudnkmolps";
            //invoke the method
            Ok = ASubject.Valid(SubjectCode, SubjectName);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
    }
}
