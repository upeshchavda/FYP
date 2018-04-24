<%@ Page Language="C#" AutoEventWireup="true" CodeFile="payments.aspx.cs" Inherits="Secure_Upesh_Users_payments_new" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>nid-a Rooms - Student Accomodation</title>
    <link href="/Secure/Upesh/scripts/FYP.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server" action="payments_secure.aspx" method="post">
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
                <p>To pay for your accomodation, select a payment from below an enter your Personal ID as a reference</p>
                <div style="font-size: initial; width: 35%; float: left; padding-left: 200px; padding-top: 50px;">
                    <input type="checkbox" name="pay01" value="true" />Payment 01: July 2019
                    <br/>
                    <input type="checkbox" name="pay02" value="true" />Payment 02: September 2020
                    <br/>
                    <input type="checkbox" name="pay03" value="true" />Payment 03: January 2020
                    <br/>
                    <input type="checkbox" name="pay04" value="true" />Payment 04: April 2020


                    <p>
                        Personal ID:
                        <input type="text" name="PersonalID" placeholder="00000000" />

                        
                    </p>
                    
                    <br />
                    <asp:Button ID="btnSubmit" runat="server" Text="Accept Payment" />

                </div>
                <div style="width: 45%; float: right;">
                    <strong>Payment Details:</strong>
                    <p>Payment 01 = £1320.00</p>
                    <p>Payment 01 = £1320.00</p>
                    <p>Payment 01 = £1320.00</p>
                    <p>Payment 01 = £960.00</p>

                </div>
                <footer id="location">
                    <p>You are here: Home/Students/Payments</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
