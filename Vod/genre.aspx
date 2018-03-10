<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="genre.aspx.cs" Inherits="Vod.genre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br />
    <asp:LinkButton ID="HomePage" runat="server" OnClick="HomePage_Click">Back to HomePage</asp:LinkButton>
    <br />
    <asp:LinkButton ID="AddGen" runat="server" OnClick="AddGen_Click">Add Genre</asp:LinkButton>
    <br />

    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchM" runat="server" Text="Search" OnClick="SearchM_Click" />
    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" CssClass="table" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:ButtonField CommandName="Delete" Text="Delete" />
            <asp:ButtonField CommandName="Edit" Text="Edit" />
        </Columns>
    </asp:GridView>

</asp:Content>
