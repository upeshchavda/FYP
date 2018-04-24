using ClassLibrary_Upesh;
using System;

namespace ClassLibrary_Upesh
{
    public class clsStudent
    {
        private Int32 mStudentID;
        private string mFirstName;
        private string mLastName;
        private string mAddressLine1;
        private string mAddressLine2;
        private string mCity;
        private string mPostCode;
        private string mEmail;
        private string mTelephone;
        private DateTime mDateOfBirth;

        public string AddressLine1
        {
            get
            {
                return mAddressLine1;
            }
            set
            {
                mAddressLine1 = value;
            }
        }
        public string AddressLine2
        {
            get
            {
                return mAddressLine2;
            }
            set
            {
                mAddressLine2 = value;
            }
        }
        public string City
        {
            get
            {
                return mCity;
            }
            set
            {
                mCity = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }
        public int StudentID {
            get
            {
                return mStudentID;
            }
            set
            {
                mStudentID = value;
            }
        }
        public string Telephone
        {
            get
            {
                return mTelephone;
            }
            set
            {
                mTelephone = value;
            }
        }

        public bool Valid(Int32 studentID, string firstName, string lastName, string addressLine1, string addressLine2, string city, string postCode, DateTime dateOfBirth, string telephone, string email)
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

        public bool Find(int StudentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@personID", StudentID);
            //execute the stored procedure
            DB.Execute("sproc_FilterByPersonID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                StudentID = Convert.ToInt32(DB.DataTable.Rows[0]["personID"]);
                FirstName = Convert.ToString(DB.DataTable.Rows[0]["firstName"]);
                LastName = Convert.ToString(DB.DataTable.Rows[0]["lastName"]);
                AddressLine1 = Convert.ToString(DB.DataTable.Rows[0]["addressLine1"]);
                AddressLine2 = Convert.ToString(DB.DataTable.Rows[0]["addressLine2"]);
                City = Convert.ToString(DB.DataTable.Rows[0]["city"]);
                PostCode = Convert.ToString(DB.DataTable.Rows[0]["postCode"]);
                DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOfBirth"]);
                Email = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                Telephone = Convert.ToString(DB.DataTable.Rows[0]["telephone"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}