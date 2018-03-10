<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddAgent.aspx.cs" Inherits="Vod.AddAgent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br /> <br />
    Add Agent
    <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>*
    <asp:TextBox ID="NameText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="Bio" runat="server" Text="Bio"></asp:Label>
    <asp:TextBox ID="BioText" runat="server" CssClass="form-control"></asp:TextBox>

    <asp:Button ID="AddAg" runat="server" Text="Add" OnClick="AddAgent_Click" />

</asp:Content>
