using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstCourse
    {

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCourseDetails AStudent = new clsCourseDetails();
            //test to see that it exists
            Assert.IsNotNull(AStudent);
        }
        [TestMethod]
        public void CourseIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCourseDetails TestCourseId = new clsCourseDetails();
            //create some test data to assign to the property
            Int32 SomeData = 1002;
            //assign the data to the property
            TestCourseId.CourseId = SomeData;
            // Test to see the values are the same
            Assert.AreEqual(TestCourseId.CourseId, SomeData);
        }
        [TestMethod]
        public void CourseNamePropertyOK()
        {
            //instance of the class
            clsCourseDetails TestCourseName = new clsCourseDetails();
            //create some test data to assign to the property 
            string SomeData = "computing";
            //assign the data to the property
            TestCourseName.Course = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestCourseName.Course, SomeData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //instance of the class
            clsCourseDetails TestDepartment = new clsCourseDetails();
            //create some test data to assign to the property 
            string SomeData = "computing";
            //assign the data to the property
            TestDepartment.Department = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestDepartment.Department, SomeData);
        }
        [TestMethod]
        public void PointScorePropertyOK()
        {
            //create an instance of the class we want to create
            clsCourseDetails TestPoints = new clsCourseDetails();
            //create some test data to assign to the property
            Int32 SomeData = 350;
            //assign the data to the property
            TestPoints.Points = SomeData;
            // Test to see the values are the same
            Assert.AreEqual(TestPoints.Points, SomeData);
        }
        [TestMethod]
        public void TuitionFeePropertyOK()
        {
            //create an instance of the class we want to create
            clsCourseDetails TestFee = new clsCourseDetails();
            //create some test data to assign to the property
            Int32 SomeData = 9000;
            //assign the data to the property
            TestFee.Tuition = SomeData;
            // Test to see the values are the same
            Assert.AreEqual(TestFee.Tuition, SomeData);
        }
        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "dra";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CourseNameMin()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "dram";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "draghuikjnhgdftyudv";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "draeryhdnmerfhujsndj";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "draeryhdnmerfhujsndjj";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void CourseNameMid()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "draeryhdnmerfhu";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CourseNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "draeryhdnmerfhudraeryhdnmerfhu";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "dra";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DepartmentMin()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "dram";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "ddhjm";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "draghuikjnhgdftyudv";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "draghuikjnhgdftyudvj";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "draghuikjnhgdsftyudvj";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "draghuikjnhgdsf";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "draeryhdnmerfhudraeryhdnmerfhu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PointscoreMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 199;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PointscoreMin()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 200;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PointscoreMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 201;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PointscoreMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 349;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PointscoreMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PointscoreMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 351;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void PointscoreMid()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 250;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PointscoreExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 400;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 8999;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeMin()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TuitionfeeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9001;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 8999;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TuitionfeeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9001;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeMid()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 5000;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void TuitionfeeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCourseDetails ACourse = new clsCourseDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string CourseName = "drama";
            string Department = "compu";
            Int32 PointScore = 350;
            Int32 TuitionFee = 9500;
            //invoke the method
            Ok = ACourse.Valid(CourseName, Department, PointScore, TuitionFee);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
    }
}
