<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerManagement.aspx.cs" Inherits="CarRental2.CustomerManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 824px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style4 {
            font-size: xx-large;
            color: #333333;
        }
        .auto-style5 {
            text-align: left;
            height: 525px;
            width: 1119px;
            margin-right: 114px;
        }
    .auto-style25 {
        margin-left: 194px;
    }
        .auto-style26 {
            color: #000066;
        }
        .auto-style7 {
            color: #333333;
            font-size: x-large;
            margin-left: 12px;
        }
        </style>
</head>
<body style="background-color:powderblue; height: 330px;">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <span class="auto-style3">CAR RENTAL COMPANY</span><br class="auto-style2" />
        <span class="auto-style4">CUSTOMER MANAGEMENT</span><br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="725px" Width="1121px">
            <div class="auto-style5">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Menu ID="Menu2" runat="server" CssClass="auto-style7" Height="32px" Orientation="Horizontal" Width="1105px">
                    <DynamicHoverStyle BackColor="#333333" />
                    <DynamicMenuItemStyle BackColor="#333333" Font-Size="X-Large" ForeColor="#333333" />
                    <Items>
                        <asp:MenuItem NavigateUrl="~/UpdateCustomerInfo.aspx" Text="Update Customer Info" Value="Reservation"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/RentalManagement.aspx" Text="Delete Customer Info" Value="Rental"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/CarManagement.aspx" Text="Get Customer Report" Value="Cars"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/index.aspx" Text="Logout" Value="Logout"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle ForeColor="#333333" />
                    <StaticMenuStyle BackColor="Red" />
                </asp:Menu>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Other Names"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Cell"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox7" runat="server" Width="212px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Gender"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" CssClass="auto-style25" Height="17px" Width="216px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem Selected="True">Female</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:Label ID="Label9" runat="server" Text="Country"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="31px" Width="216px">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Text="City"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="31px" Width="216px">
                </asp:DropDownList>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="auto-style26" Text="Register New Customer" />
            </div>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
