<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inventory.aspx.cs" Inherits="Secure_Upesh_Users_inventory" %>

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

                <footer id="location">
                    <p>You are here: Home/Students/Inventory_Check</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
