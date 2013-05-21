<?php
include_once "../../DatabaseMiddleLayer/DatabaseMiddleLayer.php"; 
/*
 * script_newCage.php
 * 
 * Copyright 2013 Rushabh Padalia <rushabh@rushabh-ubuntu-13>
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,	
 * MA 02110-1301, USA.
 * 
 * 
 */

	$connection = array("localhost" , "root" , "Rushabh" , "zoo");
	$_obj = new Mysql_DatabaseMiddleLayer($connection);
	if(isset($_POST['delete'])){
		foreach($_POST['checkbox'] as $del_id){
			$where  = "ID_cage = " .$del_id ;
			$result = $_obj->delete('Cage_tb' , $where);
		} 
		if($result){
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
		else{
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
	}
	else if(isset($_POST['update'])){
		#for($i=0 ; $i<$count($_POST['checkbox'] ; $i++){
		$count = 0;
		#var_dump($_POST);
		foreach($_POST['ID_cage'] as $update_id){
			if($update_id == $_POST['ID_cage'][$count]){
				$where = "ID_cage = " . $update_id;
				$data = array(
					'name' => $_POST['name'][$count],
					'size_height'=>  $_POST['size_height'][$count],
					'size_width'=>  $_POST['size_width'][$count],
					'size_length'=> $_POST['size_length'][$count],
					'location_latitude' =>  $_POST['location_latitude'][$count],
					'location_longitude' =>  $_POST['location_longitude'][$count],
					'doors' =>  $_POST['doors'][$count],
					'isopen' =>  $_POST['isopen'][$count],
					'human_inside' =>  $_POST['human_inside'][$count],
					'exhibit_inside' =>  $_POST['exhibit_inside'][$count]
				);
				$result = $_obj->update( 'Cage_tb',$data,$where);
			}
				$count++;
		}
		if($result){
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
		else{
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
	}
	
	else if(isset($_POST['input_insert'])){
			$data = array(
					'name' => $_POST['input_name'],
					'size_height'=>  $_POST['input_size_height'],
					'size_width'=>  $_POST['input_size_width'],
					'size_length'=> $_POST['input_size_length'],
					'location_latitude' =>  $_POST['input_location_latitude'],
					'location_longitude' =>  $_POST['input_location_longitude'],
					'doors' =>  $_POST['input_doors'],
					'isopen' =>  $_POST['input_isopen'],
					'human_inside' =>  $_POST['input_human_inside'],
					'exhibit_inside' =>  $_POST['input_exhibit_inside']
				);
				
				
			
			$result = $_obj->insert('Cage_tb',$data);
			if($result){
				header("Location:".basename($_SERVER['HTTP_REFERER']));
			}
			else{
				header("Location:".basename($_SERVER['HTTP_REFERER']));
				}
		
	}

?>
