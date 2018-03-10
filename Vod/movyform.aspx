<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="movyform.aspx.cs" Inherits="Vod.movyform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br />
    <asp:LinkButton ID="HomePage" runat="server" OnClick="HomePage_Click">Back to HomePage</asp:LinkButton>
    <br />
    <asp:LinkButton ID="AddMovie" runat="server" OnClick="AddMovie_Click">Add New Movie</asp:LinkButton>
    <br />

    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchM" runat="server" Text="Search" OnClick="SearchM_Click" />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="GridView1_RowCommand" 
        CssClass="table" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:ButtonField CommandName="Genres" Text="Genres" />
            <asp:ButtonField CommandName="Categories" Text="Categories" />
            <asp:ButtonField CommandName="Roles" Text="Roles" />            
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:ButtonField CommandName="Edit" Text="Edit" />

        </Columns>
    </asp:GridView>





</asp:Content>
