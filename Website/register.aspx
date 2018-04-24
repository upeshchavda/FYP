<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up - Final Year Project</title>
        <link rel="stylesheet" type="text/css" href="Style1.css" />

</head>
<body>
    <form id="form1" runat="server">
        <h1>Sign Up Here</h1>
    <div style="text-align: center;">
            <div style="width: 400px; margin-left: auto; margin-right: auto;">
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="Login.aspx" DisplayCancelButton="True" EnableTheming="True" Height="427px" LoginCreatedUser="False" Width="400px" BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" TitleTextStyle-BackColor="#FF4800" CancelDestinationPageUrl="login.aspx" AutoGeneratePassword="False">
            <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <TitleTextStyle BackColor="#FF4800" Font-Bold="True" ForeColor="White" />
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server">
                    <ContentTemplate>
                        <table>
                            <tr>
                                <td align="center" colspan="2">Complete</td>
                            </tr>
                            <tr>
                                <td>Your account has been successfully created.</td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="ContinueButton" runat="server" CausesValidation="False" CommandName="Continue" Text="Continue" ValidationGroup="CreateUserWizard1" />
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CompleteWizardStep>
            </WizardSteps>
            <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
            <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" ForeColor="#284775" />
            <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
            <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" VerticalAlign="Top" />
            <StepStyle BorderWidth="0px" />
        </asp:CreateUserWizard>
    </div>
    </div>
    </form>
</body>
</html>
