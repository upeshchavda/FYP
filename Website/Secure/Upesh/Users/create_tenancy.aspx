<%@ Page Language="C#" AutoEventWireup="true" CodeFile="create_tenancy.aspx.cs" Inherits="Secure_Upesh_Users_create_tenancy" %>

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
                <p>First Name:
                    <asp:TextBox ID="txtStudent_Maintenance_AddFirstName" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Last Name:
                    <asp:TextBox ID="txtStudent_Maintenance_AddLastName" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Address Line 1:
                    <asp:TextBox ID="txtStudent_Maintenance_AddAddress1" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Address Line 2:
                    <asp:TextBox ID="txtStudent_Maintenance_AddAddress2" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>City:
                    <asp:TextBox ID="txtStudent_Maintenance_AddCity" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Postal Code:
                    <asp:TextBox ID="txtStudent_Maintenance_AddPostCode" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Telephone:
                    <asp:TextBox ID="txtStudent_Maintenance_AddTelephone" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>email Address:
                    <asp:TextBox ID="txtStudent_Maintenance_AddEmail" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Date of Tenancy Start:
                    <asp:TextBox ID="txtStudent_Maintenance_AddDateOfStart" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>
                <p>Date of Tenancy End:
                    <asp:TextBox ID="txtStudent_Maintenance_AddDateOfEnd" runat="server" Width="200px" MaxLength="15"></asp:TextBox></p>


                <footer id="location">
                    <p>You are here: Home/Students/Create_A_Tenancy</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
