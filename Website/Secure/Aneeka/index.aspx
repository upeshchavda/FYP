<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Online Registration</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
        <h1>Welcome All Students</h1>
    </div>
        <div id="navbar">
            <nav>
                <a> <a class="links" href="AddMyProfile.aspx"> Add My Profile </a> 
                    <a class="links" href="StaffPage.aspx"> Staff Members</a>
                </a>                  
            </nav>
        </div>

        <p>
        We would like to this opportunity to welcome our students to the online registration system.
        <br/>Here you will be asked to enter your personal details, in order to complete your University application.
        <br/> The details we require are there to help us build your own individual profile and set up your account.</p>
        <p>
        As a student you need to complete a further registertion process, you can do this by clicking on "Add my profile". 
        </p>

     
    </div>
    </form>
</body>
</html>

