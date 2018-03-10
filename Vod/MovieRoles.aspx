<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MovieRoles.aspx.cs" Inherits="Vod.MovieRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    Roles:
    <br />

    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>

    <asp:GridView ID="RolesShow" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table" AllowPaging="True" OnRowCommand="Roles_RowCommand" OnRowDeleting="Roles_RowDeleting">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Movie" HeaderText="Movie" />
            <asp:BoundField DataField="Agent" HeaderText="Agent" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />  
        </Columns>
    </asp:GridView>

    <br />
    <asp:LinkButton ID="AddRol2Mov" runat="server" OnClick="AddRol2Mov_Click">Edite Roles</asp:LinkButton>



</asp:Content>
