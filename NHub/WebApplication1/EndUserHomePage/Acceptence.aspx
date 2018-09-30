<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Acceptence.aspx.cs" Inherits="WebApplication1.EndUserHomePage.Acceptence" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p>
        <br />
    </p>
    <p class="text-center">
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p class="text-center">
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="16px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" style="margin-left: 376px" Width="160px">
        </asp:CheckBoxList>
    </p>
    <p class="text-center">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sure" Width="97px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="105px" />
    </p>



</asp:Content>
