
using System;

namespace ClassLibrary
{
    public class clsStudentDetails
    {
        public string AddressName { get; set; }
        public string Cityname { get; set; }
        public string Course { get; set; }
        public DateTime Datebirth { get; set; }
        public string Department { get; set; }
        public string Emailaddress { get; set; }
        public string Firstname { get; set; }
        public string Gender { get; set; }
        public string Lastname { get; set; }
        public string Mobilenumber { get; set; }
        public int Points { get; set; }
        public string Postcode { get; set; }
        public string Streetname { get; set; }
        public int StudentId { get; set; }
        public int Tuition { get; set; }


        public bool Valid(int studentId, string addressCityName, string addressName, string addressPostCode, string addressStreetName, string emailAddress, string firstName, string lastName, string mobileNumber, string gender, DateTime dateBirth)
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

            //surname validation 
            if (lastName.Length < 3)
            {
                Ok = false;
            }
            //error message
            else if (lastName.Length > 16)
            {
                Ok = false;
            }
            //end of surname validation

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
            if (mobileNumber.Length !=11)
            {
                Ok = false;
            }
            //end of mobile number validation

            //address number validation 
            if (addressName.Length < 1)
            {
                Ok = false;
            }
            //error message
            else if (addressName.Length > 4)
            {
                Ok = false;
            }
            //end of address number validation

            //address street name validation 
            if (addressStreetName.Length < 5)
            {
                Ok = false;
            }
            //error message
            else if (addressStreetName.Length > 50)
            {
                Ok = false;
            }
            //end of address street name validation

            //address city name validation 
            if (addressCityName.Length < 3)
            {
                Ok = false;
            }
            //error message
            else if (addressCityName.Length > 50)
            {
                Ok = false;
            }
            //end of address street name validation

            //address postcode validation 
            if (addressPostCode.Length < 4)
            {
                Ok = false;
            }
            //error message
            else if (addressPostCode.Length > 8)
            {
                Ok = false;
            }
            //end of address postcode validation

            //date of birth validation 
            if (dateBirth.Date < DateTime.Now.Date.AddYears(-100))
            {
                Ok = false;
            }  
            //error message
            else if (dateBirth.Date > DateTime.Now.Date.AddYears(-18))
            {
                Ok = false; 
            }
            //end of date of birth validation

            //gender validation 
            if ((gender != "male") & (gender !="female"))
            {
                Ok = false;
            }
            //end of gender validation
            return Ok;
        }

      
    }
   
}