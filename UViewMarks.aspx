<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="UViewMarks.aspx.cs" Inherits="UViewMarks" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="80%">
        <tr><td>
            <asp:Label ID="Label1" runat="server" Text="View Marks With Prediction" CssClass="hlabel"></asp:Label></td></tr>
    <tr><td><hr /></td></tr>    
    <tr><td><asp:GridView ID="GridView1" runat="server" Width="100%"   OnRowCommand="GridView1_RowCommand" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
          <asp:TemplateField HeaderText ="View">
         <ItemTemplate>

        <asp:LinkButton ID="yes" runat ="server" CommandArgument='<%#Eval("sid")%>' Text ="View" CommandName ="yes" ></asp:LinkButton>
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
        <Columns>
                <asp:BoundField HeaderText="Name" DataField="name"/>
                <asp:BoundField HeaderText="Username" DataField="uname"/>
                <asp:BoundField HeaderText="SSC" DataField="sscp" />
                <asp:BoundField HeaderText="HSC" DataField="hscp" />
                <asp:BoundField HeaderText="Graduate(1)" DataField="g1c" />
                <asp:BoundField HeaderText="Graduate(2)" DataField="g2c" />
            <asp:BoundField HeaderText="Graduate(3)" DataField="g3c" />
            <asp:BoundField HeaderText="Graduate(4)" DataField="g4c" />
            <asp:BoundField HeaderText="Graduate(5)" DataField="g5c" />
            <asp:BoundField HeaderText="Graduate(6)" DataField="g6c" />
            <asp:BoundField HeaderText="Graduate(7)" DataField="g7c" />
            <asp:BoundField HeaderText="Graduate(8)" DataField="g8c" />
            <asp:BoundField HeaderText="PG(1)" DataField="p1c" />
                <asp:BoundField HeaderText="PG(2)" DataField="p2c" />
            <asp:BoundField HeaderText="PG(3)" DataField="p3c" />
            <asp:BoundField HeaderText="PG(4)" DataField="p4c" />
            <asp:BoundField HeaderText="PG(5)" DataField="p5c" />
            <asp:BoundField HeaderText="PG(6)" DataField="p6c" />
          
                </Columns>


            </asp:GridView></td></tr>
        <tr><td colspan="2"><br /></td></tr>
        <tr><td colspan="2" style="text-align:center">
            <asp:Label ID="Label2" runat="server" Font-Size="Large"></asp:Label></td></tr>
    </table>
    

    </center>

</asp:Content>
