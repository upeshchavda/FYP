<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Secure_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Final Year Project</title>
    <link rel="stylesheet" type="text/css" href="../Style1.css" />
</head>
<body>
    <h1>Final Year Projects
    </h1>
    <form id="form1" runat="server">
        <div id="loginnav">
            <p>
                You are logged in as: 
                <asp:LoginName ID="LoginName1" runat="server" />
                <a class="loggedinlink" href="changepassword.aspx">Change Password</a>
                <asp:LoginStatus ID="LoginStatus1" runat="server" CssClass="loggedinlink" />
            </p>
        </div>
    </form>

    <div id="projects">
        <p>Project List:</p>
        <a class="aProject" href="Upesh/main_index.aspx">Upesh: Student Accomodation</a>
        <a class="aProject" href="Aneeka/index.aspx">Aneeka: Student Enrollment</a>
        <a class="aProject" href="Akshay/index.aspx">Akshay: Hotel</a>
        <a class="aProject" href="Chetan/index.aspx">Chetan: Car Dealership</a>
    </div>
    <div id="caption">
        <p>
            Final Year Projects presented by:
        </p>
        <p>
            Upesh Chavda - P15186229
        </p>
        <p>
            Aneeka Naz - P15215061
        </p>
        <p>
            Akshay Hurkoo - P15200588
        </p>
        <p>
            Chetan Gohel - PXXXXXXXX
        </p>
    </div>
</body>
</html>
