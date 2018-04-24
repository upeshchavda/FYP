<%@ Page Language="C#" AutoEventWireup="true" CodeFile="users_index.aspx.cs" Inherits="Secure_Upesh_Users_users_index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>nid-a Rooms - Student Accomodation</title>
    <link href="/Secure/Upesh/scripts/FYP.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" action="payments_secure_new.aspx" method="post">
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
                <p style="padding-top: 60px;" class="center">Please select from one of the following options:</p>
                <div id="student_links_container">
                    <a class="student_links" href="tenancies.aspx">Tenancies</a>
                    <a class="student_links" href="payments.aspx">Payments</a>
                    <a class="student_links" href="maintenance.aspx">Maintenance</a>
                    <a class="student_links" href="inventory.aspx">Inventory Check</a>
                    <a class="student_links" href="personal_details.aspx">Personal Details</a>
                </div>
                <footer id="location">
                    <p>You are here: Home/Students</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
