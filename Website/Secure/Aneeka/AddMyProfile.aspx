<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddMyProfile.aspx.cs" Inherits="AddMyProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Online Registration</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Here you need to add extra personal information for your own profile</h2>

        <asp:Label ID="lblEmail" runat="server" Text="Enter Your Email Address"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMobile" runat="server" Text="Enter your mobile number"></asp:Label>
        <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressName" runat="server" Text="Enter Your Address Name/Door Number"></asp:Label>
        <asp:TextBox ID="TxtAddressName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressStreet" runat="server" Text="Enter Your Address Street Name"></asp:Label>
        <asp:TextBox ID="TxtAddressStreet" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressCity" runat="server" Text="Enter Your City Name"></asp:Label>
        <asp:TextBox ID="txtAddressCity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddressPostcode" runat="server" Text="Enter Your Address Postcode"></asp:Label>
        <asp:TextBox ID="txtAddressPostcode" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblBirth" runat="server" Text="Enter Your Date of Birth"></asp:Label>
        <asp:TextBox ID="txtBirth" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblGender" runat="server" Text="Enter Your Gender"></asp:Label>
        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        <br />
        <br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" Text="Submit Details" />

    </div>
    </form>
</body>
</html>
