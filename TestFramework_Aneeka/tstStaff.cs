using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }
     
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff TestFirstName = new clsStaff();
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
            clsStaff TestLastName = new clsStaff();
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
            clsStaff TestEmailAddress = new clsStaff();
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
            clsStaff TestMobileNumber = new clsStaff();
            //create some test data to assign to the property 
            string SomeData = "07701343822";
            //assign the data to the property
            TestMobileNumber.Mobilenumber = SomeData;
            //test to see that the two values are the same 
            Assert.AreEqual(TestMobileNumber.Mobilenumber, SomeData);
        }
        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "an";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "and";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMinPlussOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "anhu";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "ertyudfghjcvbnm";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "ertyudfghjcvbnmk";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "ertyudfghjcvbnmkj";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "ertyudfg";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "ertyudfghjcvbnmhjuhgtyuik";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ne";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "nde";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMinPlussOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ndhe";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnm";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnjh";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ertyudfghjcvbnjhj";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "ertyudfg";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "rtyuidfghjcvbnmtyuighjuyv";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "sdfgy";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyuh";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyuhj";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgb";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgbh";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ertyudfghjcvbnmujyhtgfredcvgbhh";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ghyujnhytghjnmkiu";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "ghyhujknmkihgfdfcvgghjjnbhyttreedfghjkik";//@hotmail.com
            string MobileNumber = "77882226121";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "2346578967";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "23465789767";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MobileMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "123456543213";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "1234567653";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "02345678346";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void MobileMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "123456789765";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "254678";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
        [TestMethod]
        public void MobileExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //declare a variable to store the result of the validation
            Boolean Ok;
            //create some test data
            string FirstName = "aneeka";
            string LastName = "neee";
            string EmailAddress = "aneeka@hotmail.com";
            string MobileNumber = "234567845987654";
            //invoke the method
            Ok = AStaff.Valid(EmailAddress, FirstName, LastName, MobileNumber);
            //test to see if the valid method works
            Assert.IsFalse(Ok);
        }
    }
}
