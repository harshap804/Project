<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>
<asp:Content ID="body" ContentPlaceHolderID="body" runat="server">
    <center>
        <table width="80%">
            <tr><td colspan="2"><asp:Label ID="Label1" runat="server" Text="Add Feedback" CssClass="hlabel"></asp:Label></td></tr>
            <tr><td colspan="2"><hr /></td></tr>
            <tr><td class="tdlab" style="vertical-align:top"><asp:Label ID="Label2" runat="server" Text="Feedback" CssClass="lab"></asp:Label></td><td class="tdtext"><asp:TextBox ID="feed" runat="server" required CssClass="form-control" Height="300px" TextMode="MultiLine" Width="283px"></asp:TextBox></td></tr>
            <tr><td colspan="2"><br /></td></tr>
            <tr><td colspan="2" style="text-align:center"><asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click"></asp:Button></td></tr>
            </table>
    </center>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
