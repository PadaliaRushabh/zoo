<?php
include_once "../DatabaseMiddleLayer/DatabaseMiddleLayer.php";

interface tView{
	
	 public function view($table , $fields , $where, $order);
}  

interface tEdit{
	
	public function update($table, array $data, $where);
	public function add(array $data);
	public function delete($table,$where);
	
	
}
interface tMove{
	
	public function transfer($AnimalID , $to);	
	public function getAnimalcage(array $AnimalID);
}

/*public class concreteFactory implements tView, tEdit,tMove{
	
	
} */

class animal implements tView, tEdit, tMove{
	
	protected $_object;
	
	public function __construct(){
		
		$connection = array("localhost","root","Rushabh","zoo");
		$this->_object = new Mysql_DatabaseMiddleLayer($connection);
	}
	
	public function add(array $data){
		
		$this->_object->insert('Cage_tb', $data);
	}
	
	public function view($table ,$fields="*",$where=null, $order=null){
			
			$this->_object->select($table , $fields , $where , $order);
			//TODO:Generate Table
	
	}
	public function update($table , array $data, $where = null){
			$this->_object->update($table,$data, $where)
	}
	public function delete($table,$where){
			$this->_object->delete($table , $where);
	}
	public function transfer(array $Animal_Cage_ID , $to){
		
		if(isCageNotFull(count($Animal_Cage_ID) , $to)){
			$data = array();
			for($i = 0 ; $i<count($Animal_Cage_ID) ; $i++){
				$data[] = array($Animal_Cage_ID[$i] => $to]);
			}
			 
			$this->_object->update('Animal_tb',$data ,);
		}
		else{
			return false;
		}
		return true;
		
	}
	
	public function isCageNotFull($AnimalsToInsert , $to){
		$where = 'ID_Cage=' . $to;
		$return = $this->_object->select('Animal_tb' , 'count(ID_cage)' , $where);
		$row = mysqli_fetch_array($return);
		$AnimalsToInsert = $row[0] + $AnimalsToInsert;
		
		($AnimalsToInsert > $row[0]) ? false : true;
			
		
	}
	/*public function getAnimalcage(array $AnimalID){
		$this->_object->select('Animal_tb', $fields="*");
		while($row = mysqli_fetch_array($return)){
			
			echo $row['ID_animal'] . " " . $row['ID_cage'];

		}
	}*/
	
	
		
}

class cage implements tview, tEdit{
	
	public function view($where, $order){}
	public function update(array $data, $where){}
	public function delete($where){}
	public function add(array $data){}
}

$an = new animal();
$data = array(
				'name'=>'For African porcupine'
				,'size_height'=> 20
				,'size_width'=>75
				,'size_length'=>60
				,'location_latitude'=>2.40495
				,'location_longitude'=>104.79049
				,'doors'=>2
				,'animal_limit'=>2
		
			);
$an->add($data);

?>
