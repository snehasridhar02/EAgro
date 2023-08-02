<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="eagro.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<section>
        <img src="images/eagromain.jpg" height="700" width="1350" />
   </section>
   
    <section>
       
      <div class="container">
         <div class="row">
            <div class="col-12">
               <center>
                  <h2>Our Process</h2>
                  <p><b>We have a Simple 3 Step Process</b></p>
               </center>
            </div>
         </div>
         <div class="row">
            <div class="col-md-4">
               <center>
                  <img width="130" src="images/signup.jpg" />
                  <h4>Sign Up</h4>
                  <p class="text-justify">Customer can sign up with their intial information to the system like name,mail id etc</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150" src="images/img5.jpg"/>
                  <h4>Find Prodcuts</h4>
                  <p class="text-justify">E-Agro  products are directly available from the farmer is useful, so find your product with your right choice.</p>
               </center>
            </div>
            <div class="col-md-4">
               <center>
                  <img width="150" src="images/visit.jpg"/>
                  <h4>Visit Us</h4>
                  <p class="text-justify">Visit us in E-Agro . There are variety of products that are readily available with reasonable price.</p>
               </center>
            </div>
         </div>
      </div>
   </section>
</asp:Content>
