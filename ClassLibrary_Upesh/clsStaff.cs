using System;

namespace ClassLibrary_Upesh
{
    public class clsStaff
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostCode { get; set; }
        public int StaffID { get; set; }
        public string Telephone { get; set; }

        public bool Valid(Int32 StaffID, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode, DateTime dateOfBirth, string telephone, string email)
        {
            //declare a variable to see if everything is "OK"
            bool OK = true;

            //firstName Validation (Between 1 and 20 characters)
            if (firstName.Length < 1)
            {
                OK = false;
            }
            else if (firstName.Length > 20)
            {
                OK = false;
            }

            //lastName Validation (Between 1 and 20 characters)
            if (lastName.Length < 1)
            {
                OK = false;
            }
            else if (lastName.Length > 20)
            {
                OK = false;
            }

            //addressLine1 Validation (Between 1 and 20 characters)
            if (addressLine1.Length < 1)
            {
                OK = false;
            }
            else if (addressLine1.Length > 20)
            {
                OK = false;
            }

            //addressLine2 Validation (Between 1 and 20 characters)
            if (addressLine2.Length < 1)
            {
                OK = false;
            }
            else if (addressLine2.Length > 20)
            {
                OK = false;
            }

            //city Validation (Between 1 and 20 characters)
            if (city.Length < 1)
            {
                OK = false;
            }
            else if (city.Length > 20)
            {
                OK = false;
            }

            //postCode Validation (Between 5 and 8 characters)
            if (postCode.Length < 5)
            {
                OK = false;
            }
            else if (postCode.Length > 8)
            {
                OK = false;
            }

            //dateOfBirth Validation (Between 18 and 100 years in the past)
            if (dateOfBirth < DateTime.Now.AddYears(-100))
            {
                OK = false;
            }
            else if (dateOfBirth > DateTime.Now.AddYears(-18))
            {
                OK = false;
            }

            //telephone Validation (Exactly 11 digits)
            if (telephone.Length != 11)
            {
                OK = false;
            }

            //email Validation (Between 10 and 40 characters)
            if (email.Length < 10)
            {
                OK = false;
            }
            else if (email.Length > 40)
            {
                OK = false;
            }

            return OK;
        }
    }
}