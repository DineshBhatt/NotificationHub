<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventDeclinedPage.aspx.cs" Inherits="WebApplication1.Approval.EventDeclinedPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p class="text-center" style="font-family: Arial; font-size: large; color: #000000">
        <strong>Are you sure you want to Delete this Template</strong></p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" BackColor="Black" CssClass="col-xs-offset-0" Height="41px" OnClick="Button1_Click" style="font-family: Arial; font-size: 11pt; color: #FFFFFF; font-weight: bold" Text="Yes" Width="72px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" BackColor="Black" Height="39px" OnClick="Button2_Click" style="font-family: Arial; font-weight: bold; font-size: 11pt; color: #FFFFFF" Text="Cancel" Width="86px" />
    </p>
    <p>
    </p>



</asp:Content>
