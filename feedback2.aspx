<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="feedback2.aspx.cs" Inherits="eagro.feedback2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <!DOCTYPE html>

<html>
<head>
    <title></title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            font-family: 'Poppins', sans-serif;
        }

html, body {
    /*display: grid;
    height: 100%;*/
    place-items: center;
    text-align: center;
    background: #000;
}

.container {
    position: relative;
    width: 400px;
    background: #111;
    padding: 20px 30px;
    border: 1px solid #444;
    border-radius: 5px;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
}

    .rating_wrapper{
        direction:rtl;
    }

    .rating_wrapper input {
        display: none;
    }

.rating_wrapper label {
    font-size: 40px;
    color: #444;
    padding: 10px;
    float: right;
    transition: all 0.2s ease;
}


input:not(:checked) ~ label:hover,
input:not(:checked) ~ label:hover ~ label {
    color: #fd4;
}

input:checked ~ label {
    color: #fd4;
}
.container .text{
           font-size:25px;
           color:#666;
           font-weight :500;
           
}
/*.txt1 {
    height: 100px;
    width: 100%;
    overflow: hidden;
}*/

    .txt1 {
        outline: none;
        color: #eee;
        border: 1px solid #333;
        background: #222;
        padding: 10px;
        font-size: 17px;
        resize: none;
    }
    .txt2 {
        outline: none;
        color: #eee;
        border: 1px solid #333;
        background: #222;
        padding: 10px;
        font-size: 17px;
        resize: none;
    }
    .txt3 {
        outline: none;
        color: #eee;
        border: 1px solid #333;
        background: #222;
        padding: 10px;
        font-size: 17px;
        resize: none;
    }

.textarea txt1:focus {
    border-color: #444;
}

form .button {
    height: 45px;
    margin: 15px 0;
}

    form .button {
        height: 100%;
        border: 1px solid #444;
        outline: none;
        background: #222;
        color: #999;
        font-size: 17px;
        font-weight: 500;
        text-transform: uppercase;
        cursor: pointer;
        transition: all 0.3s ease;
    }

        form .button:hover {
            background: #1b1b1b;
        }




       
        
    </style>
</head>
<body>
     <form id="form1">
    <div class="container">
        
       <center>
         <div class ="textarea">
             <br />
             <br />
             <asp:TextBox ID="TextBox1" runat="server" placeholder="Describe your experiences.." CssClass ="txt1"  TextMode="MultiLine" Width="304px"></asp:TextBox><br /><br />
             <asp:TextBox ID="TextBox2" runat="server" placeholder="User Name" CssClass ="txt2" Width="304px"></asp:TextBox><br /><br />
             <asp:TextBox ID="TextBox3" runat="server" placeholder="Email ID" CssClass ="txt3" Width="304px"></asp:TextBox><br /><br />
                </div></center>
                <div class ="btn">
                    <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="button" OnClick="Button1_Click"   />
                </div>
        
        <div>
        <asp:Label ID="Label6" runat="server" Text="Thanks For Rating Us!" CssClass="lbl" Visible="False" Font-Bold="True" ForeColor="White"></asp:Label>
        </div>    
    </div>
<br />
   
        
    </form>
</body>
</html>

</asp:Content>
