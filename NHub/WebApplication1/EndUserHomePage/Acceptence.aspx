<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Acceptence.aspx.cs" Inherits="WebApplication1.EndUserHomePage.Acceptence" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p>
        <br />
    </p>
    <p class="text-center">
        Are you sure you want to add this notification</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        &nbsp;</p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sure" Width="97px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="105px" />
    </p>



</asp:Content>
