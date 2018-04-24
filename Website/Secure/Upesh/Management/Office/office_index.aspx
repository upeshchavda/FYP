<%@ Page Language="C#" AutoEventWireup="true" CodeFile="office_index.aspx.cs" Inherits="Secure_Upesh_Default" %>

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

                <p class="center">Here you are able use the system as a member of the administration team.</p>

                <div id="staff_links_container">
                    <a class="staff_links" href="/Secure/Upesh/Management/Office/view_students.aspx">View Students</a>
                    <a class="staff_links" href="/Secure/Upesh/Management/Office/view_staff.aspx">View Staff</a>
                    <a class="staff_links" href="/Secure/Upesh/Management/Office/payments.aspx">View Payments</a>
                    <a class="staff_links" href="/Secure/Upesh/Management/Office/tenancies.aspx">View Tenancies</a>

                </div>

                <footer id="location">
                    <p>You are here: Home/Staff/Office</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
