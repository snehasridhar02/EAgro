<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminadd.aspx.cs" Inherits="eagro.adminadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="background-color:cornsilk">
            <div class="navbar" style="border-width:3px;border-color:#333333;height:auto">
                <table style="width:700px;height:390px;background-color:floralwhite;" align="center">
                    <tr>
                        <td align="center" width="50%" colspan="2">
                            <h1>
                            Add Fertilizer
                        </h1>
                    <hr />
                    </td>
                      
                   

                       
                    <tr>
                        <td align="center" width="50%">
                            <h5>
                           Email
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                          </td>

                         </tr>
                      <tr>
                        <td align="center" width="50%">
                            <h5>
                            Fertilizer Name
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                          </td>
                        </tr>

                        <tr>
                        <td align="center" width="50%">
                            <h5>
                            Product Desc
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
                          </td>
                        </tr>

                        <tr>
                        <td align="center" width="50%">
                            <h5>
                            Image
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:FileUpload ID="imageupload" runat="server" />
                              
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Image is Mandatory" ControlToValidate="imageupload" Display="Dynamic"></asp:RequiredFieldValidator>
                          </td>
                        </tr>

                        <tr>
                        <td align="center" width="50%">
                            <h5>
                            Product Price
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
                          </td>
                        </tr>

                        <tr>
                        <td align="center" width="50%">
                            <h5>
                            Product Quantity
                        </h5>
                  
                    </td>
                          <td width="50%">
                              <asp:TextBox ID="txtquantity" runat="server"></asp:TextBox>
                          </td>
                        </tr>
                    <tr>
                        <td align="center" width="50%" colspan="2">
                            <asp:Button ID="Button1"  runat="server" Text="Supply" ForeColor="Black" Height="36px" Width="88px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
                 
            </div>
       </div>
    
      <asp:LinkButton ID="LinkButton1" runat="server" href="homepage.aspx">Home page</asp:LinkButton>
</asp:Content>
