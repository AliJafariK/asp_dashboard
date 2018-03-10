<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MovieCategories.aspx.cs" Inherits="Vod.MovieCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    Category of Movie
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <asp:GridView ID="CategoriesShow" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
        </Columns>
    </asp:GridView>


    <asp:LinkButton ID="AddCat" runat="server" OnClick="AddCat_Click">Edit Categories</asp:LinkButton>

</asp:Content>
