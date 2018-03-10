<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCat.aspx.cs" Inherits="Vod.AddCat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br /> <br />
    Add Category :
    <br />
    <asp:Label ID="CatName" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="CatNameText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Button ID="AddCategory" runat="server" Text="Add Category" OnClick="AddCategory_Click" />

</asp:Content>
