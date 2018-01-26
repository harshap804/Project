<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Add_Students.aspx.cs" Inherits="Add_Students" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">

    <center>
        <table width="80%">
            <tr><td colspan="2"><asp:Label ID="Label1" runat="server" Text="Add Students" CssClass="hlabel"></asp:Label></td></tr>
            <tr><td colspan="2"><hr /></td></tr>
            <tr><td class="tdlab"><asp:Label ID="Label2" runat="server" Text="Name" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="Name" runat="server" required CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
             <tr><td class="tdlab"><asp:Label ID="Label3" runat="server" Text="E-Mail ID" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="email" runat="server" required CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td><br /></td><td class="tdtext"><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid E-Mail ID" ControlToValidate="email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td></tr>
             <tr><td class="tdlab"><asp:Label ID="Label4" runat="server" Text="Mobile Number" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="mobile" runat="server" required CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td><br /></td><td class="tdtext"><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Mobile Number" ControlToValidate="mobile" ForeColor="Red" ValidationExpression="^[7-9]\d{9}$"></asp:RegularExpressionValidator></td></tr>
             <tr><td class="tdlab"><asp:Label ID="Label5" runat="server" Text="Username" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="uname" runat="server" required CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td><br /></td><td class="tdtext">
                <asp:Label ID="Label25" runat="server" ForeColor="Red"></asp:Label>
                </td></tr>
             <tr><td class="tdlab"><asp:Label ID="Label6" runat="server" Text="Password" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="password" runat="server" required TextMode="Password" CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
              
            </table>
         
        <table width="100%">
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="button"></asp:Button></td></tr>
            </table>
       

    </center>


</asp:Content>