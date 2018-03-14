<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddBundle.aspx.cs" Inherits="Vod.AddBundle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br />
    <asp:Label ID="TitleBundle" runat="server" Text="Title"></asp:Label>
    <asp:TextBox ID="TitleBundleT" runat="server" CssClass="form-control"></asp:TextBox>
    <%--<br />
    <asp:Label ID="CategoryId" runat="server" Text="Category Id"></asp:Label>
    <asp:TextBox ID="CategoryIdT" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="GenreId" runat="server" Text="Genre Id"></asp:Label>
    <asp:TextBox ID="GenreIdT" runat="server" CssClass="form-control"></asp:TextBox>--%>
    <br />
    <asp:Label ID="TypeBundle" runat="server" Text="Type"></asp:Label>
    <asp:TextBox ID="TypeT" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="AddBundle" runat="server" Text="Add Bundle" OnClick="AddBundle_Click" />


</asp:Content>
