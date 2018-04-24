<%@ Page Language="C#" AutoEventWireup="true" CodeFile="payments_secure.aspx.cs" Inherits="Secure_Upesh_Users_payments_secure_new" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>nid-a Rooms - Student Accomodation</title>
    <link href="/Secure/Upesh/scripts/FYP.css" rel="stylesheet" />

</head>
<body>
    <% 
        //declare variables from previous screen
        string text01 = Request.Form["Pay01"];
        string text02 = Request.Form["Pay02"];
        string text03 = Request.Form["Pay03"];
        string text04 = Request.Form["Pay04"];
        string textID = Request.Form["PersonalID"];

        decimal pay01;
        decimal pay02;
        decimal pay03;
        decimal pay04;
        int numberUnchecked = 0;

        if(textID == "")
        {
            textID = "Please enter your own personal ID. <br/>";
            btnSubmit.Enabled = false;
            lblIDError.Text = textID;
            lblIDError.ForeColor = System.Drawing.Color.Red;
        }
        else { }


        if (text01 == "true")
        {
            pay01 = 1320.00m;
        }
        else
        {
            pay01 = 0;
            numberUnchecked = numberUnchecked + 1;
        }
        if (text02 == "true")
        {
            pay02 = 1320.00m;
        }
        else
        {
            pay02 = 0;
            numberUnchecked = numberUnchecked + 1;
        }
        if (text03 == "true")
        {
            pay03 = 1320.00m;
        }
        else
        {
            pay03 = 0;
            numberUnchecked = numberUnchecked + 1;
        }
        if (text04 == "true")
        {
            pay04 = 960.00m;
        }
        else
        {
            pay04 = 0;
            numberUnchecked = numberUnchecked + 1;
        }

        if (numberUnchecked == 4)
        {
            lblToPay.Text = "Please select payments";
            lblTotal.Text = "£0.00";
            btnSubmit.Enabled = false;
            lblToPay.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            lblToPay.Text = "Your selected payments today comes to: £" + Convert.ToString(pay01 + pay02 + pay03 + pay04);
            lblTotal.Text = "£" + Convert.ToString(pay01 + pay02 + pay03 + pay04);
        }



    %>
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
                <h1>Payment Details</h1>

                <p>
                    <asp:Label runat="server" ID="lblIDError"></asp:Label>
                    <asp:Label runat="server" ID="lblToPay"></asp:Label>
                </p>

                <table>
                    <tr>
                        <td>Cardholders Name:</td>
                        <td>
                            <asp:TextBox ID="txtCardholder" runat="server" Width="282px" MaxLength="40"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Payment Card Number:</td>
                        <td>
                            <asp:TextBox ID="txtCardNo" runat="server" Width="282px" MaxLength="16"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Expiry Date: </td>
                        <td>
                            <asp:TextBox ID="txtExpiry" runat="server" Width="94px" MaxLength="5"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>CVV2:</td>
                        <td>
                            <asp:TextBox ID="txtCVV" runat="server" Width="282px" MaxLength="4"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Please debit my account with:
                            <asp:Label runat="server" ID="lblTotal"></asp:Label></td>
                        <td>
                            <asp:Button runat="server" ID="btnSubmit" Text="Submit" /></td>
                    </tr>
                </table>


                <footer id="location">
                    <p>You are here: Home/Students/Payments</p>
                </footer>
            </div>
        </div>
    </form>
</body>
</html>
