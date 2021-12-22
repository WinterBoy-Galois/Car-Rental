<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CarRental2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
    .auto-style16 {
        margin-left: 325px;
            margin-top: 5px;
        }
    .auto-style18 {
        width: 602px;
        height: 395px;
            text-align: center;
            margin-left: 9px;
        }
        .auto-style19 {
            margin-top: 0px;
            height: 751px;
        }
        .auto-style20 {
            font-size: xx-large;
        }
        .auto-style21 {
            font-size: large;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style19">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Panel ID="Panel1" runat="server" BackColor="#F8F8F8" Height="397px" Width="606px" CssClass="auto-style16">
        <div class="auto-style18" >
                <span class="auto-style5">
                <br />
                <span class="auto-style20">LOGIN<br /> </span>
                <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style21" ForeColor="Red"></asp:Label>
                </span><br />
                <br />
                <asp:Image ID="Image1" runat="server" Height="41px" ImageUrl="https://upload.wikimedia.org/wikipedia/commons/7/70/User_icon_BLACK-01.png" Width="48px" />
                <asp:TextBox ID="UserEmail" runat="server" Height="39px" Width="268px" placeholder="Email" style="font-size: x-large"></asp:TextBox>
                <br />
                <br />
                <br />
                <asp:Image ID="Image3" runat="server" Height="41px" ImageUrl="http://pluspng.com/img-png/png-lock-picture-lock-symbol-for-interface-free-icon-512.png" Width="48px" />
                <asp:TextBox ID="TextBox2" runat="server" Height="39px" placeholder="***********" style="font-size: x-large" TextMode="Password" Width="268px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" defaultbutton="Button1" BackColor="#FF6600" Height="48px" style="color: #FFFFFF; font-size: xx-large; margin-left: 9px" Text="SIGN IN" Width="321px" OnClick="Button1_Click" />
                <br />
                <br />
                <span class="auto-style4">Don&#39;t have an account&nbsp; ?</span>
                <asp:HyperLink ID="HyperLink5" runat="server" ForeColor="Orange" NavigateUrl="~/Signup.aspx" >Sign Up</asp:HyperLink>
                &nbsp;&nbsp;
            </div>


    </asp:Panel>
</div>
</asp:Content>
