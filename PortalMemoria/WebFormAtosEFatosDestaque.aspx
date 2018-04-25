<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebFormAtosEFatosDestaque.aspx.cs" Inherits="PortalMemoria.WebFormAtosEFatosDestaque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LabelFato" runat="server" Text="Label" Font-Bold="True" Font-Names="Verdana"></asp:Label>
    <hr />
    <asp:Label ID="LabelDestaqueFato" runat="server" Text="Label" Font-Names="Verdana" Font-Size="Small"></asp:Label>
    <br />
    <asp:Image ID="ImageDestaqueFato" runat="server" ImageAlign="Middle" />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormAtosEFatos.aspx" ForeColor="#990000">Voltar a Listagem</asp:HyperLink>
</asp:Content>
