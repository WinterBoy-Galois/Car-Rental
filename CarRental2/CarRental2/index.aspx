<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CarRental2.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style10 {
        color: #FFFFFF;
        font-size: xx-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Panel ID="Panel1" runat="server">
    <p style="height: 0px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p style="height: 38px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <p style="height: 38px">
            ,,</p>
        <p style="height: 38px">
            &nbsp;</p>
        <p style="height: 38px">
            &nbsp; <span class="auto-style10"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DISCOVER THE WORLD </strong></span>
        </p>
    <p style="height: 142px; text-align: center;">
        <asp:Image ID="Image1" runat="server" Height="34px" ImageUrl="~/images/location.png" Width="48px" />
        <asp:TextBox ID="TextBox1" runat="server" Height="36px" PlaceHolder="Istanbul" style="font-size: x-large" Width="170px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Image ID="Image2" runat="server" Height="38px" ImageUrl="~/images/calendar-512.png" Width="45px" />
        &nbsp;&nbsp;<asp:TextBox ID="TextBox4" runat="server" Height="36px" Width="165px"></asp:TextBox>
        &nbsp;
        <asp:Image ID="Image3" runat="server" Height="34px" ImageUrl="~/images/return.png" Width="38px" />
        <asp:TextBox ID="TextBox3" runat="server" Height="38px" style="font-size: x-large; margin-top: 0px" Width="185px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" ForeColor="#CCFFCC" Height="42px" OnClick="Button1_Click" style="color: #000066; font-size: x-large" Text="Search" Width="164px" />
    </p>
</asp:Panel>
    
</asp:Content>