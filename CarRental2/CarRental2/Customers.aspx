<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="CarRental2.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style1 {
            color: #FFFFFF;
        }
        .auto-style2 {
            font-size: x-large;
            color: #FF0066;
        }
        
        .auto-style3 {
            font-size: x-large;
            color: #FF3300;
        }
        #form1 {
            height: 1160px;
        }
        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            text-align: right;
        }
        .auto-style6 {
            font-size: xx-large;
            color: #FF0000;
        }
        .auto-style7 {
            color: #333333;
            font-size: x-large;
            margin-left: 280px;
        }
        .auto-style8 {
            text-align: left;
            margin-left: 107px;
            margin-top: 50px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            text-align: left;
            margin-left: 0px;
            margin-top: 10px;
        }
        .auto-style11 {
            font-size: x-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <asp:Panel ID="Panel1" runat="server" BackColor="White" Height="89px" Width="1377px" style="margin-top: 0px">
            <div class="auto-style4">
                <span class="auto-style6">CAR RENTAL COMPANY</span><span class="auto-style1"><br /> <span class="auto-style2"></span></span>
            </div>
            <div class="auto-style5">
                <asp:Menu ID="Menu2" runat="server" CssClass="auto-style7" Height="29px" Orientation="Horizontal" Width="676px">
                    <DynamicMenuItemStyle BackColor="#333333" Font-Size="X-Large" ForeColor="#333333" />
                    <Items>
                        <asp:MenuItem Text="Reservation And Rentals" Value="Reservation" NavigateUrl="~/ReservationAndRentals.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Rent a Car" NavigateUrl="~/Customers.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Logout" Value="Logout" NavigateUrl="~/index.aspx"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle ForeColor="#333333" />
                </asp:Menu>
            </div>
            &nbsp;</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
        <div class="auto-style4">
    
        <asp:Panel ID="Panel3" runat="server" Height="165px" BackColor="White" style="margin-left: 199px; margin-top: 191px;" Width="988px">
            <br />
            <span class="auto-style3">&nbsp;RENT ONLINE FOR THE BEST DEALS</span><br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Placeholder="Search Brand" Height="33px" style="margin-top: 37px; font-size: x-large;" Width="207px"></asp:TextBox>
            <asp:TextBox ID="TextBox6" placeholder="Search Model" runat="server" Height="33px"  style="margin-top: 37px; font-size: x-large; color: #666666; text-align: center;" Width="207px"></asp:TextBox>
            <asp:TextBox ID="TextBox7" placeholder="YYYY-MM-DD" runat="server" Height="33px" style="margin-top: 37px; font-size: x-large; color: #666666;" Width="207px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" BackColor="#FF6600" Height="37px" style="color: #FFFFFF; font-size: x-large" Text="SEARCH" Width="149px" OnClick="Button1_Click" />
            <br />
            <asp:Panel ID="Panel4" runat="server" CssClass="auto-style8" Height="121px" Width="807px" Visible="False">
                <asp:Image ID="Image1" runat="server" Height="109px" Width="183px" />
                <asp:Label ID="Label1" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Rent" />
                <asp:Button ID="Button22" runat="server" OnClick="Button3_Click" Text="Book" />
                <asp:Label ID="Label10" runat="server" Text="Start Date" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                <asp:Label ID="Label11" runat="server" Text="End Date" Visible="False"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                    <asp:ListItem>Bornova</asp:ListItem>
                    <asp:ListItem>Konak</asp:ListItem>
                    <asp:ListItem>Lara Beach</asp:ListItem>
                    <asp:ListItem>Blantyre</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
                    <asp:ListItem>Bornova</asp:ListItem>
                    <asp:ListItem>Konak</asp:ListItem>
                    <asp:ListItem>Lara Beach</asp:ListItem>
                    <asp:ListItem>Blantyre</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="Button2" runat="server" Text="Rent this car" OnClick="Button2_Click" Visible="False" />
                <asp:Button ID="Button21" runat="server" OnClick="Button21_Click" Text="book the car" Visible="False" />
                <asp:Panel ID="Panel5" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                    <asp:Image ID="Image2" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                    <asp:Button ID="Button4" runat="server" Text="Rent" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Text="Book" OnClick="Button5_Click" />
                    <asp:Label ID="Label12" runat="server" Text="Start Date" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                    <asp:Label ID="Label13" runat="server" Text="End Date" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBox11" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList3" runat="server" Visible="False">
                        <asp:ListItem>Bornova</asp:ListItem>
                        <asp:ListItem>Konak</asp:ListItem>
                        <asp:ListItem>Lara Beach</asp:ListItem>
                        <asp:ListItem>Blantyre</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList4" runat="server" Visible="False">
                        <asp:ListItem>Bornova</asp:ListItem>
                        <asp:ListItem>Konak</asp:ListItem>
                        <asp:ListItem>Lara Beach</asp:ListItem>
                        <asp:ListItem>Blantyre</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button23" runat="server" OnClick="Button23_Click" Text="Rent this car" Visible="False" />
                    <asp:Button ID="Button24" runat="server" OnClick="Button24_Click" Text="Book the car" Visible="False" />
                    <br />
                    <br />
                    <asp:Panel ID="Panel6" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image3" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label3" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                        <asp:Button ID="Button6" runat="server" Text="Rent" OnClick="Button6_Click" />
                        <asp:Button ID="Button7" runat="server" Text="Book" OnClick="Button7_Click" />
                        <asp:Label ID="Label14" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox12" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label15" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox13" runat="server" OnTextChanged="TextBox13_TextChanged" placeholder="YYYY-MM-DD" style="height: 22px" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList5" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList6" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="Button26" runat="server" OnClick="Button26_Click" Text="Rent this car" Visible="False" />
                        <asp:Button ID="Button28" runat="server" OnClick="Button28_Click" Text="Book the car" Visible="False" />
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel7" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image4" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label4" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                        <asp:Button ID="Button8" runat="server" Text="Rent" />
                        <asp:Button ID="Button9" runat="server" Text="Book" />
                        <asp:Label ID="Label16" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox14" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label17" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox15" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList7" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList8" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel8" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image5" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label5" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                        <asp:Button ID="Button10" runat="server" Text="Rent" />
                        <asp:Button ID="Button11" runat="server" Text="Book" />
                        <asp:Label ID="Label18" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox16" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label19" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox17" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList9" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList10" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel9" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image6" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label6" runat="server" Text="Label" CssClass="auto-style11"></asp:Label>
                        <asp:Button ID="Button12" runat="server" Text="Rent" />
                        <asp:Button ID="Button13" runat="server" Text="Book" />
                        <asp:Label ID="Label20" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox18" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label21" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox19" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList11" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList12" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel10" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image7" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                        <asp:Button ID="Button14" runat="server" Text="Rent" />
                        <asp:Button ID="Button15" runat="server" Text="Book" />
                        <asp:Label ID="Label22" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox20" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label23" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox21" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList13" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList14" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                    <br />
                    <asp:Panel ID="Panel11" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image8" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                        <asp:Button ID="Button16" runat="server" Text="Rent" />
                        <asp:Button ID="Button17" runat="server" Text="Book" />
                        <asp:Label ID="Label24" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox22" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label25" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox23" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList15" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList16" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                    <asp:Panel ID="Panel12" runat="server" CssClass="auto-style10" Height="121px" Width="807px">
                        <asp:Image ID="Image9" runat="server" CssClass="auto-style9" Height="109px" Width="183px" />
                        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                        <asp:Button ID="Button18" runat="server" Text="Rent" />
                        <asp:Button ID="Button19" runat="server" Text="Book" />
                        <asp:Label ID="Label26" runat="server" Text="Start Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox24" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="109px"></asp:TextBox>
                        <asp:Label ID="Label27" runat="server" Text="End Date" Visible="False"></asp:Label>
                        <asp:TextBox ID="TextBox25" runat="server" placeholder="YYYY-MM-DD" Visible="False" Width="102px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList17" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList18" runat="server" Visible="False">
                            <asp:ListItem>Bornova</asp:ListItem>
                            <asp:ListItem>Konak</asp:ListItem>
                            <asp:ListItem>Lara Beach</asp:ListItem>
                            <asp:ListItem>Blantyre</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
        </div>
    </form>
</body>
</html>
