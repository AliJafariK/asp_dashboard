<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddGen.aspx.cs" Inherits="Vod.AddGen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br /> <br />
    Add Genre :
    <br />
    <asp:Label ID="GenName" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="GenNameText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Button ID="AddGenre" runat="server" Text="Add Genre" OnClick="AddGenre_Click" />

</asp:Content>
