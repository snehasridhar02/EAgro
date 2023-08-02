<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addtocart.aspx.cs" Inherits="eagro.addtocart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-color:orange">
        <div class="row">
            <div class="col-md-6 mx-auto" >
    <p style="font-size:large">
        You Have &nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
&nbsp;Products in your cart&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/farmerview.aspx" Font-Bold="true">Continue Shopping</asp:HyperLink>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" ShowFooter="True" Width="109px"  Height="213px"  OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:BoundField DataField="sno" HeaderText="S.No" ControlStyle-Font-Bold="true">
<ControlStyle Font-Bold="True"></ControlStyle>

                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="id" HeaderText="ProductID" ControlStyle-Font-Bold="true">
<ControlStyle Font-Bold="True"></ControlStyle>

                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="productname" HeaderText="Name" ControlStyle-Font-Bold="true" >
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:BoundField>
                <asp:BoundField DataField="pprice" HeaderText="Price" ControlStyle-Font-Bold="true" >
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:BoundField>
                <asp:BoundField DataField="pdesc" HeaderText="Description" ControlStyle-Font-Bold="true" >
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:BoundField>
                <asp:BoundField DataField="pquantity" HeaderText="Quantity" ControlStyle-Font-Bold="true" >
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                         <img src="images/<%# Eval("image") %>" style="width:80px;height:100px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="totalprice" HeaderText="Total Price" ControlStyle-Font-Bold="true">
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:BoundField>
                <asp:CommandField DeleteText="Remove" ShowDeleteButton="True" ControlStyle-Font-Bold="true" >
<ControlStyle Font-Bold="True"></ControlStyle>
                </asp:CommandField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" Height="40px" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" Height="65px" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" Height="100px" />
            <RowStyle BackColor="White" ForeColor="#330099" Height="100px" Width="100px" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" Height="100px" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>

    </p>
                

            </div>
        </div>
     </div>
            <div align="center">
             
    <asp:Button ID="Button2" runat="server" Text="Placeorder" OnClick="Button1_Click" BackColor="Lime" />
</div>
</asp:Content>
