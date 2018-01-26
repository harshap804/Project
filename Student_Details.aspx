<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Student_Details.aspx.cs" Inherits="Student_Details" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="80%">
        <tr><td colspan="2"><asp:Label ID="Label1" runat="server" Text="My Details" CssClass="hlabel"></asp:Label></td></tr>
        <tr><td colspan="2"><hr /></td></tr>
        <tr><td class="tdlab"><asp:Label ID="Label2" runat="server" Text="Name" CssClass="lab"></asp:Label></td><td class="tdtext">
            <asp:Label ID="Label6" runat="server"></asp:Label>
            </td></tr>
    <tr><td colspan="2"><br /></td></tr> 
         <tr><td class="tdlab"><asp:Label ID="Label3" runat="server" Text="E-Mail ID" CssClass="lab"></asp:Label></td><td class="tdtext">
             <asp:Label ID="Label7" runat="server"></asp:Label>
             </td></tr>
    <tr><td colspan="2"><br /></td></tr>  
         <tr><td class="tdlab"><asp:Label ID="Label4" runat="server" Text="Mobile Number" CssClass="lab"></asp:Label></td><td class="tdtext">
             <asp:Label ID="Label8" runat="server"></asp:Label>
             </td></tr>
    <tr><td colspan="2"><br /></td></tr>  
         <tr><td class="tdlab"><asp:Label ID="Label5" runat="server" Text="User name" CssClass="lab"></asp:Label></td><td class="tdtext">
             <asp:Label ID="Label9" runat="server"></asp:Label>
             </td></tr>
    <tr><td colspan="2"><br /></td></tr>     
    </table>
    </center>
</asp:Content>
