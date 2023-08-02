<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeFile="customerdetail.aspx.cs" Inherits="eagro.customerdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <center>
        <div style="background-color:cornsilk">
             <div class="navbar" style="border-width:3px;border-color:#333333;height:auto">
        <div class="row">
            <div class="col-md-6" style="margin-left:290px;margin-top:10px;margin-bottom:10px" >
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" HorizontalAlign="Center" ForeColor="#333333" GridLines="None">
              <AlternatingRowStyle BackColor="White" />
              <Columns>

                  <asp:BoundField DataField="id" HeaderText="Product id" />
                  
                    <asp:BoundField DataField="fullname" HeaderText="full name" />
                   <asp:BoundField DataField="dob" HeaderText="Date of birth" />
                   
                  <asp:BoundField DataField="contact" HeaderText="Contact" />
                   <asp:BoundField DataField="email" HeaderText="Email" />
                  
                  <asp:BoundField DataField="state" HeaderText="State" />
                  <asp:BoundField DataField="city" HeaderText="City" />
                   <asp:BoundField DataField="pincode" HeaderText="Pincode" />
                  <asp:BoundField DataField="fulladdress" HeaderText="Full address" />
                  <asp:BoundField DataField="username" HeaderText="Username" />
                   <asp:BoundField DataField="password" HeaderText="Password" />
                  
              </Columns>
              <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
              <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
              <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
              <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
              <SortedAscendingCellStyle BackColor="#FDF5AC" />
              <SortedAscendingHeaderStyle BackColor="#4D0000" />
              <SortedDescendingCellStyle BackColor="#FCF6C0" />
              <SortedDescendingHeaderStyle BackColor="#820000" />


          </asp:GridView>

             
       
        
    
            </div>
        </div>
           
        </div>
            </div>
    </center>
    <asp:LinkButton ID="LinkButton1" runat="server" href="homepage.aspx">Home page</asp:LinkButton>

</asp:Content>
