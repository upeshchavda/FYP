<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main_index.aspx.cs" Inherits="Secure_Upesh_Default" %>

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
                <h1 id="content_title">Welcome to Nid-a.</h1>
                <img src="images/room2.jpg" style="width: 30%; float: left; margin-right: 20px;" />
                <img src="images/room1.jpg" style="width: 30%; float: right; margin-left: 20px;" />

                <p class="center">We are here to offer the most modern and innovative student accomodation available to Student Land University.</p>
                <p class="center">Our budget service means that you will be contacted by one of our representatives upon requesting a room, to figure out the best price and plan, tailored to you.</p>
                <p class="center">Our friendly teams are based in the heart of your campus, and are experienced and knowledgeable on finding your perfect flat, whatever year you are in</p>
                <img src="images/room3.jpg" style="width: 30%; float: left; margin-right: 20px;" />
                <img src="images/room4.jpg" style="width: 30%; float: right; margin-left: 20px;" />
                <p class="center">For bicycle and vehicular owners, we are proud to say that we offer on-site parking, equipped with 24-7 security and CCTV for your peace of mind. </p>
                <p class="center">Our 'All Inclusive' packages ensure that you get the best out of your stay, with access to the on-site gym, cinema room and lounge areas.</p>
                <p>TEst</p>
                <footer id="location">
                    <p>You are here: Home</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
