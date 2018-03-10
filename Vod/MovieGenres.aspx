<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MovieGenres.aspx.cs" Inherits="Vod.MovieGenres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    Genre of Movie
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>

    <asp:GridView ID="GenresShow" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
        </Columns>
    </asp:GridView>


    <asp:LinkButton ID="AddGen2Mov" runat="server" OnClick="AddGen2Mov_Click">Edite Genres</asp:LinkButton>


</asp:Content>
