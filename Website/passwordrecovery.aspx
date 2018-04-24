<%@ Page Language="C#" AutoEventWireup="true" CodeFile="passwordrecovery.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recover Password - Final Year Project</title>
        <link rel="stylesheet" type="text/css" href="Style1.css" />
</head>
<body>
    <h1>Password Recovery</h1>
    <form id="form1" runat="server">
    <div style="text-align: center;">
            <div style="width: 400px; margin-left: auto; margin-right: auto;">
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="241px" UserNameFailureText="Please check your User Name and try again." Width="400px" TitleTextStyle-BackColor="#FF4800" TitleTextStyle-HorizontalAlign="Right" OnSendingMail="PasswordRecovery1_SendingMail">
            <SubmitButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <MailDefinition CC="upesh@mailtothis.com">
            </MailDefinition>
            <SuccessTextStyle Font-Bold="True" ForeColor="#5D7B9D" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#FF4800" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
        </asp:PasswordRecovery>
    </div>
    </div>
    </form>
</body>
</html>
