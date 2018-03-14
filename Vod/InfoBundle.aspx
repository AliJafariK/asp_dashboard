<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InfoBundle.aspx.cs" Inherits="Vod.InfoBundle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/jquery-ui.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.9/themes/start/jquery-ui.css"
        rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        var selected_tab = <%= selectedTab %> ;
        $(function () {
            //console.log(selected_tab);
            jQuery.noConflict();     
            var tabs = $("#tabs").tabs({
                select: function (e, i) {
                    selected_tab = i.index;
                }
            });
            selected_tab = $("[id$=selected_tab]").val() != "" ? parseInt($("[id$=selected_tab]").val()) : 0;
            tabs.tabs('select', selected_tab);
            $("form").submit(function () {
                $("[id$=selected_tab]").val(selected_tab);
            });
        });

        $(document).ready(function () {
            jQuery('.ctabs .ctab-links a').on('click', function (e) {
                var currentAttrValue = jQuery(this).attr('href');
                localStorage["currentTab"] = currentAttrValue;

                // Show/Hide Tabs
                jQuery('.ctabs ' + currentAttrValue).show().siblings().hide();

                // Change/remove current tab to active
                jQuery(this).parent('li').addClass('active').siblings().removeClass('active');

                e.preventDefault();
            });
            if (localStorage["currentTab"]) {
                // Show/Hide Tabs
                jQuery('.ctabs ' + localStorage["currentTab"]).show().siblings().hide();
                // Change/remove current tab to active
                jQuery('.ctabs .ctab-links a[href$="' + localStorage["currentTab"] + '"]').parent('li').addClass('active').siblings().removeClass('active');
            }
        });


    </script>
    <br />
    <asp:LinkButton ID="Back" runat="server" OnClick="Back_Click1">Back</asp:LinkButton>
    <br />
    <div id="tabs">
        <ul>
            <li><a href="#tabs-1">Genre Category</a></li>
            <li><a href="#tabs-2">Movies</a></li>
            <li><a href="#tabs-3">Banners</a></li>
        </ul>
        <div id="tabs-1">
            <asp:Label ID="catId" runat="server" Text="Category Id"></asp:Label>
            <asp:TextBox ID="catIdT" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Label ID="genId" runat="server" Text="Genre Id"></asp:Label>
            <asp:TextBox ID="genIdT" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button ID="addGenCat" runat="server" Text="Add Info" OnClick="addGenCat_Click" />
        </div>


        <div id="tabs-2">
            <br />
            Selected Movie:
            <asp:Label ID="SelectedMovieT" runat="server" Text=""></asp:Label>
            <br />
            All Movie:
            <asp:TextBox ID="SearchText" runat="server"></asp:TextBox>
            <asp:Button ID="SearchMov" runat="server" Text="Search" OnClick="SearchMov_Click" />
            <br />
            <asp:GridView ID="AllMovie" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" OnRowCommand="AllMovie_RowCommand" CssClass="table" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:ButtonField CommandName="Sel4Ban" Text="Select" />
                </Columns>
            </asp:GridView>
        </div>


        <div id="tabs-3">
            Bundle Banner's :
            <asp:GridView ID="BundleBanners" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="Id" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Url" HeaderText="Url" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            All Banners:
            <asp:GridView ID="banners" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCommand="banners_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Url" HeaderText="Url" />
                    <asp:ButtonField CommandName="Add2Ban" Text="Add" />
                </Columns>
            </asp:GridView>
            <br />
            Selected Banners:
            <asp:GridView ID="selcetedBanners" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Url" HeaderText="Url" />
                </Columns>
            </asp:GridView>
            <br /><br />
            <asp:Button ID="addBanner" runat="server" Text="Add Info" UseSubmitBehavior="false" OnClick="addBanner_Click" />
        </div>
    </div>

    <asp:HiddenField ID="selected_tab" runat="server" />
    <%--<asp:Button ID="Button1" runat="server" Text="Do PostBack" />--%>


</asp:Content>
