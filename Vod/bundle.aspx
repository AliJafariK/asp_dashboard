<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="bundle.aspx.cs" Inherits="Vod.bundle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="AddBundle" runat="server" OnClick="AddBundle_Click">Add Bundle</asp:LinkButton>
    <br />
    <asp:GridView ID="bundles1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="bundles_RowCommand" OnRowDeleting="bundles_RowDeleting" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <%--<asp:BoundField DataField="CateroryId" HeaderText="CategoryId" />
            <asp:BoundField DataField="GenreId" HeaderText="GenreId" />--%>
            <asp:BoundField DataField="Type" HeaderText="Type" />
            <asp:ButtonField CommandName="Edit" Text="Edit" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:ButtonField CommandName="Info" Text="Info Movies" />

        </Columns>
    </asp:GridView>

</asp:Content>
