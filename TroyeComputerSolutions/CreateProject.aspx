<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" Inherits="TroyeComputerSolutions.CreateProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Project</title>

    <style>

        body{

            background: #eeeeee;
        }

         .sidebar{

             height: 210%;
             width: 200px;
             position:fixed;
             z-index: 0;
             top:0;
             left: 0;
             
             background-color: #9dabc8;
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
             color:#000000;
             background-color:transparent;
             display:block;
         }
 .sidebar a:hover{
   
      color:#ffffff;
 }
 .sidebar a.active{
     background-color: #ccc;
 }
 .tabcontent{
     float: left;
     padding: 0px 12px;
     
     width: 70%;
     border-left: none;
     height: 300px;
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
    text-align:center;
}
th{
    height:50px;
    background-color:#ffffff;
    color:#000000;
    border:0px solid #ffffff;
    border-bottom-color:#eeeeee;
border-top-color:#eeeeee;
border-bottom-width:1px;
text-align:left;
}
td{
height:30px;
border:0px solid #eeeeee;
border-bottom-color:#eeeeee;
border-top-color:#eeeeee;
border-bottom-width:1px;
}
table{
    background-color:#ffffff;
    border-collapse:collapse;
    border-color:#ffffff;
    border-width:0px;
    
}

    </style>
</head>
    
<body>
    <form id="form1" runat="server">
     
      <br />
    <br />
    <br />
    
    <div class="sidebar" style="margin-top: auto;">
  <a href="AdminSection.aspx" class="tablinks"  onclick="openOption(event, 'Home')" id="defaultOpen">Home</a>

   <a href="#Skills" class="tablinks"  onclick="openOption(event, 'Home')" >Skills</a>
   <a href="#Projects" class="tablinks" id="active" onclick="openOption(event, 'Dashboard')">Create Project</a>
   <a href="#Employees" class="tablinks" onclick="openOption(event, 'Register')">Employees</a>
   <a href="#Previous Projects" class="tablinks" onclick="openOption(event, 'Projects')">Previous Projects</a>

       </div>
  
  
  <%--TABLE FOR ADDING PROJECTS--%>
         
    <div>
        <table id ="Projects" border =" 1" style ="margin-top:1%; margin-left:15%;  width:85%;">
            <tr>
               <%-- columns--%>
					<th>Task </th>
					<th>Skills</th>
					<th>Date</th>
                <th>Employee</th>
                <th>Company</th>
                <th>Create Job</th>
				</tr>
				<tr>
<td> <input name="Task"  type="Text" placeholder="Task" style="margin-top:0%; background-color:transparent;width:130px; height: 50%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:transparent; border-bottom-width:thin;" id="Task"/></td>
<td> <input name="Skills"  type="Text" placeholder="Skills" style="margin-top:0%; background-color:transparent; width:100%; height: 50%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:transparent; border-bottom-width:thin;" id="Skills"/></td>
<td > <input name="Date"  type="Date"  style="margin-top:0%; background-color:transparent; width:99%; height: 50%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:transparent; border-bottom-width:thin;" id="datepicker"/></td>
<td> <asp:ListBox ID="Employees" runat="server" placeholder="Employee" style="margin-top:0%; background-color:transparent; width:200px; height: 30%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:transparent; border-bottom-width:thin;" > </asp:ListBox></td>
<td> <input name="Company" class="Company" type="Text" placeholder="Company" style="border:1px solid #ffffff;margin-top:0%; background-color:transparent; width:100%; height: 50%; border-top-color:transparent; border-left-color:transparent; border-left-width:thin; border-left-style:solid; border-right-color:transparent;border-bottom-color:transparent; border-bottom-width:thin;" id="Company"/></td>
<td>
<button type="button" runat="server" onclick="addTask()" style="border-width: thin; margin-left:0%; width :130px; height: 50%; background-color:#000000; border-style:solid; border-width:thin; font-family:'Century Gothic'; color:#ffffff; outline-color: #000000;"  >Post</button></td></tr>
			
             <script>
                 function addTask()
                 {
            var table = document.getElementById("Projects");
            var row = table.insertRow(2);
            var Tasks = row.insertCell(0);
            var Skills = row.insertCell(1);
            var Date = row.insertCell(2);
            var Employee = row.insertCell(3);
            var Company = row.insertCell(4);
            var Button = row.insertCell(5);
            Tasks.innerHTML = document.getElementById("Task").value;
            Skills.innerHTML = document.getElementById("Skills").value;
            Date.innerHTML = document.getElementById("datepicker").value;
            Employee.innerHTML = document.getElementById("Employees").value;
            Company.innerHTML = document.getElementById("Company").value;

           
           }
       
                  </script>
        </table>
        

       
    </div>
    </form>
</body>
</html>
