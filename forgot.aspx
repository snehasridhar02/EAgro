<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="forgot.aspx.cs" Inherits="eagro.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div style="background-image:url(images/clr.png)";
        <br />
        <br />
     <div>
        <center>
            Enter your registered email id:<asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br /><br /><br />
          <br /><br /><br />
           <asp:Button ID="Button1" runat="server" Text="Get Your Password" OnClick="Button1_Click" /><br />
            <br /><br /><br />          
            <br /><br /><br />          
          
            <asp:Label ID="Label1" runat="server" ></asp:Label>
            <br /><br /><br />
            <br /><br /><br />
            <br /><br />
            
        </center>
    </div>
</asp:Content>
