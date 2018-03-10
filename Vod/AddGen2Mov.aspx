<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddGen2Mov.aspx.cs" Inherits="Vod.AddGen2Mov" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br />

    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchM" runat="server" Text="Search" OnClick="SearchM_Click" />
    <asp:GridView ID="AllGen" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="AllGen_RowCommand" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:ButtonField CommandName="Add2Gen" Text="Add to Gen" />
        </Columns>
    </asp:GridView>

    This Movie Genres
    <asp:GridView ID="MovGen" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="MovGen_RowCommand" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:ButtonField CommandName="DeleteGen" Text="Delete" />
        </Columns>
    </asp:GridView>


</asp:Content>
