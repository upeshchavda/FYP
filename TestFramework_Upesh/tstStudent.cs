using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary_Upesh;

namespace TestFramework_Upesh
{
    [TestClass]
    public class tstStudent
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //test to see if it exists
            Assert.IsNotNull(AStudent);
        }

        [TestMethod]
        public void StudentIDOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            Int32 TestStudentID = 100;
            //assign the test data to the property
            AStudent.StudentID = TestStudentID;
            //test to see that the two values match
            Assert.AreEqual(AStudent.StudentID, TestStudentID);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestFirstName = "Upesh";
            //assign the test data to the property
            AStudent.FirstName = TestFirstName;
            //test to see that the two values match
            Assert.AreEqual(AStudent.FirstName, TestFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestLastName = "Chavda";
            //assign the test data to the property
            AStudent.LastName = TestLastName;
            //test to see that the two values match
            Assert.AreEqual(AStudent.LastName, TestLastName);
        }

        [TestMethod]
        public void AddressLine1PropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestAddress1 = "40 Western Road";
            //assign the test data to the property
            AStudent.AddressLine1 = TestAddress1;
            //test to see that the two values match
            Assert.AreEqual(AStudent.AddressLine1, TestAddress1);
        }

        [TestMethod]
        public void AddressLine2PropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestAddress2 = "Flat 1245";
            //assign the test data to the property
            AStudent.AddressLine2 = TestAddress2;
            //test to see that the two values match
            Assert.AreEqual(AStudent.AddressLine2, TestAddress2);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestCity = "Leicester";
            //assign the test data to the property
            AStudent.City = TestCity;
            //test to see that the two values match
            Assert.AreEqual(AStudent.City, TestCity);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestPostCode = "LE3 0GH";
            //assign the test data to the property
            AStudent.PostCode = TestPostCode;
            //test to see that the two values match
            Assert.AreEqual(AStudent.PostCode, TestPostCode);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            DateTime TestDateOfBirth = new DateTime(1996, 02, 08);
            //assign the test data to the property
            AStudent.DateOfBirth = TestDateOfBirth;
            //test to see that the two values match
            Assert.AreEqual(AStudent.DateOfBirth, TestDateOfBirth);
        }

        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestTelephone = "07885547885";
            //assign the test data to the property
            AStudent.Telephone = TestTelephone;
            //test to see that the two values match
            Assert.AreEqual(AStudent.Telephone, TestTelephone);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsStudent AStudent = new clsStudent();
            //create some test data to assign to the property
            string TestEmail = "testemail@testing.co.uk";
            //assign the test data to the property
            AStudent.Email = TestEmail;
            //test to see that the two values match
            Assert.AreEqual(AStudent.Email, TestEmail);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;

            string FirstName = "";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "U";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "Up";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "UpeshUpeshUpeshUpes";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "UpeshUpeshUpeshUpesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "UpeshUpeshUpeshUpeshU";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "UpeshUpesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FirstNameExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            //Because the test is related to this variable, this may change
            Int32 StudentID = 100;
            string FirstName = "UpeshUpeshUpeshUpeshUpeshUpeshUpeshUpesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "C";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "Ch";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "ChavdaChavdaChavdaC";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "ChavdaChavdaChavdaCh";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "ChavdaChavdaChavdaCha";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "ChavdaChav";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void LastNameExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            //Because the test is related to this variable, this may change
            string LastName = "ChavdaChavdaChavdaChavdaChavdaChavdaChav";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine1ExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100;
            string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine1MinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine1Min()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "4";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine1MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine1MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40 Western Road 400";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine1Max()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40 Western Road 40 W";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40 Western Road 40 We";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine1Mid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40 Western";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine1ExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            //Because the test is related to this variable, this may change
            string AddressLine1 = "40 Western Road40 Western Road40 Western";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine2ExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine2MinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine2Min()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "F";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine2MinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Fl";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine2MaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Flat1245 Flat1245 F";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine2Max()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Flat1245 Flat1245 Fl";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine2MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Flat1245 Flat1245 Fla";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void AddressLine2Mid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Flat1245 F";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void AddressLine2ExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            //Because the test is related to this variable, this may change
            string AddressLine2 = "Flat1245 Flat1245 Flat1245 Flat1245 Flat";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CityExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "L";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "Le";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "Leicester LeicesterL";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "Leicester Leicester L";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "LeicesterL";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CityExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            //Because the test is related to this variable, this may change
            string City = "Leicester Leicester Leicester LeicesterL";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "L11L";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "L11LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL11LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL1 1LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL11 1LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL11 1LLL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL11LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PostCodeExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            //Because the test is related to this variable, this may change
            string PostCode = "LL11LL11LL";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateOfBirthExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = new DateTime(1850, 01, 01);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-100).AddDays(-1);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-100).AddMinutes(1); //Had to add an extra minute due to the test failing, because the time was inaccurate
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-100).AddDays(1);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-18).AddDays(-1);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-18).AddDays(1);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now.AddYears(-59);
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateOfBirthExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester";
            string PostCode = "LE3 0GH";
            //Because the test is related to this variable, this may change
            DateTime DateOfBirth = DateTime.Now;
            string Telephone = "07885547885";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "1234567890";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "12345678901";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "123456789012";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "1234567890";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TelephoneMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "12345678901";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "123456789012";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }


        [TestMethod]
        public void TelephoneMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "12345678901";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TelephoneExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            //Because the test is related to this variable, this may change
            string Telephone = "12345678901234567890";
            string Email = "testemail@testing.co.uk";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailExMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "t";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@t";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@te";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@tes";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@testthis.co.uktesting@testthis.";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@testthis.co.uktesting@testthis.c";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@testthis.co.uktesting@testthis.co";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@testthis.co.uktes";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void EmailExMax()
        {
            //create an instance of the class we want to create
            clsStudent AStudent = new clsStudent();
            //declare a boolean variable to store the result of the validation
            bool OK = false;
            //create some test data to assign to the property
            Int32 StudentID = 100; string FirstName = "Upesh";
            string LastName = "Chavda";
            string AddressLine1 = "40 Western Road";
            string AddressLine2 = "Flat1245";
            string City = "Leicester Leicester";
            string PostCode = "LE3 0GH";
            DateTime DateOfBirth = new DateTime(1996, 02, 08);
            string Telephone = "12345678901234567890";
            //Because the test is related to this variable, this may change
            string Email = "testing@testthis.co.uktesting@testthis.co.uktesting";
            //invoke the method
            OK = AStudent.Valid(StudentID, FirstName, LastName, AddressLine1, AddressLine2, City, PostCode, DateOfBirth, Telephone, Email);
            //test to see if the result is correct
            Assert.IsFalse(OK);
        }

    }
}