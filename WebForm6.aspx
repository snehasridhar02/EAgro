<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="eagro.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <style>
        body {
    margin: 0;
    font-family: Arial, Helvetica, sans-serif;
    background-color: #000000;
    color: #ffffff;
}

* {
    box-sizing: border-box;
}

h1 {
    color: yellow;
    font-size: 50px;
}

.container {
    margin: auto;
    text-align: center;
    margin-top: 200px;
}
/*label {
    display :inline-block;
    background-color:#ffffff;
    width :100px;
    height :50px;
}*/
.rating_wrapper {
    direction :rtl;
}
.rating_wrapper input{
    display:none ;
}
.rating_wrapper label {
    display :inline-block;
    width:130px;
    position :relative ;
    cursor :pointer ;
}
.rating_wrapper label:before {
    content:"\2605";
    position :absolute ;
    font-size:100px;
    display:inline-block;
    top:0;
    left:0;
}
.rating_wrapper label:after {
    content:"\2605";
    position :absolute ;
    font-size:100px;
    display:inline-block;
    top:0;
    left:0;
    color :yellow ;
    opacity :0;
}
.rating_wrapper label:hover:after,
.rating_wrapper label:hover ~ label:after,
.rating_wrapper input:checked ~ label:after{
    opacity: 1;
}



    </style>
</head>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
     <form id="form1" runat="server">
    <div class="container">
        
        <div class="rating_wrapper">
            <asp:CheckBox ID="str1" runat="server" />
            <asp:Label  runat="server" Text="" AssociatedControlID="str1" CssClass="label"></asp:Label>
            <asp:CheckBox ID="str2" runat="server" />
            <asp:Label  runat="server" Text="" AssociatedControlID="str2" CssClass="label"></asp:Label>
            <asp:CheckBox ID="str3" runat="server" />
            <asp:Label  runat="server" Text="" AssociatedControlID="str3" CssClass="label"></asp:Label>
            <asp:CheckBox ID="str4" runat="server" />
            <asp:Label  runat="server" Text="" AssociatedControlID="str4" CssClass="label"></asp:Label>
            <asp:CheckBox ID="str5" runat="server" />
            <asp:Label  runat="server" Text="" AssociatedControlID="str5" CssClass="label"></asp:Label>


            
        </div>
         <div class ="textarea">
             <asp:TextBox ID="TextBox1" runat="server" placeholder="Describe your experiences.." CssClass ="txt1"  TextMode="MultiLine"></asp:TextBox>
                <br />
             <br />
                </div>
                <div class ="btn">
                    <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click"  />
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Thanks For Rating Us" Visible="False"></asp:Label>
                </div>
        
            
    </div>

   
        
    </form>
</body>
</html>

</asp:Content>
