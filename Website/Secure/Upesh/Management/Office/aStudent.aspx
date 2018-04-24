<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aStudent.aspx.cs" Inherits="Secure_Upesh_Management_Office_aStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>nid-a Rooms - Student Accomodation</title>
    <link href="/Secure/Upesh/scripts/FYP.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="logo">
                <h1 id="master_Title" style="float: right; margin-right: 30%">- Student Accomodation</h1>
                <img src="/Secure/Upesh/images/nida_logo_main.png" id="master_logo" style="width: 300px; margin-left: 27%" />
            </div>
            <nav class="topnav">
                <a href="/Secure/Upesh/main_index.aspx">Home</a>
                <a href="/Secure/Upesh/aboutus.aspx">About Us</a>
                <a href="/Secure/Upesh/rooms.aspx">Rooms</a>
                <a href="/Secure/Upesh/Users/users_index.aspx">Student</a>
                <a href="/Secure/Upesh/Management/staff_index.aspx">Staff</a>
                <asp:LoginStatus ID="LoginStatus1" runat="server" Style="float: right" />
            </nav>
            <div id="master_Content">
                <h1>Office Staff</h1>

                <p class="center">Here you are able to create, edit, and delete students, as well as view records for each student.</p>

                <table>
                    <tr>
                        <td>Student ID</td>
                        <td><asp:TextBox ID="txtStudentID" runat="server" Enabled="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>First Name</td>
                        <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Last Name</td>
                        <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Address Line 1</td>
                        <td><asp:TextBox ID="txtAddressLine1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Address Line 2</td>
                        <td><asp:TextBox ID="txtAddressLine2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>City</td>
                        <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Postal Code</td>
                        <td><asp:TextBox ID="txtPostCode" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Email Address</td>
                        <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Telephone Number</td>
                        <td><asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>DOB </td>
                        <td><asp:Calendar ID="calDOB" runat="server"></asp:Calendar>                        </td>
                    </tr>
                    <tr>
                        <td><asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" Width="99px" /> <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="91px" /></td>
                    </tr>
                </table>
                
                <p>Date of birth needs to be in the format of '1900-12-31'. With the quote and dash.</p>
                
                <footer id="location">
                    <p>You are here: Home/Staff/Office</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
