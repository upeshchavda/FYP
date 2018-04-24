using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstStudentDetails
    {
        public string DateBirth { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //test to see that it exists
            Assert.IsNotNull(AStudent);
        }
        [TestMethod]
        public void TestStudentIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStudentDetails TestStudentId = new clsStudentDetails();
            //create some test data to assign to the property
            Int32 SomeData = 1002;
            //assign the data to the property
            TestStudentId.StudentId = SomeData;
            // Test to see the values are the same
            Assert.AreEqual(TestStudentId.StudentId, SomeData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStudentDetails TestFirstName = new clsStudentDetails();
            //create some test data to assign to the property
            string SomeData = "Jonathan";
            //assign the data to the property
            TestFirstName.Firstname = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(TestFirstName.Firstname, SomeData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStudentDetails TestLastName = new clsStudentDetails();
            //create some test data to assign to the property
            string SomeData = "Smith";
            //assign the data to the property
            TestLastName.Lastname = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(TestLastName.Lastname, SomeData);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStudentDetails TestEmailAddress = new clsStudentDetails();
            //create some test data to assign to the property
            string SomeData = "JonathanSmith@gmail.com";
            //assign the data to the property
            TestEmailAddress.Emailaddress = SomeData;
            //test to see that the two values are the same
            Assert.AreEqual(TestEmailAddress.Emailaddress, SomeData);

        }
        [TestMethod]
        public void MobileNumberPropertyOK()
        {
            //instance of the class
            clsStudentDetails TestMobileNumber = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "07701343822";
            //assign the data to the property
            TestMobileNumber.Mobilenumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestMobileNumber.Mobilenumber, SomeData);
        }
        [TestMethod]
        public void AddressNamePropertyOK()
        {
            //instance of the class
            clsStudentDetails TestAddressName = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "460";
            //assign the data to the property
            TestAddressName.AddressName = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressName.AddressName, SomeData);
        }
        [TestMethod]
        public void AddressStreetNamePropertyOK()
        {
            //instance of the class
            clsStudentDetails TestAddressStreetName = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "smith field drive";
            //assign the data to the property
            TestAddressStreetName.Streetname = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressStreetName.Streetname, SomeData);
        }
        [TestMethod]
        public void AddressCityNamePropertyOK()
        {
            //instance of the class
            clsStudentDetails TestAddressCityName = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "Leicester";
            //assign the data to the property
            TestAddressCityName.Cityname = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressCityName.Cityname, SomeData);
        }
        [TestMethod]
        public void AddressPostCodePropertyOK()
        {
            //instance of the class
            clsStudentDetails TestAddressPostCode = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "LE4 7UH";
            //assign the data to the property
            TestAddressPostCode.Postcode = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestAddressPostCode.Postcode, SomeData);
        }
 
   
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //instance of the class
            clsStudentDetails TestDateOfBirth = new clsStudentDetails();
            //create some test data to assign to the property 
            DateTime SomeData = new DateTime(1996, 02, 08);
            //assign the data to the property
            TestDateOfBirth.Datebirth = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestDateOfBirth.Datebirth, SomeData);
        }
        [TestMethod]
        public void GenderPropertyOK()
        {
            //instance of the class
            clsStudentDetails TestGender = new clsStudentDetails();
            //create some test data to assign to the property 
            string SomeData = "female";
            //assign the data to the property
            TestGender.Gender = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestGender.Gender, SomeData);
        }
  
        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "gh";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "gkh";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ghuj";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ertyudfghjcvbnm";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ertyudfghjcvbnmk";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ertyudfghjcvbnmkj";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ertyudfg";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "ertyudfghjcvbnmhjuhgtyuik";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "df";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "dfh";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "dfjk";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnm";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnjh";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnjhj";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "ertyudfg";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "rtyuidfghjcvbnmtyuighjuyv";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "sdfgy";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyuh";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyuhj";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgb";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgbh";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgbhh";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ghyujnhytghjnmkiu";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ghyhujknmkihgfdfcvgghjjnbhyttreedfghjkik";//@hotmail.com
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "2346578967";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "23465789767";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "123456543213";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "1234567653";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "02345678346";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MobileMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "123456789765";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "254678";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "234567845987654";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "2";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "35";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "465";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "4685";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "46785";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressNameMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "48";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "34567hun";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "ghyu";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "fghuk";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "ehumko";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "hshjsishihshshdsifdhsidhsihnkjosihjdjodjdjjddhuop";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "hshjsishihshshdsifdhsidhsihnkjosihjdjodjdjjddhuopj";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "hshjsishihshshdsifdhsidhsihnkjosihjdjodjdjjddhuopjk";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressStreetNameMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "hshjsishihshshdsifdhsidhsihnkn";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressStreetNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "hshjsishihshshdsifdhsidhsihnknjjjjojjngfdyubfvbbcihicsosohfoshukn";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressCityNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "le";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressCityNameMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "lie";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressCityNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leud";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressCityNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "Hshjsishihshshdsifdhsidhsihnknjjjjojjngfdy7890edd";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressCityNameMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "Hshjsishihshshdssifdhsidhsihnknjjjjojjngfdy7890edd";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressCityNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "Hshjsishihshshdssifdhsidhhsihnknjjjjojjngfdy7890edd";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressCityNameMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "hsidhsihnknjjjjojjngfdy7890edd";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressCityNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "hsidhsihnknjjjjojjngfdy7890edddhhdudbhddhdhdhdhdhdhudbubdbdbdhdbbddbbu";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5j";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "ley8u";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le48hj";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le48ujd";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le568huk";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le58junmkid";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
         }
        [TestMethod]
        public void AddressPostCodeMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5j";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void AddressPostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "hsidhsihnk";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DateBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-100).AddDays(-1);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DateBirthMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-100).AddMinutes(1);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-100).AddDays(1);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-18).AddDays(-1);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateBirthMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-18);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-18).AddDays(1);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void DateBirthMid()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now.AddYears(-59);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = DateTime.Now;
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void GenderMinLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "mae";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void GenderMin()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "male";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void GenderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "malej";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void GenderMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "msdhu";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void GenderMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "female";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "maleudh";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod] 
        public void GenderMid() 
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            

            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "maejk";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void GenderExtremeMax()
        {
            //create an instance of the class we want to create
            clsStudentDetails AStudent = new clsStudentDetails();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            Int32 StudentId = 4;
            string AddressCityName = "leicester";
            string AddressName = "233";
            string AddressPostCode = "le5 6tf";
            string AddressStreetName = "dmu street";
            
            
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            string Gender = "mhjuikjsd";
            DateTime DateBirth = new DateTime(1996, 02, 08);
            //invoke the method
            Ok = AStudent.Valid(StudentId, AddressCityName, AddressName, AddressPostCode, AddressStreetName, EmailAddress, FirstName, LastName, MobileNumber, Gender, DateBirth);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }















    }

}




