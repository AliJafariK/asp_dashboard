<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditBanner.aspx.cs" Inherits="Vod.EditBanner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>    
    <br />
    <asp:Label ID="Url" runat="server" Text="Url"></asp:Label>
    <asp:FileUpload ID="UploadBanner" runat="server" />
    <asp:Button ID="UploadBan" runat="server" Text="Upload" OnClick="UploadBan_Click" />
    <asp:Label ID="UploadState" runat="server" Text=""></asp:Label>

    <br />
    <asp:Label ID="Url2Click" runat="server" Text="Url to Click"></asp:Label>
    <asp:TextBox ID="Url2ClickText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="MovieId" runat="server" Text="Movie Id"></asp:Label>
    <asp:TextBox ID="MovieIdText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="CategoryId" runat="server" Text="Category Id"></asp:Label>
    <asp:TextBox ID="CategoryIdText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="GenreId" runat="server" Text="Genre Id"></asp:Label>
    <asp:TextBox ID="GenreIdText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="ListName" runat="server" Text="List Name"></asp:Label>
    <asp:TextBox ID="ListNameText" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="AddBanner" runat="server" Text="Update Banner" OnClick="AddBanner_Click" />


</asp:Content>
