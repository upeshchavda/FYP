<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aboutus.aspx.cs" Inherits="Secure_Upesh_Default" %>

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
                <h1 id="content_title">About Us</h1>
                <p>We are Nid-a.</p>
                <p>Focusing on the most modern and contemporary designer suites and flats for students to live in. No longer do you need to worry about small box rooms, you can now sit back and relax in your fashionable apartment.</p>
                <p>In the heart of Leicester, we provide you with a luxury student accomodation, fulfiled with your own en-suite, kitchen area and communal living spaces Get free access to your own on-site gym, cinema room and bar, or relax in our outdoor seating area, perfect for them summer BBQ's!</p>
                <p>Prices for flats are from just £99.00 per week, and are fully inclusive with all on-site amenities. Place your £5.00 deposit now to secure the flat of your future, call us or email us today for more information.</p>


                <footer id="location">
                    <p>You are here: About-Us</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
