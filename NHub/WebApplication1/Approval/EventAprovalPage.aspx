<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventAprovalPage.aspx.cs" Inherits="WebApplication1.Approval.EventAprovalPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="text-center" style="font-family: Arial; color: #008080; font-weight: normal">
        Confirmation</h1>
    <h1 class="text-center" style="font-family: Arial; color: #008080; font-weight: normal">
        <span style="font-size: large; font-family: &quot;Segoe UI&quot;; mso-ascii-font-family: &quot;Segoe UI&quot;; mso-fareast-font-family: +mn-ea; mso-bidi-font-family: &quot;Segoe UI&quot;; mso-fareast-theme-font: minor-fareast; color: black; mso-color-index: 1; mso-font-kerning: 12.0pt; language: en-US; mso-style-textfill-type: solid; mso-style-textfill-fill-themecolor: text1; mso-style-textfill-fill-color: black; mso-style-textfill-fill-alpha: 100.0%"><strong>Are you sure you want to approve template<%# Eval("Name") %></strong></span></h1>
    <h1 class="text-center" style="font-family: Arial; color: #008080; font-weight: normal">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yes" Width="141px" BackColor="Black" style="font-family: Arial; font-weight: bold; font-size: 11pt; color: #FFFFFF" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CssClass="col-xs-offset-0" OnClick="Button2_Click" Text="Cancel" Width="161px" BackColor="Black" style="font-family: Arial; font-weight: bold; font-size: 11pt; color: #FFFFFF" />
    </h1>
</asp:Content>
