<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebFormCronologia.aspx.cs" Inherits="PortalMemoria.WebFormCronologia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Direction="LeftToRight" ScrollBars="Horizontal" Height="150px" Width="500px">
        <asp:Table ID="TableCronologia" runat="server"></asp:Table>
        </asp:Panel>
    <asp:Image ID="ImageEvento" runat="server" ImageAlign="Left" />
    <asp:Label ID="LabelAno" runat="server" Text="Label" ></asp:Label> <br />
    <asp:Label ID="LabelEvento" runat="server" Text="Label"></asp:Label> <br />
    <asp:Label ID="LabelDesc" runat="server" Text="Label"></asp:Label>
</asp:Content>
