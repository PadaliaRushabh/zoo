<?php error_reporting (E_ALL ^ E_NOTICE); ?>
<?php

$host="localhost"; // Host name 
$username="root"; // Mysql username 
$password="Rushabh"; // Mysql password 
$db_name="zoo1"; // Database name 
$tbl_name="test_mysql"; // Table name 

// Connect to server and select database.
mysql_connect("$host", "$username", "$password")or die("cannot connect"); 
mysql_select_db("$db_name")or die("cannot select DB");

// Get values from form 

$cage_name=$_POST["cage_name"];
$cage_type=$_POST["cage_type"];
$cage_location=$_POST["cage_location"];

// Insert data into mysql 
$sql="INSERT INTO $tbl_name(cage_name, cage_type, cage_location)VALUES('$cage_name', '$cage_type', '$cage_location')";
$result=mysql_query($sql);

// if successfully insert data into database, displays message "Successful". 
if($result){
echo "Successful";
echo "<BR>";
echo "<a href='add_cage.html'>Back to main page</a>";
}

else {
echo "ERROR";
}
?> 

<?php 
// close connection 
mysql_close();
?>
