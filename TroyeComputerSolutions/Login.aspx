<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TroyeComputerSolutions.Login" %>

<!DOCTYPE html>

<html >
<head >
    <meta charset="utf-8" content="IE=edge">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <meta name="description" content="Login page">
    <meta name="author" content="Gomolemo Mkutshwa">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/bootstrap.min.js"></script>
    <script src="scripts/jquery-3.0.0.min.js"></script>

	<style>
     /*#4f85a4
         FCFAF1
         9DABC8
         334666
         f5f7fa
     */
	    body {
	        /*background-color:#ffffff;*/
	        /*background-image: url("9913244c2906439aa465d23d221339e8.jpg");*/
	       	        background: #DEDEDE;

	        background-size: cover;
	    }

	    img {
            position:center;
	        width: 1100px;
	        height: 550px;
	        padding: 10px;
	        margin-left: 30px;
	        margin-top: 100px;
	        margin-bottom: 60px;
	      
	    }
        .Login{
    background-color:#ffffff;
    width:1200px;
    height: 550px;
    margin-top: 100px;
    margin-left: 80px;


        }
	    .input {
	        position: absolute;
	        width: 500px;
	        height: 590px;
	        margin-left: 188px;
	        background-color: #9DABC8;
	        top: 80px;
	        margin-bottom: 10px;
	    }
       
        
        
p{
	margin-top:20px;
    margin-right: 430px;
	text-align:center;
	font-family:"Century Gothic";
	font-size:40px;
    color:#000000;
	
}
p1{
	margin-left: 100px;
	margin-top:0px;
	text-align:
	justify;
    color:#000000  ;
	font-family:"Century Gothic";
	font-size:25px;
	
}
p2{
margin-left: 100px;
	margin-top:0px;
	text-align:
	center;
    color:#000000  ;
	font-family:"Century Gothic";
	font-size:15px;
}

        </style>
  
    </head>
<body>
    
    <form id="form1" runat="server">
        
       
    <div class="Login">
         <img src="20190801_234731.jpg" style="width:13%; height: 25%; margin-top:5%;"/>
      
        <input name="Name" type="Text" placeholder="Name" style="margin-top:0%; background-color:transparent; width:30%; height: 10%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 49%; " id="txtName"/>

<br/>
<br/>
<input name="Password1" type="password"  placeholder="Password"  style="width :30%; height: 10%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 65%; "/>
<br/>
<br/>
<br/>
 <asp:Button runat="server" Text="Login" OnClick="btnLogin_Click" style="border-width: thin; margin-left: 68%; width :24%; height: 9%; background-color:#000000; border-style:solid; border-width:thin; font-family:'Century Gothic'; color:#ffffff; outline-color: #000000; border-radius:25px;" id="btnLogin" />


<div class="input">
    <br/>
    <br />
    <br />
    <br />

        <p1> 
   
        Welcome to Troye.


</p1>
    <br />
    <br />
    <p2>[THE SLOGAN WOULD GO HERE!!]
        <br />
       
        <BR />
        <br />
    </p2>
     <br/>
    <br />
    <br />

</div>
    
</div>
    </form>
</body>

</html>
