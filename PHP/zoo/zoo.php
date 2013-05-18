<?php
include_once "../DatabaseMiddleLayer/DatabaseMiddleLayer.php";

interface tView{
	
	 public function view($fields , $where, $order);
}  

interface tEdit{
	
	public function update(array $data, $where);
	public function add(array $data);
	public function delete($where);
	
	
}
interface tMove{
	
	public function transfer(array $AnimalID);	
}

abstract class animal_A implements tView, tEdit, tMove{
	
	protected $_objname;
	protected $_object;
	protected $_table;
	
	public function __construct($tb_name){
		$error = false;
		if($tb_name === 'Animal'){ $this->_table = 'Animal_tb';}
		else if($tb_name === 'AnimalRecord') {$this->_table = 'AnimalRecords_tb';}
		else {$error = true;}
		
		if(!$error){
			$connection = array("localhost","root","Rushabh","zoo");
			$this->_object = new Mysql_DatabaseMiddleLayer($connection);
		}
		else{
			throw new Exception('Invalid Table');
		}

	}
	
	public function add(array $data){	
		return $this->_object->insert($this->_table, $data);
	}
	
	public function view($fields="*",$where=null, $order=null){
			
			return $this->_object->select($this->_table , $fields , $where , $order);
			//TODO:Generate Table
	
	}

	public function update(array $data, $where = null){
			return $this->_object->update($this->_table,$data, $where);
	}
	public function delete($where){
			return $this->_object->delete($this->_table , $where);
	}
	public function transfer(array $Animal_Cage_ID){
			$ret = array();
			if($this->_table ==='Animal_tb' ){
				foreach($Animal_Cage_ID as $Animal_ID => $Cage_ID){
					$set = array("ID_cage" => $Cage_ID);
					$where = 'ID_animal = '. $Animal_ID;  
			 		array_push($ret , $this->_object->update('Animal_tb',$set , $where));
				}
			}
			else {return null;}
			
			return $ret;
		
	}		
		
}

class Animal extends animal_A {
	public function __construct(){
		parent::__construct('Animal');
	}
}

class AnimalRecord extends animal_A{
	public function __construct(){
		parent::__construct('AnimalRecord');
	}
}

class Cage implements tview, tEdit{
	
	protected $_object;

	public function __construct(){
		$connection = array("localhost","root","Rushabh","zoo");
		$this->_object = new Mysql_DatabaseMiddleLayer($connection);
	}

	public function view($fields="*" , $where=null, $order=null){
		return $this->_object->select('Cage_tb' , $fields , $where , $order);

	}
	public function update(array $data, $where = null){
		return $this->_object->update('Cage_tb',$data, $where);
	}
	public function delete($where){
		return $this->_object->delete('Cage_tb', $where);
	}
	public function add(array $data){
		return $this->_object->insert('Cage_tb', $data);
	}
}

#$an = new Animal();
#$data = array(
#				3=>6
				
		
		
#	);
#$result = $an->transfer($data);
#echo $result;


?>

