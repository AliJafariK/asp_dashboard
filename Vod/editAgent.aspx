<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="editAgent.aspx.cs" Inherits="Vod.editAgent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />

    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>

    <br />
    <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="NameText" runat="server"></asp:TextBox>

    <br />
    <asp:Label ID="Bio" runat="server" Text="Bio"></asp:Label>
    <asp:TextBox ID="BioText" runat="server"></asp:TextBox>
   
    <br />
    <br />

    <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />


</asp:Content>
