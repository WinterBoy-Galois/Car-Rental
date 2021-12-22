<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCustomerInfo.aspx.cs" Inherits="CarRental2.UpdateCustomerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 769px;
            text-align: left;
            font-size: x-large;
            color: #333333;
        }
        .auto-style2 {
            font-size: small;
        }
        .auto-style3 {
            text-align: center;
        }
    </style>
</head>
<body style="background-color:powderblue";>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UPDATE EXISTING CUSTOMER INFORMATION<br />
        <br />
        <div class="auto-style3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style2" DataSourceID="SqlDataSource1" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Height="211px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="774px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="CUS_FNAME" HeaderText="CUS_FNAME" SortExpression="CUS_FNAME" />
                    <asp:BoundField DataField="CUS_LNAME" HeaderText="CUS_LNAME" SortExpression="CUS_LNAME" />
                    <asp:BoundField DataField="CUS_INITIAL" HeaderText="CUS_INITIAL" SortExpression="CUS_INITIAL" />
                    <asp:BoundField DataField="CUS_EMAIL" HeaderText="CUS_EMAIL" SortExpression="CUS_EMAIL" />
                    <asp:BoundField DataField="CUS_CELL" HeaderText="CUS_CELL" SortExpression="CUS_CELL" />
                    <asp:BoundField DataField="CUS_ADDRESS" HeaderText="CUS_ADDRESS" SortExpression="CUS_ADDRESS" />
                    <asp:BoundField DataField="CUS_GENDER" HeaderText="CUS_GENDER" SortExpression="CUS_GENDER" />
                    <asp:BoundField DataField="CUS_CITY" HeaderText="CUS_CITY" SortExpression="CUS_CITY" />
                    <asp:BoundField DataField="CUS_COUNTRY" HeaderText="CUS_COUNTRY" SortExpression="CUS_COUNTRY" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CARRENTALConnectionString %>" SelectCommand="SELECT [CUS_FNAME], [CUS_LNAME], [CUS_INITIAL], [CUS_EMAIL], [CUS_CELL], [CUS_ADDRESS], [CUS_GENDER], [CUS_CITY], [CUS_COUNTRY] FROM [CUSTOMERS]"></asp:SqlDataSource>
        </strong>
    
    </div>
    </form>
</body>
</html>
