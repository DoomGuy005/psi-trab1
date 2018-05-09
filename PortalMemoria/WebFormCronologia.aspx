<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebFormCronologia.aspx.cs" Inherits="PortalMemoria.WebFormCronologia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Direction="LeftToRight" ScrollBars="Horizontal" Height="150px" Width="500px">
        <asp:Table ID="TableCronologia" runat="server"></asp:Table>
        </asp:Panel>
    <br />
    <div style="width: 700px">
        <asp:Image ID="ImageEvento" runat="server" ImageAlign="Left" BorderStyle="Solid" BorderWidth="1px" />
        <asp:Label ID="LabelAno" runat="server" TextAlign="Right" Text="Label" Font-Names="Verdana" Font-Size="X-Large" ForeColor="#990000" ></asp:Label> <br /> <br /> <br />
        <asp:Label ID="LabelEvento" runat="server" TextAlign="Right" Text="Label" Font-Names="Verdana" Font-Size="Large"></asp:Label> <br /> <br />
        <asp:Label ID="LabelDesc" runat="server" TextAlign="Right" Text="Label" Font-Names="Verdana" Font-Size="X-Small"></asp:Label>
    </div>
    
</asp:Content>
