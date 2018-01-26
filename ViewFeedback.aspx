<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ViewFeedback.aspx.cs" Inherits="ViewFeedback" %>

<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
    <table width="80%">
    <tr><td><br /></td></tr>
<tr>
<td align="center"> <asp:Label ID="Label1" runat="server" Text="View FeedBack" 
        Font-Size="Larger" Font-Bold="True" ForeColor="#666666" CssClass="hlabel"></asp:Label></td></td>

</tr>
<tr><td><hr /></td></tr>
<tr><td>
    <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center" 
        Width="80%" AutoGenerateColumns="False" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
                <asp:BoundField HeaderText="Student ID" DataField="sid"/>
                <asp:BoundField HeaderText="FeedBack" DataField="Feed"/>
                <asp:BoundField HeaderText="Date" DataField="Date" />
                <asp:BoundField HeaderText="Time" DataField="Time" />
               
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
        <br />
        <br />
    </center>
</asp:Content>