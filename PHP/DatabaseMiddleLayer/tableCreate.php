<?php

include "DatabaseMiddleLayer.php";

	$array = array("localhost","root","Rushabh","zoo");
	$obj = new Mysql_DatabaseMiddleLayer($array);
	$data = array(
		'ID_person' => 'integer auto_increment' 
		,'name_person' => 'char(20) not null'
		/*,'human_inside'=> 'integer not null'
		,'exhibit_inside'=>'integer not null'
		,'isopen'=>'boolean not null'
		,'time_start'=>'datetime not null'
		,'time_end'=>'datetime  null'
		,'doors'=>'integer not null'*/
		);
	
	
	
	$data2 = array(
			//'ID_code' =>'Code_tb(ID_code)'
			 'ID_cage'=>'Cage_tb(ID_cage)'	
			);
	
	$obj->createTable('Maintance_person_tb' , $data ,'ID_person');


?>
