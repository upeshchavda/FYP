<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tenancies.aspx.cs" Inherits="Secure_Upesh_Users_tenancies" %>

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
                <br />
                <br />
                <p>Here you are able to manage an existing tenancy or create a new tenancy. For further details, contact the office.</p>
                <br />
                <p class="no_margin_bottom">To view your current tenancy, enter your tenancy reference number: </p>
                <asp:TextBox ID="txtStudent_Tenancy_View" runat="server" Width="300px" MaxLength="15"></asp:TextBox>
                <asp:Button ID="btnTenancy_View" runat="server" Text="View Tenancy" />
                <br />

                <p>To create a new tenancy, click <a href="create_tenancy.aspx" id="create_tenancy">here.</a></p>


                <footer id="location">
                    <p>You are here: Home/Students/Tenancies</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
