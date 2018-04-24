<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPage.aspx.cs" Inherits="StaffPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Student Online Registration</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>This page is for staff access only</h2>

    </div>

        <asp:DropDownList ID="DropDownList1" runat="server" Height="50px" Width="130px">
            <asp:ListItem>STUDENT 1</asp:ListItem>
            <asp:ListItem>STUDENT 2</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnAccept" runat="server" Text="Accept this student" />
       
    </form>
</body>
</html>
