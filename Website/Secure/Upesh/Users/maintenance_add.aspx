<%@ Page Language="C#" AutoEventWireup="true" CodeFile="maintenance_add.aspx.cs" Inherits="Secure_Upesh_Users_maintenance_add" %>

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
                <h1>Add Maintenance Request</h1>

                <p>Personal ID:       
                    <asp:TextBox ID="txtStudent_Maintenance_AddPersonalID" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Issue Description: 
                    <asp:TextBox ID="txtStudent_Maintenance_AddDescription" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Issue Location:    
                    <asp:TextBox ID="txtStudent_Maintenance_AddLocation" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Date of Attendance:
                    <asp:TextBox ID="txtStudent_Maintenance_AddDate" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Prefered Time:     
                    <asp:TextBox ID="txtStudent_Maintenance_AddTime" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>


                <footer id="location">
                    <p>You are here: Home/Students/Add_Maintenance_Request</p>
                </footer>

            </div>
        </div>
    </form>
</body>
</html>
