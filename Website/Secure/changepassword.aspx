<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="Secure_changepassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Change Password - Final Year Project</title>
    <link rel="stylesheet" type="text/css" href="../Style1.css" />
</head>
<body>
    <h1>Final Year Projects</h1>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-top: 20px;">
            <div style="width: 500px; margin-left: auto; margin-right: auto;">
                <p id="passwordcaption">You are changing the password for: <asp:LoginName ID="LoginName1" runat="server" />
                </p>
                <asp:ChangePassword ID="ChangePassword1" runat="server" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" CancelDestinationPageUrl="index.aspx" ContinueDestinationPageUrl="index.aspx" Font-Names="Verdana" Font-Size="0.8em" Height="400px" PasswordLabelText="Current Password:" PasswordRecoveryText="Forgotten current password?" PasswordRecoveryUrl="../passwordrecovery.aspx" Width="500px" DisplayUserName="True">
                    <CancelButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <ChangePasswordButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <PasswordHintStyle Font-Italic="True" ForeColor="#888888" />
                    <TextBoxStyle Font-Size="0.8em" />
                    <TitleTextStyle BackColor="#FF4800" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                </asp:ChangePassword>
            </div>
        </div>
    </form>
</body>
</html>
