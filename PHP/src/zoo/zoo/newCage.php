<?php include_once "../../DatabaseMiddleLayer/DatabaseMiddleLayer.php"; ?>
<!DOCTYPE>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Caget</title>
<style>
body{
	background-color:#999;
}
#top{
	height:70px;
	line-height:70px;
	background-color:#333;
	
	border-bottom:5px solid white;
	font-size:36px;
	color:white;
	text-align:center;
	
}

#table-wrapper {
  position:relative;
}
#table-scroll {
  height:298px;
  overflow:auto;  
  margin-top:20px;
}
#table-wrapper table {
  width:100%;
    
}
#table-wrapper table thead th .text {
  position:absolute;
  width:auto;   
  bgcolor:#CCCCCC;
}
#bold{
	font:bold;
}

</style>
</head>

<body>
<div id="top"> Zoo Management
<table width="283" border="1" bgcolor="#FFFFFF" align="center">
  <tr>
    <td width="81" align="center"><a href="alertDetails.php">Alert details</a></td>
    <td width="80" align="center"><a href="newCage.php">Cage</a></td>
    <td width="100" align="center"><a href="animalTable.php">Animal</a></td>
    
  </tr>
</table>
</div>
<br />
<br />
<div id="table-wrapper" align="center">
<div id="table-scroll">
<center>
<strong>Cage Details</strong>
<table border="0" bgcolor="#FFFFFF" >
  <thead>
 
  <tr>
	 <th class="text">      </th>
    <th class="text" >Cage ID</th>
    <th class="text" >Cage Name</th>
    <th class="text" >Cage Height</th>
    <th class="text" >Cage Width</th>
    <th class="text" >Cage Length</th>
    <th class="text" >Cage Latitude</th>
    <th class="text">Cage Lobgitude</th>
    <th class="text">Number Of Doors</th>
    <th class="text">is door open</th>
    <th class="text">Human Inside</th>
    <th class="text">Exhibit Inside</th>
   
  </tr>
  </thead>
  <tbody>
	  <form name="frm_newcage" method="post" action="script_newCage.php">
<?php  
	$connection = array("localhost" , "root" , "Rushabh" , "zoo");
	
	$_obj = new Mysql_DatabaseMiddleLayer($connection);
	$result = $_obj->select('Cage_tb');
	while($row = mysqli_fetch_array($result)){
		echo "<tr>\n";
		echo "<td align='center' bgcolor='#CCCCCC'> <input name='checkbox[]' type='checkbox' id='checkbox[]' value='{$row['ID_cage']}'></td>\n" ; 
		echo "<td> <input name='ID_cage[]' type='text' height='23' bgcolor='#CCCCCC'  value = '{$row['ID_cage']}'></td>\n";
		echo "<td> <input name='name[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['name']}'></td>\n";
		echo "<td> <input name='size_height[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['size_height']}'></td>\n";
		echo "<td> <input name='size_width[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['size_width']}'></td>\n";
		echo "<td> <input name='size_length[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['size_length']}'></td>\n";
		echo "<td> <input name='location_latitude[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['location_latitude']}'></td>\n";
		echo "<td> <input name='location_longitude[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['location_longitude']}'></td>\n";
		echo "<td> <input name='doors[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['doors']}'></td>\n";
		echo "<td> <input name='isopen[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['isopen']}'></td>\n";
		echo "<td> <input name='human_inside[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['human_inside']}'></td>\n";
		echo "<td> <input name='exhibit_inside[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['exhibit_inside']}'></td>\n";
		echo "</tr>\n";	
	}
	
		
		echo "<tr>\n";
		echo "<td align='center' bgcolor='#CCCCCC'><input name='input_insert' type='submit' id='input_insert' value='Insert'></td>" ; 
		echo "<td> <input name='input_ID_cage' type='text' height='23' bgcolor='#CCCCCC' disabled value = ''></td>\n";
		echo "<td> <input name='input_name' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_size_height' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_size_width' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_size_length' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_location_latitude' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_location_longitude' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_doors' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_isopen' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_human_inside' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "<td> <input name='input_exhibit_inside' type='text' height='23' bgcolor='#CCCCCC' value=''></td>\n";
		echo "</tr>\n";	
	
?>


  </tbody>
</table>
</div>
</div>
<br />
<center>

<input name="update" type="submit" style="font-weight:bold;height:40px; width:100px" value="Update" id="update"/>
<input name="delete" type="submit" style="font-weight:bold;height:40px; width:100px" value="Delete" id="delete"/>
<input name="alert" type="submit" style="font-weight:bold;height:40px; width:100px" value="Add To Alert" id="alert"/>
</center>
</form>



</body>
</html>
