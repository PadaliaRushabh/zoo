
<?php
$host="localhost"; // Host name 
$username="root"; // Mysql username 
$password=""; // Mysql password 
$db_name="zoo1"; // Database name 
$tbl_name="test_mysql"; // Table name 

// Connect to server and select databse.
mysql_connect("$host", "$username", "$password")or die("cannot connect"); 
mysql_select_db("$db_name")or die("cannot select DB");



echo count($_POST['name']);
for($i=0 ; $i<count($_POST['name']) ; $i++){
// if successful redirect to delete_multiple.php 
	$id = $i + 1;
	$sql="UPDATE $tbl_name SET cage_name='".mysql_real_escape_string($_POST['name'][$i])."', cage_type='".mysql_real_escape_string($_POST['type'][$i])."',cage_location ='".mysql_real_escape_string($_POST['location'][$i])."'  WHERE id='$id'";
	$result=mysql_query($sql);
if($result){
echo "<meta http-equiv=\"refresh\" content=\"0;URL=update_multiple.php\">";

}
}

mysql_close();

?>