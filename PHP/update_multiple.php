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

// Count table rows 
$count=mysql_num_rows($result);
?>

<table width="500" border="0" cellspacing="1" cellpadding="0">
<form name="form1" method="post" action="update_actual.php">
<tr> 
<td>
<table width="500" border="0" cellspacing="1" cellpadding="0">

<tr>
<td align="center"><strong>Id</strong></td>
<td align="center"><strong>Cage Name</strong></td>
<td align="center"><strong>Cage Type</strong></td>
<td align="center"><strong>Cage Location</strong></td>
</tr>


<?php
while($rows=mysql_fetch_array($result)){
?>
<tr>

<td align="center">
<?php $id[]=$rows['id']; ?><?php echo $rows['id']; ?>
</td>
<td align="center">
<input name="name[]" type="text" id="cage_name" value="<?php echo $rows['cage_name']; ?>">
</td>
<td align="center">
<input name="type[]" type="text" id="cage_type" value="<?php echo $rows['cage_type']; ?>">
</td>
<td align="center">
<input name="location[]" type="text" id="cage_location" value="<?php echo $rows['cage_location']; ?>">
</td>
<?php
}
?>
</tr>

<tr>
<td colspan="4" align="center"><input type="submit" name="Submit" value="Submit"></td>
</tr>
</table>
</td>
</tr>
</form>
</table>

<?php

// Check if button name "Submit" is active, do this

$result1 = FALSE; 
?>

<?php /*
        if(isset($_POST['Submit']))
        {
		
            while(list($index,$record)=each($_POST['data']))
            {
                $sql=mysql_query("UPDATE $tbl_name SET cage_name='".mysql_real_escape_string($record['cage_name'])."', cage_type='".mysql_real_escape_string($record['cage_type'])."',cage_location ='".mysql_real_escape_string($record['cage_location'])."  WHERE id=".intval($index));
                $result1=mysql_query($sql);
            }
        }*/
?>
<?php
/*if($result1){
header("location:update_multiple.php");
}*/
mysql_close();
?>