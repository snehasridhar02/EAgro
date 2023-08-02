<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile ="viewcustomer1.aspx.cs" Inherits="eagro.viewcustomer1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 32px;
        }
        .auto-style2 {
            height: 41px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:cornsilk">
        <div class="row">
            <div class="col-md-6 mx-auto" >
                <h4 style="text-decoration:none; color:maroon">No of products in your cart &nbsp;
                    
                    <asp:Label ID="Label8" runat="server" Text="Label" Font-Bold="true"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/addcart.aspx" Font-Bold="true">Show Cart</asp:HyperLink>
                </h4>
                <br />
                 <table>
        <tr>
            <td >
               <asp:ImageButton ID="ImageButton2" runat="server" Height="23px" ImageUrl="~/images/search.jpg" Width="25px" OnClick="ImageButton2_Click"  />
                <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="174px"></asp:TextBox>
                
                
            </td>
        </tr>
    </table>

                <asp:DataList ID="DataList1" runat="server"  CellPadding="4" DataKeyField="id" DataSourceID="SqlDataSource1" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal" Width="711px" OnItemCommand="DataList1_ItemCommand" ViewStateMode="Disabled"  >
                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    <ItemStyle BackColor="White" ForeColor="#330099" />
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td><asp:Label ID="Label1" runat="server" Font-Bold="True" style="text-align: center" Text="Product ID"></asp:Label>
                                    &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("id") %>'></asp:Label>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;</td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Text='<%# Eval("productname") %>'></asp:Label>
                                    </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Text='<%# Eval("pdesc") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <img src="images/<%# Eval("image") %>" style="width:80px;height:100px" />
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Price"></asp:Label>
                                    &nbsp;
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Text='<%# Eval("pprice") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center">
                                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Text="Quantity"></asp:Label>
                                    &nbsp;
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                        <asp:ListItem>2</asp:ListItem>
                                        <asp:ListItem>3</asp:ListItem>
                                        <asp:ListItem>4</asp:ListItem>
                                        <asp:ListItem>5</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2" style="text-align: center">
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="68px" ImageUrl="~/images/cart.jpg" Width="158px" CommandArgument='<%# Eval("id")%>' CommandName="addtocart" />
                                </td>
                            </tr>
                        </table>
                        <br />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                </asp:DataList>

              <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eagroConnectionString %>" SelectCommand="SELECT [id], [productname], [pdesc], [image], [pprice] FROM [product2]"></asp:SqlDataSource>

                <br /><br />
               
                <br />
                </div>
            </div>
            </div>
    <a href="homepage.aspx" >BACK</a>


</asp:Content>


