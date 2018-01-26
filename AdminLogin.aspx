<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>
<!DOCTYPE html>

<html lang="en">
<head>
  <title>Student Grade Prediction USing C4.5 Decision Tree</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
  <link rel="stylesheet" type="text/css" href="css/design.css">
  
  </head>

<body id="myPage" data-spy="scroll" data-target=".navbar" data-offset="60">
    <form runat="server">
<nav class="navbar navbar-default navbar-fixed-top">
  <div class="container">
    
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span> 
      </button>
     
    </div>
    
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav navbar-right">
        <li><a href="AdminLogin.aspx">Admin login</a></li>
        <li><a href="UserLogin.aspx">User Login</a></li>
      
      </ul>
    </div>
  
  </div>
  </nav>

<div class="jumbotron text-center">
  <img src="image/ban.jpg"/>
</div>

<!-- Container (About Section) -->


<!-- Container (student section) -->
        <div>
            <center>
            <table style="width:40%" class="table-condensed table-bordered">
            <tr><td style="text-align:center; background-color:dimgray"><h3 style="color: #FFFFFF; font-size: xx-large; font-weight: bolder; font-family: 'Times New Roman', Times, serif;">Admin Login</h3></td></tr>
            <tr><td style="padding: 10px; text-align:center"><asp:TextBox ID="aid" runat="server" CssClass="form-control" Placeholder="Admin ID" required></asp:TextBox></td></tr>
             <tr><td style="padding: 10px; text-align:center" class="auto-style1"><asp:TextBox ID="password" runat="server" CssClass="form-control" Placeholder="Password" required TextMode="Password"></asp:TextBox></td></tr>
            <tr><td style="padding: 12px; text-align:center"><asp:Button ID="Button2" runat="server" Text="Login" CssClass="button" OnClick="Button1_Click"></asp:Button></td></tr>
            <tr><td colspan="2" style="text-align:center">&nbsp;</td></tr>
            </table>
         
        </center>
        </div>
        <br /><br />
        <!-- Container (Visitor Section) -->
   
    </form>
    <div class="modal-footer" style="background-color:cadetblue;text-align:right;font-family:Arial;color:white">@Copyright Student Grade Prediction Using C4.5 Decision Tree</div>
</body>
</html>


