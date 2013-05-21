<?php include_once "../../DatabaseMiddleLayer/DatabaseMiddleLayer.php"; ?>
<!DOCTYPE>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Alert</title>
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
<strong>Alert Details</strong>
<br />
<br />

<table border="0" bgcolor="#FFFFFF" >
  <thead>
 
  <tr>
	 <th class="text">      </th>
    <th class="text" >Cage ID</th>
    <th class="text" >Alert ID</th>
    <th class="text" >Code ID</th>
    <th class="text" >Admin Message</th>
    <th class="text" >Alert Status</th>
    <th class="text">Time Start</th>
    <th class="text">Time End</th>
   
  </tr>
</thead>
<tbody> 
 <form name="frm_newcage" method="post" action="script_alert.php">
<?php  
	$connection = array("localhost" , "root" , "Rushabh" , "zoo");
	
	$_obj = new Mysql_DatabaseMiddleLayer($connection);
	$result = $_obj->select('Alert_details_tb');
	while($row = mysqli_fetch_array($result)){
		echo "<tr>\n";
		echo "<td align='center' bgcolor='#CCCCCC'> <input name='checkbox[]' type='checkbox' id='checkbox[]' value='{$row['ID_alert_details']}'></td>\n" ; 
		$ID_Cage = $_obj->select('Cage_tb' ,'ID_cage' );
		echo "<td align='center' bgcolor='#CCCCCC'>"; 
		if($row['ID_cage']  == null){}
		else{
			echo "<select name='dd_cage[]'>\n";
			while($CID = mysqli_fetch_array($ID_Cage)){
			
				if($CID['ID_cage'] == $row['ID_cage']){
					echo "<option value = '{$CID['ID_cage']}' selected>{$CID['ID_cage']} </option>";
				}
				else{
					echo "<option value = '{$CID['ID_cage']}'>{$CID['ID_cage']} </option>";
				}
			}
		echo "</select>\n</td>\n";
		}
		echo "<td height='23' bgcolor='#CCCCCC'><input name='ID_alert_details[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['ID_alert_details']}'></td>\n";
		$ID_Code = $_obj->select('Code_tb' ,'ID_code' );
		echo "<td align='center' bgcolor='#CCCCCC'>";
		echo "<select name='dd_code[]'>\n";
		while($COID = mysqli_fetch_array($ID_Code)){
			
			if($COID['ID_code'] == $row['ID_code']){
					echo "<option value = '{$COID['ID_code']}' selected>{$COID['ID_code']} </option>";
			}
			else{
					echo "<option value = '{$COID['ID_code']}'>{$COID['ID_code']} </option>";
				}
		}	
		echo "</select>\n</td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='admin_message[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['admin_message']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='isopen[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['isopen']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='time_start[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['time_start']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='time_end[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['time_end']}'></td>\n";
		echo "</tr>\n";
	}
	
	
	echo "<tr>\n";
		echo "<td align='center' bgcolor='#CCCCCC'><input name='input_insert' type='submit' id='input_insert' value='Insert'></td>" ; 
		$ID_Cage = $_obj->select('Cage_tb' ,'ID_cage' );
		echo "<td align='center' bgcolor='#CCCCCC'>"; 
			echo "<select name='input_dd_cage'>\n";
			while($CID = mysqli_fetch_array($ID_Cage)){
			
				if($CID['ID_cage'] == $row['ID_cage']){
					echo "<option value = '{$CID['ID_cage']}' selected>{$CID['ID_cage']} </option>";
				}
				else{
					echo "<option value = '{$CID['ID_cage']}'>{$CID['ID_cage']} </option>";
				}
			}
		echo "</select>\n</td>\n";
		
		echo "<td height='23' bgcolor='#CCCCCC'><input name='input_ID_alert_details' type='text' height='23' bgcolor='#CCCCCC' disabled value='{$row['ID_alert_details']}'></td>\n";
		$ID_Code = $_obj->select('Code_tb' ,'ID_code' );
		echo "<td align='center' bgcolor='#CCCCCC'>";
		echo "<select name='input_dd_code'>\n";
		while($COID = mysqli_fetch_array($ID_Code)){
			
			if($COID['ID_code'] == $row['ID_code']){
					echo "<option value = '{$COID['ID_code']}' selected>{$COID['ID_code']} </option>";
			}
			else{
					echo "<option value = '{$COID['ID_code']}'>{$COID['ID_code']} </option>";
				}
		}	
		echo "</select>\n</td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='input_admin_message' type='text' height='23' bgcolor='#CCCCCC' value='{$row['admin_message']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='input_isopen' type='text' height='23' bgcolor='#CCCCCC' value='{$row['isopen']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='input_time_start' type='text' height='23' bgcolor='#CCCCCC' value='{$row['time_start']}'></td>\n";
		echo "<td height='23' bgcolor='#CCCCCC'><input name='input_time_end' type='text' height='23' bgcolor='#CCCCCC' value='{$row['time_end']}'></td>\n";
		echo "</tr>\n";
	
	
	
	
	
?>
</tbody>
</table>
</div>
</div>
<br />
<center>
<input name="update" type="Submit" style="font-weight:bold;height:40px; width:100px" value="Update" id="update"/>
<input name="delete" type="Submit" style="font-weight:bold;height:40px; width:100px" value="Delete" id='delete'/>
</center>
</form>

</body>
</html>
