<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddNewMovie.aspx.cs" Inherits="Vod.AddNewMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click">Back</asp:LinkButton>
    <br /><br /><br />
    <asp:Label ID="MovieTitle" runat="server" Text="Title"></asp:Label>
    <asp:TextBox ID="MovieTitleText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Label ID="Description" runat="server" Text="Description"></asp:Label>
    <asp:TextBox ID="DescriptionText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Label ID="Year" runat="server" Text="Year"></asp:Label>
    <asp:TextBox ID="YearText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Label ID="Featured" runat="server" Text="Featured"></asp:Label>
    <asp:CheckBox ID="FeaturedCheckBox" runat="server" />
    <br />
    <asp:Label ID="Price" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="PriceText" runat="server" CssClass="form-control"></asp:TextBox>* Tomans
    <br />
    <asp:Label ID="Qualities" runat="server" Text="Qualities"></asp:Label>
    <asp:CheckBox ID="Qualities320" runat="server" />320
    <asp:CheckBox ID="Qualities480" runat="server" />480
    <asp:CheckBox ID="Qualities720" runat="server" />720
    <asp:CheckBox ID="Qualities1080" runat="server" />1080
    <br />
    <asp:Label ID="Downloadables" runat="server" Text="Downloadables"></asp:Label>
    <asp:CheckBox ID="Downloadables320" runat="server" />320
    <asp:CheckBox ID="Downloadables480" runat="server" />480
    <asp:CheckBox ID="Downloadables720" runat="server" />720
    <asp:CheckBox ID="Downloadables1080" runat="server" />1080
    <br />
    <asp:Label ID="FolderName" runat="server" Text="FolderName"></asp:Label>
    <asp:TextBox ID="FolderNameText" runat="server" CssClass="form-control"></asp:TextBox>*
    <br />
    <asp:Label ID="EditorialRate" runat="server" Text="EditorialRate"></asp:Label>
    <asp:TextBox ID="EditorialRateText" runat="server" CssClass="form-control"></asp:TextBox>*  
    <br />
    <asp:Label ID="Disable" runat="server" Text="Disable"></asp:Label>
    <asp:CheckBox ID="DisableCheckbox" runat="server" />
    <br />
    <br />
    <asp:FileUpload ID="PosterUpload" runat="server" />
    <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadButton_Click" />
    <asp:Label ID="UploadState" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Button ID="AddMovie" runat="server" Text="Add New Movie" OnClick="AddMovie_Click" />

</asp:Content>
