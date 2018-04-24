using ClassLibrary_Upesh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Secure_Upesh_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayStudents();
    }

    void DisplayStudents()
    {
        //create an instance of the County Collection
        clsStudentCollection students = new clsStudentCollection();
        //set the data source to the list of counties in the collection
        lstStudents.DataSource = students.StudentList;
        //set the name of the primary key
        lstStudents.DataValueField = "personID";
        //set the data field to display
        lstStudents.DataTextField = "FirstName";
        //bind the data to the list
        lstStudents.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StudentID"] = -1;
        //redirect to the data entry page
        Response.Redirect("AStudent.aspx");
    }
}