<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="invoice.aspx.cs" Inherits="eagro.invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 44px;
        }
        .auto-style2 {
            height: 68px;
        }
        .auto-style4 {
            width: 100%;
            height: 83px;
        }
        .auto-style5 {
            height: 56px;
        }
        .auto-style6 {
            height: 56px;
            width: 431px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Order ID:<asp:Label ID="Label3" runat="server"></asp:Label></br>
         <asp:Button ID="Button1" runat="server" BackColor="#FF6600" Font-Bold="True" OnClick="Button1_Click" Text="Download Invoice" />
    <br />
    <br />
        </p>
    <asp:Panel ID="Panel1" runat="server" Height="447px">
        <table class="w-100" border="1">
            <tr>
                <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Customer Invoice</td>
            </tr>
            <tr>
                <td class="auto-style2">Order ID:<asp:Label ID="Label4" runat="server"></asp:Label>
                    <br />
                    Order Date:<asp:Label ID="Label5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>

                    <table class="auto-style4" border="1">
                        <tr>
                            <td class="auto-style6">Buyer Address:<br />
                                <asp:Label ID="Label6" runat="server"></asp:Label>
                            </td>
                            <td class="auto-style5">Seller Address:<br /> E-Agro,Banglore</td>
                        </tr>
                    </table>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" Height="157px" Width="1040px" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="sno" HeaderText="S.NO" />
                            <asp:BoundField DataField="id" HeaderText="Product ID" />
                            <asp:BoundField DataField="pname" HeaderText="Product Name" />
                            <asp:BoundField DataField="pprice" HeaderText="Price" />
                            <asp:BoundField DataField="pquantity" HeaderText="Quantity" />
                            <asp:BoundField DataField="totalprice" HeaderText="Total Price" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    Grand Total:<asp:Label ID="Label8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                  Declaration:We declare that this invoice shows actual price of the goods described inclusive of taxes and that all particulars are true and correct.
Incase you find Selling price on this invoice to be more thanMRP mentioned on product, please inform aashupoojari123@gmail.com
THIS IS A COMPUTER GENERATED INVOICE AND DOES NOT REQUIRED SIGNATURE.

                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
    <div align="center">
        <a href="feedback.aspx">Feed back us</a>
    </div>

</asp:Content>
