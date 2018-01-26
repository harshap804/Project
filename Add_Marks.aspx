<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Add_Marks.aspx.cs" Inherits="Add_Marks" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="80%">
        <tr><td colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Add Marks Details" CssClass="hlabel"></asp:Label></td></tr>
        <tr><td colspan="2"><hr /></td></tr>
        <tr><td class="tdlab">
            <asp:Label ID="Label2" runat="server" Text="Student Username" CssClass="lab"></asp:Label></td><td class="tdtext">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList></td></tr>
        <tr><td colspan="2"><br /></td></tr>
        <tr><td class="tdlab"><asp:Label ID="Label7" runat="server" Text="Highest Qualification" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control">
                    <asp:ListItem>--Select--</asp:ListItem>
                    <asp:ListItem>Graduation</asp:ListItem>
                    <asp:ListItem>Post-Graduation</asp:ListItem>
                    </asp:DropDownList></td></tr>
            <tr><td colspan="2"><br /></td></tr>
             
                <tr><td class="tdlab"><asp:Label ID="Label24" runat="server" Text="Current Semester" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" CssClass="form-control">
                    <asp:ListItem>--Select--</asp:ListItem>
                    
                    </asp:DropDownList></td></tr>
          <tr><td colspan="2"><br /></td></tr>
        <tr><td colspan="2" style="text-align:center">
            &nbsp;</td></tr>
        <tr><td colspan="2"><br /></td></tr>
    </table>

    <asp:Panel ID="Panel17" runat="server">
    <table width="80%">
      
          
        </table>
        </asp:Panel>
    <asp:Panel ID="Panel1" runat="server">
        <center>
             <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label8" runat="server" Text="SSC" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="sscmarks" runat="server" placeholder="Marks" required CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="sscpercent" runat="server" placeholder="Percentage"  required CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="3"><br /></td></tr></table>
        </center>
         </asp:Panel>
               <asp:Panel ID="Panel2" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label9" runat="server" Text="HSC" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="hscmarks" runat="server" placeholder="Marks"  required CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="hscpercent" runat="server" placeholder="Percentage"  required CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="3"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel3" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label10" runat="server" Text="Graduation Sem 1" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g1marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g1cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table>
                       </center>

         </asp:Panel>
               <asp:Panel ID="Panel4" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label11" runat="server" Text="Graduation Sem 2" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g2marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g2cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel5" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label12" runat="server" Text="Graduation Sem 3" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g3marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g3cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table>
                       </center>

         </asp:Panel>
               <asp:Panel ID="Panel6" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label13" runat="server" Text="Graduation Sem 4" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g4marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g4cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table>
                       </center>

         </asp:Panel>
               <asp:Panel ID="Panel7" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label14" runat="server" Text="Graduation Sem 5" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g5marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g5cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table>
                       </center>

         </asp:Panel>
               <asp:Panel ID="Panel8" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label15" runat="server" Text="Graduation Sem 6" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g6marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g6cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table>
                       </center>

         </asp:Panel>
               <asp:Panel ID="Panel9" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label16" runat="server" Text="Graduation Sem 7" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g7marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g7cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel10" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label17" runat="server" Text="Graduation Sem 8" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="g8marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="g8cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel11" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label18" runat="server" Text="Post Graduation Sem 1" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="p1marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p1cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel12" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label19" runat="server" Text="Post Graduation Sem 2" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="p2marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p2cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel13" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label20" runat="server" Text="Post Graduation Sem 3" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="p3marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p3cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
               <asp:Panel ID="Panel14" runat="server">
                   <center>
                   <table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label21" runat="server" Text="Post Graduation Sem 4" CssClass="lab"></asp:Label></td><td>
                     <asp:TextBox ID="p4marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p4cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>
                   </asp:Panel>
                      <asp:Panel ID="Panel15" runat="server">
                          <center>
<table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label22" runat="server"  Text="Post Graduation Sem 5" CssClass="lab"></asp:Label></td><td class="tdtext">
                     <asp:TextBox ID="p5marks" runat="server" placeholder="Marks" CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p5cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         </asp:Panel>
                      <asp:Panel ID="Panel16" runat="server">
                          <center>
<table width="60%">
                 <tr><td class="tdlab"><asp:Label ID="Label23" runat="server" Text="Post Graduation Sem 6" CssClass="lab"></asp:Label></td><td>
                     <asp:TextBox ID="p6marks" runat="server" placeholder="Marks"  CssClass="form-control"></asp:TextBox>
                     </td><td>
                     <asp:TextBox ID="p6cgpi" runat="server" placeholder="Percentage" CssClass="form-control"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="2"><br /></td></tr></table></center>

         
         </asp:Panel>
    <table><tr><td align="center">
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" CssClass="button" /></td></tr></table>
        </center>
</asp:Content>
