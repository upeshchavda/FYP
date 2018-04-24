<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rooms.aspx.cs" Inherits="Secure_Upesh_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>nid-a Rooms - Student Accomodation</title>
    <link href="/Secure/Upesh/scripts/FYP.css" rel="stylesheet" />

</head>
<body>
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
                <br />
                <div class="slideshow-container">
                    <div class="mySlides fade">
                        <img src="images/room1.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room2.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room3.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room4.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room5.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room6.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room7.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room8.jpg" style="width: 50%" />
                    </div>

                    <div class="mySlides fade">
                        <img src="images/room9.jpg" style="width: 50%" />
                    </div>
                </div>

                <p class="center">Our rooms are filled with modern designer suites, with fashionable kitchens and communal areas. </p>

                <footer id="location">
                    <p>You are here: Rooms</p>
                </footer>


                <script>
                    var slideIndex = 0;
                    showSlides();

                    function showSlides() {
                        var i;
                        var slides = document.getElementsByClassName("mySlides");
                        for (i = 0; i < slides.length; i++) {
                            slides[i].style.display = "none";
                        }
                        slideIndex++;
                        if (slideIndex > slides.length) { slideIndex = 1 }

                        slides[slideIndex - 1].style.display = "block";
                        setTimeout(showSlides, 1500); // Change image every 2 seconds
                    }
                </script>
            </div>
        </div>
    </form>
</body>
</html>
