<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="placeorder.aspx.cs" Inherits="eagro.placeorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 42%;
            height: 96px;
            background-color: #00FFFF;
        }
        .auto-style2 {
            width: 291px;
        }
        .auto-style3 {
            width: 42%;
            height: 175px;
            background-color: #00FFFF;
        }
        .auto-style4 {
            height: 63px;
        }
        .auto-style5 {
            height: 63px;
            width: 181px;
        }
        .auto-style6 {
            width: 181px;
        }
        .auto-style7 {
            width: 1089px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- <div style="background-color:white">
        <div class="row">--%>
            <div class="col-md-6 mx-auto" >

    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red" Text="Buy Products"></asp:Label>
    <br />
    <table class="auto-style1" border="1">
        <tr>
            <td class="auto-style2">Order ID</td>
            <td class="auto-style7">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Order Date</td>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
    <br /><br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" ShowFooter="True">
        <Columns>
            <asp:BoundField DataField="sno" HeaderText="SNo" />
            <asp:BoundField DataField="id" HeaderText="ProductID" />
            <asp:BoundField DataField="productname" HeaderText="Product Name" />
             <asp:BoundField DataField="pprice" HeaderText="Price" />
             <asp:BoundField DataField="pdesc" HeaderText="Description" />
            <asp:BoundField DataField="pquantity" HeaderText="Quantity" />
            <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img src="images/<%# Eval("image") %>" style="width:80px;height:100px" />
                        &nbsp;
                    </ItemTemplate>
                </asp:TemplateField>
           
            
            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" Height="40px" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>


    <br />
    <br />
    <table border="1" class="auto-style3">
        <tr>
            <td class="auto-style5">Name</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox3" runat="server" Width="314px"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Only characters are allowed" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Address</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox1" runat="server" Height="115px" TextMode="MultiLine" Width="323px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6">Mobile Number</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="318px"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter 10 digits" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="^([7-9]{1})([0-9]{9})$"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Required" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <br />


    <asp:Button ID="Button1" runat="server" Text="Payment" Font-Bold="True" ForeColor="#FFCCFF" BackColor="Maroon" Onclick="Button1_Click"/>

    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Maroon"></asp:Label>
</div>
            </div>
</asp:Content>
