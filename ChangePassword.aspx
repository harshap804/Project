<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master"  CodeFile="ChangePassword.aspx.cs" Inherits="ForgotPassword" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
        
        <asp:Panel ID="Panel1" runat="server">
    <div>
        <table width="80%">
            <tr>
                <td colspan="2" class="auto-style1"><br /></td></tr>
               <tr> <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Change Password" CssClass="hlabel"></asp:Label></td>

            </tr>
            <tr><td colspan="2" style="text-align:center"><hr /></td></tr>
            
            <tr><td class="tdlab" style="width:50%">
                <asp:Label ID="Label2" runat="server" Text="E-Maild ID" CssClass="lab"></asp:Label></td><td class="tdtext" style="width:50%">
                    <asp:TextBox ID="em" runat="server" CssClass="form-control" required></asp:TextBox>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/image/right.png" />
                    <asp:Image ID="Image3" runat="server" ImageUrl="~/image/wrong.png" />
                </td></tr>
            <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2" align="center">
                <asp:Button ID="Button2" runat="server" Text="Check" CssClass="button" OnClick="Button2_Click" /></td></tr>
            <tr><td colspan="2">
               
                <br /></td></tr>
            
            </table>

    </div>
        </asp:Panel>
    
        </center>
    
</div>
<!-- Container (student section) -->
       

        <!-- Container (Visitor Section) -->
   
<!-- Container (parent section) -->

 </asp:Content>

