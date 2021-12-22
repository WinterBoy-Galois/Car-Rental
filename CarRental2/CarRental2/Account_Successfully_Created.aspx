<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Account_Successfully_Created.aspx.cs" Inherits="CarRental2.Account_Successfully_Created" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style15 {
            font-size: xx-large;
            color: #FFFFFF;
        }
        .auto-style16 {
            text-align: center;
            height: 367px;
        }
        .auto-style17 {
            margin-left: 402px;
            margin-right: 223px;
            margin-bottom: 287px;
        }
        .auto-style18 {
            text-align: center;
            margin-top: 65px;
        }
        .auto-style19 {
            font-size: xx-large;
        }
        .auto-style20 {
            font-size: larger;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style18">
    <asp:Panel ID="Panel1" runat="server" BackColor="#F8F8F8" CssClass="auto-style17" Height="371px" Width="476px" ForeColor="Black">
        <div class="auto-style16">
            &nbsp;<span class="auto-style19"><strong>Your Account Has Successfully Been Created</strong></span><strong><br />
            <br class="auto-style19" />
            <span class="auto-style19">Use Your Email address and Password to <span class="auto-style15"><em>
            <asp:HyperLink ID="HyperLink3" runat="server" CssClass="auto-style20" ForeColor="#FF0066" NavigateUrl="~/Customers.aspx">Login</asp:HyperLink>
            </em></span>
            <br />
            </span><span class="auto-style15">
            <br />
            </span>
            </strong>
        </div>
    </asp:Panel>
    </div>
</asp:Content>



