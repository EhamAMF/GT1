<%@ page language="VB" autoeventwireup="false" inherits="_Default, App_Web_jwccgwmu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width; initial-scale=1.0;">
</head>
<body>

<style type="text/css" >
	      
	      body {
	          background-color : #eee ;
	          margin :0px;
	          padding :0px;
	          }

input
{
        box-sizing:border-box;
	    font-size: 24px;
	    margin: 5px 0px;
	    background-color : black ;
	    color:White;
	    width :100%
}

	 .MainDiv  
	 {
	                    box-sizing:border-box;
	                   width: 400px;
	                   margin :50px auto;
	                   padding :10px;
	                   background-color : white;
	                   text-align :center ;
	                   box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
	                   }

	@media screen and (max-width: 600px) {

    .MainDiv  
	 {
	   width: 90%;
	                   
	                   }
	}


	      
	    </style>


<div class = "MainDiv" >
    <form  id="form1" runat="server" method="post" action="Default.aspx">

		<input class= "txt" type="text" name="UserName" placeholder="Username" value = "ehab">
		<br/>
		<input type="Password" name="Password" placeholder="Password">
		<br/>
	
		<input type="text" name="ClientName" placeholder="ClientName" >
        	<br/>
		<input type="text" name="PhoneNumber" placeholder="PhoneNumber" >
        	<br/>
		<input type="text" name="Address" placeholder="Address"  value>
		<br/>
		<input type="number" name="LicensePWD" placeholder="LicensePWD" >
        	<br/>
		<input type="number" name="AppID" placeholder="AppID" value = "1">
        	<br/>
		<input type="number" name="Servers" placeholder="Servers" value = "1">
		<br/>
		<input type="number" name="Clients" placeholder="Clients" value = "0">
        	<br/>
        <asp:Button ID="Button1" runat="server" Text="Submit !" />
        <br />
        <p id="pOutPut" runat="server">
     
        </p>

        </form>
  </div>
</body>
</html>
