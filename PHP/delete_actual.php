
<?php
$host="localhost"; // Host name 
$username="root"; // Mysql username 
$password=""; // Mysql password 
$db_name="zoo1"; // Database name 
$tbl_name="test_mysql"; // Table name 

// Connect to server and select databse.
mysql_connect("$host", "$username", "$password")or die("cannot connect"); 
mysql_select_db("$db_name")or die("cannot select DB");


// Check if delete button active, start this 
//$result1 = FALSE;
//var_dump($_POST['checkbox']);
foreach($_POST['checkbox'] as $del_id){
//for($i=0;$i<count($_POST['checkbox']);$i++){
	//$del_id = $_POST['checkbox'][$i];
	//echo $del_id;
	//echo "debug";
	$sql = "DELETE FROM $tbl_name WHERE id='$del_id'";
	$result = mysql_query($sql);
}
// if successful redirect to delete_multiple.php 
if($result){
echo "<meta http-equiv=\"refresh\" content=\"0;URL=delete_multiple.php\">";
}

mysql_close();

?>