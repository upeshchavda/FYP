<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login - Final Year Project</title>
    <link rel="stylesheet" type="text/css" href="Style1.css" />
</head>
<body class="centre" style="text-align: center;">
    <h1>Final Year Projects</h1>
    <form id="form1" runat="server">
        <a class="loginlink" href="register.aspx">Register</a>
        <div style="text-align: center;">
            <div style="width: 300px; margin-left: auto; margin-right: auto;">
                <asp:Login ID="Login" runat="server" DestinationPageUrl="Secure/index.aspx" PasswordRecoveryText="Forgotten Password?" PasswordRecoveryUrl="passwordrecovery.aspx" RememberMeText="Remember details for next time?" Font-Names="Calibri" Font-Size="0.8em" TextLayout="TextOnTop" Style="margin-right: 0px; margin-top: 25px; margin-left: 0px;" Width="300px" TabIndex="1">
                    <HyperLinkStyle Font-Size="Small" ForeColor="#FF4800" />
                    <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                    <LabelStyle Font-Size="Small" />
                    <FailureTextStyle BackColor="#FF6666" Font-Bold="True" ForeColor="White" />
                    <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="Small" ForeColor="#284775" Height="30px" Width="60px" />
                    <TextBoxStyle Font-Size="Small" />
                    <TitleTextStyle BackColor="#FF4800" Font-Bold="True" Font-Size="X-Large" ForeColor="White" />
                </asp:Login>
            </div>
        </div>
    </form>
    <footer>
        <table class="centretable" >
            <tr>
                <th>Role</th>
                <th>Username</th>
                <th>Password</th>
            </tr>
            <tr>
                <td>User</td>
                <td>user1</td>
                <td>UserAccount1.</td>
            </tr>
            <tr>
                <td class="auto-style1">Staff</td>
                <td class="auto-style1">management</td>
                <td class="auto-style1">Manager1.</td>
            </tr>
            <tr>
                <td class="auto-style1">Staff</td>
                <td class="auto-style1">maintenance</td>
                <td class="auto-style1">Maintenance1.</td>
            </tr>
            <tr>
                <td class="auto-style1">Staff</td>
                <td class="auto-style1">office</td>
                <td class="auto-style1">Office1.</td>
            </tr>
        </table>
    </footer>
</body>
</html>
