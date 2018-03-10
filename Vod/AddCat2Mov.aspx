<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCat2Mov.aspx.cs" Inherits="Vod.AddCat2Mov" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br />

    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchM" runat="server" Text="Search" OnClick="SearchM_Click" />
    <asp:GridView ID="AllCat" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="AllCat_RowCommand" CssClass="table" >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:ButtonField CommandName="Add2Cat" Text="Add to Cat" />
        </Columns>
    </asp:GridView>

    <br /><br /><br /><br />

    This Movie Categories
    <asp:GridView ID="MovCat" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="MovCat_RowCommand" CssClass="table" >
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:ButtonField CommandName="DeleteGen" Text="Delete" />
        </Columns>
    </asp:GridView>




</asp:Content>
