<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSection.aspx.cs" Inherits="TroyeComputerSolutions.AdminSection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>AdminSection</title>
<%--    9DABC8--%>
<style>

        body{

            background: #EEEEEE;
        }
        /*406D95*/
 .sidebar{

             height: 210%;
             width: 200px;
             position:fixed;
             z-index: 0;
             top:0;
             left: 0;
             
             background-color: #406D95;
             overflow:auto;
             padding-top: 0px;
             margin-top:0px;
         } 
         .sidebar a{
             margin-top:20px;
             padding: 10px 16px;
             cursor:pointer;
             width:100%;
             float:left;
             text-decoration: none;
             font-size: 20px;
             color:#EEE;
             background-color:transparent;
             display:block;
         }
 .sidebar a:hover {
   
      color:#ffffff;
 }
 .sidebar a.active{
     color: #ffffff;
 }
 
 .tabcontent{
     float: left;
     padding: 0px 12px;
     width: 80%;
     border-left: none;
     height: 50px;
 }
 h1{

    font-family:"Century Gothic";
    font-size:x-large;
 }
 hr{
     border-color:#000000;
     border-width:thin
     ;
 }

 @media screen and (max-height: 450px){
     .sidebar{padding-top:15px;}
     .sidebar a{font-size: 18px;}
 }
 
.topBar a{

    float:right;
    margin-right:70px;
    color: #000000;
    text-decoration:none;
    font-size:20px;
}


    </style>
</head>
<body>
     <form id="form1" runat="server">
        <div class="topBar" style="width:100%; height:10%; position:absolute; background-color:#ffffff;left: 0; top:0;float:right; margin-right:0;">
   <a href="Bathrooms.aspx"  > USER PROFILE BASIC INFO</a>
 
       </div>
      <br />
    <br />
    <br />

    <%--sidebar--%>

    <div class="sidebar" id="mySidenav" >

     <a href="#Dashboard" class="active" onclick="openOption(event, 'Home')">Troye</a>
     <a href="#Dashboard" class="tablinks" id="defaultOpen" onclick="openOption(event, 'Dashboard')">Dashboard</a>
     <a href="#Employees" class="tablinks"  onclick="openOption(event, 'Employees')">Employees</a>
     <a href="#Register" class="tablinks" onclick="openOption(event, 'Register')">Register</a>
     <a href="CreateProject.aspx" class="tablinks" onclick="openOption(event, 'Projects')">Projects</a>

       </div>
         <div id="Dashboard" class="tabcontent" style="width:900px;height: 1570px;margin-top: 90px; margin-left: 290px;  margin-bottom: 15px; background-color:#FFFFFF;">
             <h1>DASHBOARD </h1>
         </div>
         <div  style="width:200px;margin-top: 5px; margin-left: 290px;  margin-bottom: 5px;">
           <h1>Register New Employees Below </h1></div>
  <%--REGISTER A USER--%>
  
<div id="Register" class="tabcontent" style="width:900px;height: 2200px;margin-top: 90px; margin-left: 290px;  margin-bottom: 15px; background-color:#FFFFFF;">
          <h1>Personal </h1>
    
<asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> <input name="Name" type="text"  style="margin-top:0%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; " id="txtName"/>
<br />
<asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label><input name="Surname" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 27%; " id="txtSurname"/>
<br />
<asp:Label ID="Label3" runat="server" Text="Id"></asp:Label> <input name="Name" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left:32%; " id="txtId"/>
<br />
<br />  
         
<h1>Conatact </h1>
    <hr /> 
<asp:Label ID="Label4" runat="server" Text="Address"></asp:Label><input name="Adress" type="text" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 27%; " id="txtAddress"/>
<br />
<asp:Label ID="Label5" runat="server" Text="City"></asp:Label><input name="City" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; " id="txtCity"/>
<br />
<asp:Label ID="Label6" runat="server" Text="Province"></asp:Label><input name="Email" type="text"  style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; " id="txtProvince"/>
<br />
<asp:Label ID="Label7" runat="server" Text="Phone"></asp:Label><input name="Phone" type="text" placeholder="+2712345678" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 28%; " id="txtNumber"/>
<br />
<br />
<h1>Skills </h1>
    <hr />

<asp:Label ID="Label13" runat="server" Text="Skills"></asp:Label><input name="Name" type="text" placeholder="UX Designer" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; " id="txtUsername"/>
<br />
<asp:Label ID="Label14" runat="server" Text="Years"></asp:Label><input name="Password1" type="number"   style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />

<h1>Account </h1>
    <hr />
<asp:Label ID="Label8" runat="server" Text="Email"></asp:Label><input name="Email  " type="text" placeholder="@gmail.com" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 29%; " id="txtEmail"/>
<br />
<asp:Label ID="Label9" runat="server" Text="Username"></asp:Label><input name="Name" type="text" placeholder="5559333" style="margin-top:2%; background-color:transparent; width:50%; height: 5%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; " id="txtUsername"/>
<br />
<asp:Label ID="Label10" runat="server" Text="Password"></asp:Label><input name="Password1" type="password"  placeholder="jUICYmilk5!"  style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br />
<asp:Label ID="Label11" runat="server" Text="Confirm"></asp:Label><input name="Confirm" type="password"  style="margin-top:2%;width :50%; height: 5%; background-color:transparent; border-top-color:transparent;border-left-color:transparent; border-left-style:solid; border-left-width:thin; border-right-color:transparent;border-bottom-color:#000000; border-bottom-width:thin; margin-left: 26%; "/>
<br/>
<button  onclick="btnRegister_Click" style="margin-top:10%; border-width: thin; margin-left: 39%; width :24%; height: 50px; background-color:#000000; border-style:solid; border-width:thin; font-family:'Century Gothic'; color:#ffffff; outline-color: #000000; border-radius:25px; margin-bottom:20px;" id="btnRegister ">Register</button>

        </div>
      

        
    <script>
        //get the element with id = "defaultOpen" and click on it
        function openOption(evt, Option) {
            var i, tabcontent, tablinks;
            tabcontent = document.getElementsByClassName("tabcontent");
            for (i = 0; i < tabcontent.length; i++) {
                tabcontent[i].style.display = "none";
            }
            tablinks = document.getElementsByClassName("tablinks");
            for (i = 0; i < tablinks.length; i++) {
                tablinks[i].className.replace("active", "");
            }
              document.getElementById(Option).style.display = "block";
            evt.currentTarget.className += "active";
        }

        
        // to add a new row of newly entered tasks
       
      
    </script>
       
            
         </form>
</body>
</html>
