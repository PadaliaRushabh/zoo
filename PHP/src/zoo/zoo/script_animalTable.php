<?php
include_once "../../DatabaseMiddleLayer/DatabaseMiddleLayer.php"; 
/*
 * untitled.php
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
			$where  = "ID_animal = " .$del_id ;
			$result = $_obj->delete('Animal_tb' , $where);
		} 
		if($result){
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
		else{
			header("Location:".basename($_SERVER['HTTP_REFERER']));
		}
		
	}
	else if(isset($_POST['update'])){
		$count = 0;
		foreach($_POST['ID_animal'] as $update_id){
				$where = "ID_animal = " . $update_id;
				$data = array(
					'ID_cage'=>  $_POST['dd_cage'][$count],
					'ID_animalrecord'=> $_POST['dd_animalrecord'][$count]
				);
				$result = $_obj->update( 'Animal_tb',$data,$where);
			
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
					'ID_cage' => $_POST['input_dd_cage'],
					'ID_animalrecord'=> $_POST['input_dd_animalrecord'],
				);
			$result = $_obj->insert('Animal_tb',$data);
			if($result){
				header("Location:".basename($_SERVER['HTTP_REFERER']));
			}
			else{
				header("Location:".basename($_SERVER['HTTP_REFERER']));
				}
		
	}
		

?>


