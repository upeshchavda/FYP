using System;

namespace ClassLibrary
{
    public class clsAdminStaff
    {
        public string Emailaddress { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobilenumber { get; set; }

        public bool Valid(string emailAddress, string firstName, string lastName, string mobileNumber)
        {
            bool Ok = true;

            //first name validation 
            if (firstName.Length < 3)
            {
                Ok = false;
            }
            //error message 
            else if (firstName.Length > 16)
            {
                Ok = false;
            }
            //end of first name validation

            //last name validation 
            if (lastName.Length < 3)
            {
                Ok = false;
            }
            //error message 
            else if (lastName.Length > 16)
            {
                Ok = false;
            }
            //end of first name validation

            //email address validation 
            if (emailAddress.Length < 5)
            {
                Ok = false;
            }
            //error message
            else if (emailAddress.Length > 30)
            {
                Ok = false;
            }
            //end of email address validation

            //mobile number validation 
            if (mobileNumber.Length != 11)
            {
                Ok = false;
            }
            //end of mobile number validation

            return Ok;
        }
    }
}