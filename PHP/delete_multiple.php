<?php
$host="localhost"; // Host name 
$username="root"; // Mysql username 
$password=""; // Mysql password 
$db_name="zoo1"; // Database name 
$tbl_name="test_mysql"; // Table name 

// Connect to server and select databse.
mysql_connect("$host", "$username", "$password")or die("cannot connect"); 
mysql_select_db("$db_name")or die("cannot select DB");

$sql="SELECT * FROM $tbl_name";
$result=mysql_query($sql);

$count=mysql_num_rows($result);
?>

<table width="400" border="0" cellspacing="1" cellpadding="0">
<tr>
<td><form name="form1" method="post" action="delete_actual.php">
<table width="400" border="0" cellpadding="3" cellspacing="1" bgcolor="#CCCCCC">
<tr>
<td bgcolor="#FFFFFF">&nbsp;</td>
<td colspan="4" bgcolor="#FFFFFF"><strong>Delete cage entries</strong> </td>
</tr>
<tr>
<td align="center" bgcolor="#FFFFFF">#</td>
<td align="center" bgcolor="#FFFFFF"><strong>Id</strong></td>
<td align="center" bgcolor="#FFFFFF"><strong>Cage Name</strong></td>
<td align="center" bgcolor="#FFFFFF"><strong>Cage Type</strong></td>
<td align="center" bgcolor="#FFFFFF"><strong>cage Location</strong></td>
</tr>

<?php
while($rows=mysql_fetch_array($result)){
?>

<tr>
<td align="center" bgcolor="#FFFFFF"><input name="checkbox[]" type="checkbox" id="checkbox[]" value="<?php echo $rows['id']; ?>"></td>
<td bgcolor="#FFFFFF"><?php echo $rows['id']; ?></td>
<td bgcolor="#FFFFFF"><?php echo $rows['cage_name']; ?></td>
<td bgcolor="#FFFFFF"><?php echo $rows['cage_type']; ?></td>
<td bgcolor="#FFFFFF"><?php echo $rows['cage_location']; ?></td>
<td colspan="5" align="center" bgcolor="#FFFFFF"><input name="delete[]" type="submit" id="delete" value="Delete"></td>
</tr>

<?php
}
?>

<tr>
<td colspan="5" align="center" bgcolor="#FFFFFF"><input name="delete" type="submit" id="delete" value="Delete"></td>
</tr>

<?php /*

// Check if delete button active, start this 
//$result1 = FALSE;
if (isset($_POST['delete'])) {
for($i=0;$i<$count;$i++){
$del_id = $checkbox[$i];
$sql = "DELETE FROM $tbl_name WHERE id='$del_id'";
$result = mysql_query($sql);
}
// if successful redirect to delete_multiple.php 
if($result){
echo "<meta http-equiv=\"refresh\" content=\"0;URL=delete_multiple.php\">";
}
}
mysql_close();*/
?>

</table>
</form>
</td>
</tr>
</table>