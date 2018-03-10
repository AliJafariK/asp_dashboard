<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Vod.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Movies" runat="server" OnClick="Movies_Click">Movies</asp:LinkButton>
    <br />
    <asp:LinkButton ID="Categories" runat="server" OnClick="Categories_Click">Categories</asp:LinkButton>
    <br />
    <asp:LinkButton ID="Genres" runat="server" OnClick="Genres_Click">Genres</asp:LinkButton>
    <br />
    <asp:LinkButton ID="Agents" runat="server" OnClick="Agents_Click">Agents</asp:LinkButton>

</asp:Content>
