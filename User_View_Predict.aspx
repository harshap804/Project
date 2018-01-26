<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="User_View_Predict.aspx.cs" Inherits="User_View_Predict" %>


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
               
          
                </Columns>


            </asp:GridView></td></tr>
        <tr><td colspan="2"><br /></td></tr>
        <tr><td colspan="2" style="text-align:center">
            <asp:Label ID="Label2" runat="server" Font-Size="Large"></asp:Label></td></tr>
    </table>
    

    </center>
    
    <asp:Panel ID="Panel1" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="ssch" runat="server" CssClass="lab">SSC</asp:Label></td><td class="tdtext">
                    <asp:Label ID="sscl" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel2" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="hsch" runat="server" CssClass="lab">HSC</asp:Label></td><td class="tdtext">
                    <asp:Label ID="hscl" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel3" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g1h" runat="server" CssClass="lab">Graduation Sem 1</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g1l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel4" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g2h" runat="server" CssClass="lab">Graduation Sem 2</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g2l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>

    </asp:Panel>
     <asp:Panel ID="Panel5" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g3h" runat="server" CssClass="lab">Graduation Sem 3</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g3l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel6" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g4h" runat="server" CssClass="lab">Graduation Sem 4</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g4l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel7" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g5h" runat="server" CssClass="lab">Graduation Sem 5</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g5l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel8" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g6h" runat="server" CssClass="lab">Graduation Sem 6</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g6l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel9" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g7h" runat="server" CssClass="lab">Graduation Sem 7</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g7l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel10" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="g8h" runat="server" CssClass="lab">Graduation Sem 8</asp:Label></td><td class="tdtext">
                    <asp:Label ID="g8l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel11" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="p1h" runat="server" CssClass="lab">Post Graduation Sem 1</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p1l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel12" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="p2h" runat="server" CssClass="lab">Post Graduation Sem 2</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p2l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel13" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="p3h" runat="server" CssClass="lab">Post Graduation Sem 3</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p3l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel14" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="p4h" runat="server" CssClass="lab">Post Graduation Sem 4</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p4l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel15" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="p5h" runat="server" CssClass="lab">Post Graduation Sem 5</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p5l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel16" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="Label33" runat="server" CssClass="lab">Post Graduation Sem 6</asp:Label></td><td class="tdtext">
                    <asp:Label ID="p6l" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
     <asp:Panel ID="Panel17" runat="server">
        <center>
        <table width="80%">
            <tr><td class="tdlab">
                <asp:Label ID="Label35" runat="server" CssClass="lab">Expected Grade for Next Semester</asp:Label></td><td class="tdtext">
                    <asp:Label ID="expected" runat="server"></asp:Label></td></tr>
            <tr><td colspan="2"><br /></td></tr>
        </table>
        </center>
    </asp:Panel>
</asp:Content>