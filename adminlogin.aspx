<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="eagro.adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div style="background-color:lightblue">
   
    <div class="container">
      
   
        <div class="row">
            
            <div class="col-md-6 mx-auto">
                <div class="card">
                      <div style="background-color:azure">
                    <div class="card-body">
                           <div class="row">
                            <div class="col">
                                <a href="farmerlogin.aspx">Farmer</a>
                                  <a href="adminlogin.aspx">Admin</a>
                                  <a href="customerlogin.aspx">Customer</a> 
                                 
                                <center>
                                    <img width="150" src="images/admin1.png" />

                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>
                                         Admin Login
                                    </h3>
                                    </center>
                    </div>
                </div>
                        <div class="row">
                            <div class="col">
                                <hr>

            </div>
        </div>
                       
                       
                        <div class="row">
                            <div class="col">
                                 <label>Admin ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Admin ID"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="id" runat="server" ErrorMessage="*Required" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                           
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Required" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                        </div>
                              
                       
                                 </div>
                  </div>
               </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br><br>
            
<</div>
         </div>
      </div>
   
             
</asp:Content>

