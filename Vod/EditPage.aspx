<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="Vod.EditPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    Test ^_^
    <br />
    <br />
    <br />
    <asp:Label ID="ID" runat="server" Text="Label">ID</asp:Label>
    <asp:Label ID="dt" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Name" runat="server" Text="Label">Name</asp:Label>
    <asp:TextBox ID="textName" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="update" runat="server" Text="Update" OnClick="update_Click" />

    <a href='javascript:history.go(-2)'>Back to List</a>


</asp:Content>
