<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="banner.aspx.cs" Inherits="Vod.banner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:LinkButton ID="AddBanner" runat="server" OnClick="AddBanner_Click">Add Banner</asp:LinkButton>
    <br />
    <asp:LinkButton ID="ReorderBanner" runat="server" OnClick="ReorderBanner_Click">Reorder Banner</asp:LinkButton>

    <br />
    <br />
    <asp:GridView ID="ban1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="ban1_RowCommand" OnRowDeleting="ban1_RowDeleting" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Url" HeaderText="Url" />
            <asp:BoundField DataField="UrlToClick" HeaderText="Url to Click" />
            <asp:BoundField DataField="MovieId" HeaderText="MovieId" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" />
            <asp:BoundField DataField="GenreId" HeaderText="GenreId" />
            <asp:BoundField DataField="ListName" HeaderText="ListName" />
            <asp:ButtonField CommandName="Edit" Text="Edit" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />

        </Columns>

    </asp:GridView>

</asp:Content>
