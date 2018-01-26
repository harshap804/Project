<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ViewEditDelete.aspx.cs" Inherits="ViewEditDelete" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <script type="text/javascript">
    function alertMessage() {


        var flag = "0";

        if (confirm('Are You Sure You Want To delete this record!')) {
            flag = "1";
            document.getElementById('<%=h1.ClientID %>').value = flag;
        }
        else {
            document.getElementById('<%=h1.ClientID %>').value = flag;
        }



    }
     
       
     
    </script>

</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
        <table width="80%">
            <tr><td colspan="2" style="text-align:center;">
                <asp:Label ID="Label1" runat="server" Text="Update Watchman Details" CssClass="hlabel"></asp:Label></td></tr>
        <tr><td colspan="2"><br /></td></tr>   
            <tr><td colspan="2" style="text-align:center">
                <asp:GridView ID="GridView1" runat="server" Width="80%" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" />
                        <asp:BoundField DataField="email" HeaderText="E-Mail" />
                <asp:BoundField DataField="mobile" HeaderText="Mobile Number" />
<asp:TemplateField>
         <ItemTemplate>

        <asp:LinkButton ID="edit" runat ="server" CommandArgument='<%#Eval("sid")%>' Text ="Edit" CommandName ="edit" ></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>
                        <asp:TemplateField>
         <ItemTemplate>

        <asp:LinkButton ID="delete" runat ="server"  CommandArgument='<%#Eval("sid")%>' Text ="Delete" CommandName ="delete" ></asp:LinkButton>
      </ItemTemplate>
    </asp:TemplateField>


                    </Columns>

                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                </asp:GridView>
            </td></tr> 
        </table>

    </center>
    <br />
    <br />
    <center>
    <asp:Panel ID="Panel1" runat="server">
        
        <table width="80%">
           <tr><td style="text-align:right;padding-left:20px;width:50%" class="tdlab">
               <asp:Label ID="Label2" runat="server" Text="Mobile Number"></asp:Label></td><td style="text-align:left;width:50%" class="tdtext">
                   <asp:TextBox ID="mobile" runat="server" CssClass="form-control"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
                       <tr><td style="text-align:right;padding-left:20px;width:50%" class="tdlab">
               <asp:Label ID="Label3" runat="server" Text="E-Mail ID"></asp:Label></td><td  style="text-align:left;width:50%" class="tdtext">
                               <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                           </td></tr>
            <tr><td colspan="2"><br />
                <asp:HiddenField ID="h1" runat="server" />
                </td></tr>
                       <tr><td colspan="2" style="text-align:center">
                           <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" CssClass="button" />
                           </td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
            

    </asp:Panel>
        </center>
</asp:Content>


