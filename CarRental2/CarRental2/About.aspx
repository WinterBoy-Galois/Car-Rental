<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CarRental2.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style15 {
        margin-left: 386px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ImageMap ID="ImageMap1" runat="server" CssClass="auto-style15" HotSpotMode="Navigate" ImageUrl="~/images/denizli (1).jpg">
    <asp:CircleHotSpot NavigateUrl="http://www.pau.edu.tr/" Radius="70" X="200" Y="230" />
</asp:ImageMap>
</asp:Content>
