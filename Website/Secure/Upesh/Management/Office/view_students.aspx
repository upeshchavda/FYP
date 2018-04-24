<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view_students.aspx.cs" Inherits="Secure_Upesh_Default" %>

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

                <asp:ListBox ID="lstStudents" runat="server" Width="100%"></asp:ListBox>
                <asp:Button ID="btnAdd" runat="server" Text="Add Student" Style="margin: 0 5px" OnClick="btnAdd_Click"/>
                <asp:Button ID="btnEdit" runat="server" Text="Edit Student" Style="margin: 0 5px"/>
                <asp:Button ID="btnDelete" runat="server" Text="Delete Student" Style="margin: 0 5px"/>
                
                <footer id="location">
                    <p>You are here: Home/Staff/Office</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
