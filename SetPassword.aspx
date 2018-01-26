<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SetPassword.aspx.cs" Inherits="SetPassword" %>
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
    <asp:Panel ID="p1" runat="server">
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav navbar-right">
        <li><a href="AdminLogin.aspx">Admin Login</a></li>
        <li><a href="UserLogin.aspx">User Login</a></li>
        
      </ul>
    </div>
        </asp:Panel>
     
  
  </div>
  </nav>

<div class="jumbotron text-center">
  <img src="image/ban.jpg"/>
</div>

<!-- Container (About Section) -->


<!-- Container (student section) -->
        <div>
            <center>
        
     
    <asp:Panel ID="Panel2" runat="server">
        <table width="80%">
            <tr><td colspan="2" style="text-align:left;">
                <asp:Label ID="Label3" runat="server" Text="Set New Password" CssClass="h1"></asp:Label></td></tr>
            <tr><td colspan="2" style="text-align:center"><hr /></td></tr>
            
            <tr><td class="labtd">
                <asp:Label ID="Label4" runat="server" Text="Enter Password" CssClass="lab"></asp:Label></td><td class="txt">
                    <asp:TextBox ID="pass" runat="server" CssClass="textb well1" required TextMode="Password"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
            <tr><td class="labtd">
                <asp:Label ID="Label5" runat="server" Text="Confirm Pasword" CssClass="lab"></asp:Label></td><td class="txt">
                    <asp:TextBox ID="cpass" runat="server" CssClass="textb well1"  required  TextMode="Password"></asp:TextBox></td></tr>
           <tr><td class="auto-style1"></td><td class="txt">
               <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Pasword does not match" ControlToValidate="cpass" ForeColor="Red" ControlToCompare="pass"></asp:CompareValidator></td></tr>
              <tr><td colspan="2" align="center">
                  <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click" /></td></tr>
              <tr><td colspan="2"><br /></td></tr>
        </table>

    </asp:Panel>
        </center>
        </div>

        <!-- Container (Visitor Section) -->
   
    </form>
    <div class="modal-footer" style="background-color:cadetblue;text-align:right;font-family:Arial;color:white">@Copyright Student Grade Prediction Using C4.5 Decision Tree</div>
</body>
</html>

