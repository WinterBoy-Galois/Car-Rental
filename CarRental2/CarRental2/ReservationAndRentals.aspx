<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationAndRentals.aspx.cs" Inherits="CarRental2.ReservationAndRentals" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style4 {
            text-align: center;
        }
        .auto-style6 {
            font-size: xx-large;
            color: #FF0000;
        }
                
        .auto-style1 {
            color: #FFFFFF;
        }
        .auto-style7 {
            color: #333333;
            font-size: x-large;
            margin-left: 300px;
        }
        .auto-style8 {
            text-align: left;
            margin-left: 0px;
        }
        .auto-style9 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <div class="auto-style4">
                <span class="auto-style6">CAR RENTAL COMPANY</span><span class="auto-style1"><br /> </span>
            </div>
    
    </div>
                <asp:Menu ID="Menu2" runat="server" CssClass="auto-style7" Height="29px" Orientation="Horizontal" Width="676px">
                    <DynamicMenuItemStyle BackColor="#333333" Font-Size="X-Large" ForeColor="#333333" />
                    <Items>
                        <asp:MenuItem Text="Reservation And Rentals" Value="Reservation" NavigateUrl="~/ReservationAndRentals.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Rent a Car" NavigateUrl="~/Customers.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Logout" Value="Logout" NavigateUrl="~/index.aspx"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle ForeColor="#333333" />
                </asp:Menu>
            <asp:Panel ID="Panel1" runat="server" CssClass="auto-style8" Height="187px" Width="1307px">
                <br />
                <asp:Label ID="Label1" runat="server" CssClass="auto-style9" Text="Label"></asp:Label>
                <br />
                <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="327px" Width="1325px">
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style9"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
