<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EndUserHomePage.aspx.cs" Inherits="WebApplication1.EndUserHomePage.EndUserHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <span style="font-size: 18.0pt; font-family: Calibri; mso-ascii-font-family: Calibri; mso-fareast-font-family: +mn-ea; mso-bidi-font-family: +mn-cs; mso-ascii-theme-font: minor-latin; mso-fareast-theme-font: minor-fareast; mso-bidi-theme-font: minor-bidi; color: black; mso-color-index: 1; mso-font-kerning: 12.0pt; language: en-US; font-weight: bold; mso-style-textfill-type: solid; mso-style-textfill-fill-themecolor: text1; mso-style-textfill-fill-color: black; mso-style-textfill-fill-alpha: 100.0%">&nbsp;&nbsp;&nbsp;&nbsp; My Events</span></p>
<p class="text-center">
    &nbsp;</p>
    <p class="text-center">
        <%if (Context.User.IsInRole("Dinesh"))%> 
          <% { %>
                 <asp:GridView ID="GridView" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="248px" Width="773px">
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
                        <asp:button ID="botton1" runat="server" Text='On' BackColor="#3C3C3C" OnClick="GridView_SelectedIndexChanged1" 
                            PostBackUrl="~/Approval/EventAprovalPage.aspx" UseSubmitBehavior="False" Font-Bold="False" ></asp:button>
                        <asp:Button ID="button2" runat="server" Text="off" BackColor="#d6d3d3" />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Channels">
                    <ItemTemplate>
                        <asp:checkbox ID="interanet" value="Checkvalue1" runat="server" Text='Interanet' Checked="False"></asp:checkbox>
                        <asp:checkbox ID="Email" value="Checkvalue2" runat="server" Text='Email'></asp:checkbox>
                        <asp:checkbox ID="UnaBot" value="Checkvalue3" runat="server" Text='Una Bot'></asp:checkbox>
                        <asp:checkbox ID="sms" value="Checkvalue4" runat="server" Text='SMS'></asp:checkbox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Hyperlink ID="Label1" runat="server" Text="Update" NavigateUrl="~/EndUserHomePage/Acceptence.aspx"></asp:Hyperlink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
           
             </asp:GridView>
        <% } %>
    </p>
    <p class="text-center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="772px" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="244px">
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
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                
                <asp:TemplateField HeaderText="Subscribed">
                    <ItemTemplate>
                        <asp:button ID="botton1" runat="server" Text='On' BackColor="#3C3C3C" OnClick="GridView_SelectedIndexChanged1" 
                            PostBackUrl="~/Approval/EventAprovalPage.aspx" UseSubmitBehavior="False" Font-Bold="False" ></asp:button>
                        <asp:Button ID="button2" runat="server" Text="off" BackColor="#d6d3d3" />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Channels">
                    <ItemTemplate>
                        <asp:checkbox ID="interanet" value="1" runat="server" Text='Interanet' Checked="False" ></asp:checkbox>
                        <asp:checkbox ID="Email" value="2" runat="server" Text='Email'></asp:checkbox>
                        <asp:checkbox ID="UnaBot" value="3" runat="server" Text='Una Bot'></asp:checkbox>
                        <asp:checkbox ID="sms" value="4" runat="server" Text='SMS'></asp:checkbox>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Hyperlink ID="Label1" runat="server" Text="Update" NavigateUrl="~/EndUserHomePage/Acceptence.aspx"></asp:Hyperlink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>    
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString %>" SelectCommand="SELECT e.Name FROM Event AS e INNER JOIN Event_slm_subscribe AS ess ON e.Id = ess.EventId"></asp:SqlDataSource>
    </p>
    <p class="text-center">
        &nbsp;</p>


<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
