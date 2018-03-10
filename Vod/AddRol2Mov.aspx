<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddRol2Mov.aspx.cs" Inherits="Vod.AddRol2Mov" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    
    <br /> <h3> Add New Role to Movie </h3> <br />

    
    <br />
    Agents:
    <asp:TextBox ID="SearchBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchM" runat="server" Text="Search" OnClick="SearchM_Click" />
    <asp:GridView ID="AllAgent" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table" OnRowCommand="AllAgent_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Bio" HeaderText="Bio" />
            <asp:ButtonField Text="Add" CommandName="Add" />
        </Columns>
    </asp:GridView>

    <br />
    Selected Agents:
    <asp:GridView ID="SelAgent" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Bio" HeaderText="Bio" />
        </Columns>
    </asp:GridView>


    <br />
    Name:
    <asp:DropDownList ID="RoleNames" runat="server">
        <asp:ListItem>کارگردان</asp:ListItem>
        <asp:ListItem>نویسنده</asp:ListItem>
        <asp:ListItem>بازیگر</asp:ListItem>
        <asp:ListItem>فیلم بردار</asp:ListItem>
        <asp:ListItem>تهیه کننده</asp:ListItem>
        <asp:ListItem>صدابردار</asp:ListItem>
        <asp:ListItem>تدوین</asp:ListItem>
        <asp:ListItem>انیماتور</asp:ListItem>
        <asp:ListItem>آهنگساز</asp:ListItem>
        <asp:ListItem>تامین کننده</asp:ListItem>
    </asp:DropDownList>

    <br /><br />


    <asp:Button ID="AddRole" runat="server" Text="Add New Role" OnClick="AddRole_Click" />

    <br /><br />
    <%-- <asp:GridView ID="MovRol" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Movie" HeaderText="Movie" />
            <asp:BoundField DataField="Agent" HeaderText="Agent" />
        </Columns>
    </asp:GridView> --%>

    <br />

</asp:Content>
