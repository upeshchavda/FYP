using ClassLibrary_Upesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure_Upesh_Management_Office_aStudent : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StudentID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        StudentID = Convert.ToInt32(Session["StudentID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StudentID != -1)
            {
                //display the current data for the record
                DisplayStudent();
            }
        }
    }

    void DisplayStudent()
    {
        //create an instance of the Student Collection
        clsStudentCollection studentCollection = new clsStudentCollection();
        //find the record to update
        studentCollection.ThisStudent.Find(StudentID);
        //display the data for this record
        txtStudentID.Text = studentCollection.ThisStudent.StudentID.ToString() ;
        txtFirstName.Text = studentCollection.ThisStudent.FirstName;
        txtLastName.Text = studentCollection.ThisStudent.LastName;
        txtAddressLine1.Text = studentCollection.ThisStudent.AddressLine1;
        txtAddressLine2.Text = studentCollection.ThisStudent.AddressLine2;
        txtCity.Text = studentCollection.ThisStudent.City;
        txtTelephone.Text = studentCollection.ThisStudent.Telephone;
        txtEmail.Text = studentCollection.ThisStudent.Email;
        calDOB.SelectedDate = studentCollection.ThisStudent.DateOfBirth;
        

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Default.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (StudentID == -1)
        {
            //add the new record
            //Add();
        }
        else
        {
            //update the record
            //Update();
        }
        //all done so redirect back to the main page
        Response.Redirect("Default.aspx");
    }

}