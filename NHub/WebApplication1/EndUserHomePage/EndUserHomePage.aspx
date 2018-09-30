<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EndUserHomePage.aspx.cs" Inherits="WebApplication1.EndUserHomePage.EndUserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <span style="font-size: 18.0pt; font-family: Calibri; mso-ascii-font-family: Calibri; mso-fareast-font-family: +mn-ea; mso-bidi-font-family: +mn-cs; mso-ascii-theme-font: minor-latin; mso-fareast-theme-font: minor-fareast; mso-bidi-theme-font: minor-bidi; color: black; mso-color-index: 1; mso-font-kerning: 12.0pt; language: en-US; font-weight: bold; mso-style-textfill-type: solid; mso-style-textfill-fill-themecolor: text1; mso-style-textfill-fill-color: black; mso-style-textfill-fill-alpha: 100.0%">&nbsp;&nbsp;&nbsp;&nbsp; My Events</span></p>
<p class="text-center">
    &nbsp;</p>
    <p class="text-center">
    <%--    <%if (Context.User.IsInRole("Dinesh"))%> 
        
          <% { %>--%>

                 <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="248px" Width="773px" OnSelectedIndexChanged="GridView_SelectedIndexChanged" >
            <EditRowStyle BorderWidth="555px" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
            
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Subscribed">
                    <ItemTemplate>
                        <asp:checkbox ID="Yes" value="yes" runat="server" Text='Yes'></asp:checkbox>
                        <asp:checkbox ID="No" value="yes" runat="server" Text='No'></asp:checkbox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Channels">
                    <ItemTemplate>
                        <asp:checkbox ID="interanet" value=1 runat="server" Text='Interanet' Checked="False"></asp:checkbox>
                        <asp:checkbox ID="Email" value=2 runat="server" Text='Email'></asp:checkbox>
                        <asp:checkbox ID="UnaBot" value=3 runat="server" Text='Una Bot'></asp:checkbox>
                        <asp:checkbox ID="sms" value=4 runat="server" Text='SMS'></asp:checkbox>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Updater">
                    <ItemTemplate>
                        <asp:Hyperlink ID="Label2" runat="server" Text="Update" NavigateUrl='<%# Eval("Id","~/EndUserHomePage/Acceptence.aspx?Id={0}") %>' ></asp:Hyperlink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
           
             </asp:GridView>

    </p>
</asp:Content>
