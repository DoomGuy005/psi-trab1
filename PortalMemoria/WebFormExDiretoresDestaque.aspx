<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebFormExDiretoresDestaque.aspx.cs" Inherits="PortalMemoria.WebFormExDiretoresDestaque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <br />
        <asp:Label ID="LabelDiretor" runat="server" Text="Diretor"></asp:Label>
    <br />
        <hr />
    <br />
        <asp:Image ID="ImageDiretor" runat="server" />
        <asp:Label ID="LabelDiretorDestaque" runat="server" Text="Label"></asp:Label>
</asp:Content>
