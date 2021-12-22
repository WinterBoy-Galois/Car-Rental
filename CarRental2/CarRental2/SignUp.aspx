<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="CarRental2.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            position: relative;
            width: 363px;
            left: 5px;
            top: -5px;
            height: 22px;
            margin-top: 15px;
        }
        .auto-style13 {
            margin-left: 335px;
            margin-top: 0px;
        }
    .auto-style15 {
        margin-left: 201px;
        margin-top: 2px;
            margin-right: 18px;
            text-align: center;
        }
        .auto-style17 {
            font-size: large;
            color: #FFFFFF;
        }
        .auto-style19 {
            margin-left: 0px;
            font-size: small;
            margin-top: 5px;
        }
        .auto-style20 {
            font-size: small;
        }
        .auto-style21 {
            margin-left: 0px;
            font-size: small;
        }
        .auto-style22 {
            text-align: left;
            width: 708px;
        height: 696px;
            margin-left: 0px;
        }
        .auto-style23 {
            font-size: xx-small;
        }
    .auto-style24 {
        text-align: left;
        height: 22px;
        margin-left: 0px;
    }
    .auto-style25 {
        margin-left: 194px;
    }
        .auto-style26 {
            color: red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="auto-style17"><strong>JOIN CAR RENTAL COMPANY</strong></span><asp:Panel ID="Panel1" runat="server" BackColor="Black" CssClass="auto-style15" Font-Names="Arial Black" ForeColor="White" Height="720px" HorizontalAlign="Left" Width="733px">
        <div class="auto-style22">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" CssClass="auto-style20" Text="Country"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:DropDownList ID="CountryList" runat="server" AutoPostBack="True" CssClass="auto-style20" Height="55px" OnSelectedIndexChanged="CountryList_SelectedIndexChanged" Width="221px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="CountryList" ErrorMessage="Select Country" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" CssClass="auto-style20" Text="City"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:DropDownList ID="CityList" runat="server" CssClass="auto-style20" Height="55px" Width="221px" AutoPostBack="True" OnSelectedIndexChanged="CityList_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="CityList" ErrorMessage="Select City" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" CssClass="auto-style20" Text="Firstname"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><asp:TextBox ID="firstnameTextBox" runat="server" CssClass="auto-style20" Width="212px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstnameTextBox" ErrorMessage="First name is required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" CssClass="auto-style20" Text="Lastname"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="lastnameTextbox" runat="server" CssClass="auto-style20" Width="212px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastnameTextbox" ErrorMessage="Last name is required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" CssClass="auto-style20" Text="Other Names"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="initialTextbox" runat="server" CssClass="auto-style20" Width="212px"></asp:TextBox>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" CssClass="auto-style20" Text="Email"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</span><asp:TextBox ID="Emailtextbox" runat="server" CssClass="auto-style21" Width="212px" OnTextChanged="Emailtextbox_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Emailtextbox" ErrorMessage="Provide Your Email" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Emailtextbox" CssClass="auto-style23" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label14" runat="server" Text="Label" CssClass="auto-style26"></asp:Label>
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" CssClass="auto-style20" Text="Cellnumber"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label13" runat="server" Text="+1"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><asp:TextBox ID="celltextbox" runat="server" CssClass="auto-style20" Width="170px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="celltextbox" ErrorMessage="Provide your Cellnumber" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" CssClass="auto-style20" Text="Address"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="addresstextbox" runat="server" CssClass="auto-style20" Height="47px" Width="212px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="addresstextbox" ErrorMessage="Address is required" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <div class="auto-style24">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label10" runat="server" CssClass="auto-style20" Text="Gender"></asp:Label>
                &nbsp;<asp:RadioButtonList ID="RadioButtonList2" runat="server" CssClass="auto-style25" Height="17px" Width="216px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem Selected="True">Female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br class="auto-style20" />
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label11" runat="server" CssClass="auto-style20" Text="Password"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="PasswordTextBox" runat="server" CssClass="auto-style21" Height="23px" TextMode="Password" Width="215px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PasswordTextBox" ErrorMessage="Password can not be blank" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="PasswordValidate" ControlToValidate="PasswordTextBox" CssClass="auto-style23" ErrorMessage="password length has to be minimum of 8 characters and maximum of 20 characters" ForeColor="Red" OnServerValidate="PasswordValidate"></asp:CustomValidator>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label12" runat="server" CssClass="auto-style20" Text="RetypePassword"></asp:Label>
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:TextBox ID="RetypePasswordTextbox" runat="server" CssClass="auto-style19" Height="23px" TextMode="Password" Width="215px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RetypePasswordTextbox" ErrorMessage="Retype Your Password" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="RetypePasswordTextbox" CssClass="auto-style23" ErrorMessage="Passwords do not match" ForeColor="Red"></asp:CompareValidator>
            <br />
            <asp:CheckBox ID="confirmtextbox" runat="server" CssClass="auto-style20" Text="I confirm that information given in this form is true" />
            <br />
            <span class="auto-style20">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </span>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Create Account" />
            <br class="auto-style20" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
    </asp:Panel>
    <p style="font-size: small; font-style: oblique; font-family: 'Arial Black'; color: #FFFFFF; font-weight: bold; position: static; font-variant: normal; text-transform: capitalize;">
        &nbsp;</p>
    </asp:Content>
