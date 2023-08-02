<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="payment.aspx.cs" Inherits="eagro.payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:magenta">

    <div>
      <table  align="center" style="margin-top:5px;width:553px; height:696px;" bgcolor="pink">
          <tr>
              <td colspan="2" align="center" style="vertical-align:top">
                      <asp:Label ID="Label1" runat="server" Text="Card Details" Font-Bold="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
              </td>
          </tr>
          <tr>
              <td   align="center" style="vertical-align:top">
                  
                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Height="20px"  Width="188px" placeholder="First Name" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is Empty" ControlToValidate="TextBox1" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Name must be in characters" ControlToValidate="TextBox1" ForeColor="Red" ValidationExpression="^[A_Za-z]$"></asp:RegularExpressionValidator>--%>
              </td>
              <td   align="center" style="vertical-align:top">
                    <asp:TextBox ID="TextBox6" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Height="20px"  Width="188px" placeholder="Last Name"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Name is Empty" ControlToValidate="TextBox6" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Name must be in characters" ControlToValidate="TextBox6" ForeColor="Red" ValidationExpression="^[A_Za-z]$"></asp:RegularExpressionValidator>--%>
              </td>
          </tr>
          <tr>
              <td colspan="2" align="center">
                     <asp:Image ID="Image1" runat="server" BorderColor="Black" ImageUrl="~/images/Credit-Card-Visa-Master-Card.jpg" Width="438px" />
              </td>
          </tr>
          <tr>
              <td  colspan="2" align="center">
                   <asp:Label ID="Label2" runat="server" Text="Card Number" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
              </td>
          </tr>
          <tr>
              <td colspan="2" align="center" style="vertical-align:top">
                    <asp:TextBox ID="TextBox2" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Height="20px" Width="388px" placeholder="16 digits" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Card Number is Empty" ControlToValidate="TextBox2" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="card No must be of 16 digits" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="[0-9]{16}">*</asp:RegularExpressionValidator>
              </td>
            
          </tr>
          <tr>
              <td align="center">
                  
                      <asp:Label ID="Label3" runat="server" Text="Expiry Date" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
              </td>
              <td align="center">
                   <asp:Label ID="Label4" runat="server" Text="CVV" Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
              </td>
          </tr>
          <tr>
              <td  align="center" style="vertical-align:top">
                   <asp:TextBox ID="TextBox3" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Height="20px" Width="188px" placeholder="MM/YY/(Eg:061996)" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Expiry date is empty" ControlToValidate="TextBox3" ForeColor="Red">*</asp:RequiredFieldValidator>
              </td>
              <td align="center" style="vertical-align:top">
                    <asp:TextBox ID="TextBox4" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="Medium" Height="20px" Width="188px" placeholder="3 digits"  ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="CVV is Empty" ControlToValidate="TextBox4" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="CVV No must be of 3 digits" ControlToValidate="TextBox4" ForeColor="Red" ValidationExpression="[0-9]{3}">*</asp:RegularExpressionValidator>
              </td>
              
          </tr>
          <tr>
              <td colspan="2" align="center" style="vertical-align:top">
                   <asp:TextBox ID="TextBox5" runat="server" BorderColor="Black" BorderWidth="2px" Font-Bold="True" Font-Size="X-Large" Height="41px" Width="400px" placeholder="Billing Adress" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Address is Empty" ControlToValidate="TextBox5" ForeColor="Red">*</asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
              <td align="center" style="vertical-align:top">
                  <asp:Label ID="Label5" runat="server" Text="Amount"></asp:Label>
              </td>
              <td align="center" style="vertical-align:top">
                  <asp:TextBox ID="TextBox7" runat="server"  placeholder="Amount"></asp:TextBox>
              </td>
          </tr>
         
          
         
          <tr>
              <td colspan="2" align="center">
                  <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="Black" BorderColor="White" BorderWidth="2px" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="44px" Width="188px" OnClick="Button1_Click" />
              </td>
          </tr>
          
          <tr>
              <td colspan="2" >
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" HeaderText="Fix the following errors" />
              </td>
          </tr>
          <tr>
              <td colspan="2" >
 <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/placeorder.aspx" ForeColor="Black">previous Page</asp:HyperLink>
              </td>
          </tr>
      </table>
      <br />
  </div>
             </div>
</asp:Content>
