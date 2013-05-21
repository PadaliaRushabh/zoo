<?php include_once "../../DatabaseMiddleLayer/DatabaseMiddleLayer.php"; ?>
<!DOCTYPE>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Animal</title>
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
<strong>Animal Table</strong>
<br />
<br />

<table width="82%" border="0" bgcolor="#FFFFFF" >
  <thead>
 
  <tr>
	 <th class="text"> </th>
    <th  class="text" >Cage Id</th>
    <th  class="text" >Animal Id</th>
    <th  class="text" >Animal Record Id</th>
  </tr>
  
  </thead>
  
  <tbody>
	   <form name="frm_newcage" method="post" action="script_animalTable.php">
	  <?php  
		$connection = array("localhost" , "root" , "Rushabh" , "zoo");
	
		$_obj = new MYsql_DatabaseMiddleLayer($connection);
		$result = $_obj->select('Animal_tb');
		while($row = mysqli_fetch_array($result)){
				echo "<tr>\n";
				echo "<td align='center' bgcolor='#CCCCCC'> <input name='checkbox[]' type='checkbox' id='checkbox[]' value='{$row['ID_animal']}'></td>\n" ; 
				echo "<td bgcolor='CCCCCC' height='3'>";
				echo "<select name='dd_cage[]'>\n";
				$cage = $_obj->select('Cage_tb');
				while($CID = mysqli_fetch_array($cage)){
						if($CID['ID_cage'] == $row['ID_cage']){
							echo "<option value = '{$CID['ID_cage']}' selected>{$CID['ID_cage']} </option>";
						}
						else{
							echo "<option value = '{$CID['ID_cage']}'>{$CID['ID_cage']} </option>";
						}
				
					}	
				echo "</select>\n</td>\n";
				echo "<td bgcolor='#CCCCCC'><input name='ID_animal[]' type='text' height='23' bgcolor='#CCCCCC' value='{$row['ID_animal']}'></td>\n";
				
				echo "<td align='center' bgcolor='#CCCCCC'>";
				echo "<select name='dd_animalrecord[]'>\n";
				$Ani = $_obj->select('AnimalRecords_tb');
				if($row['ID_animalrecord']  == null){}
				else{
					while($ARID = mysqli_fetch_array($Ani)){
						if($ARID['ID_animalrecord'] == $row['ID_animalrecord']){
							echo "<option value = '{$ARID['ID_animalrecord']}' selected>{$ARID['name_animal']} </option>";
						}
						else{
							echo "<option value = '{$ARID['ID_animalrecord']}'>{$ARID['name_animal']} </option>";
						}
				
					}
				}
				echo "</select>\n</td>\n";
				echo "</tr>\n";
		}  
				echo "<tr>\n";
				echo "<td align='center' bgcolor='#CCCCCC'><input name='input_insert' type='submit' id='input_insert' value='Insert'></td>" ; 
				echo "<td bgcolor='CCCCCC' height='3'>";
				echo "<select name='input_dd_cage'>\n";
				$cage = $_obj->select('Cage_tb');
				while($CID = mysqli_fetch_array($cage)){
						if($CID['ID_cage'] == $row['ID_cage']){
							echo "<option value = '{$CID['ID_cage']}' selected>{$CID['ID_cage']} </option>";
						}
						else{
							echo "<option value = '{$CID['ID_cage']}'>{$CID['ID_cage']} </option>";
						}
				
					}	
				echo "</select>\n</td>\n";
				echo "<td bgcolor='#CCCCCC'><input name='input_ID_animal' disabled type='text' height='23' bgcolor='#CCCCCC' value='{$row['ID_animal']}'></td>\n";
				
				echo "<td align='center' bgcolor='#CCCCCC'>";
				echo "<select name='input_dd_animalrecord'>\n";
				$Ani = $_obj->select('AnimalRecords_tb');
				while($ARID = mysqli_fetch_array($Ani)){
						echo "<option value = '{$ARID['ID_animalrecord']}'>{$ARID['name_animal']} </option>";
				}
				
				echo "</select>\n</td>\n";
				echo "</tr>\n";
		
    
	?>
  
</tbody>
</table>
</div>
</div>
<br />
<center>
<input name="update" type="submit" style="font-weight:bold;height:40px; width:100px" value="update" />
<input name="delete" type="submit" style="font-weight:bold;height:40px; width:100px" value="delete" />
</center>
</form>

</body>
</html>
