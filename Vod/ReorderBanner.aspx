<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ReorderBanner.aspx.cs" Inherits="Vod.ReorderBanner" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="bans1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table" OnRowCommand="bans1_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Url" HeaderText="Url" />
            <asp:ButtonField CommandName="MIF" Text="Make It First" />

        </Columns>

    </asp:GridView>

</asp:Content>
