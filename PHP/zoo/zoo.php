<?php
include_once "../DatabaseMiddleLayer/DatabaseMiddleLayer.php";

interface tView{
	
	 public function view($where, $order);
}  

interface tEdit{
	
	public function update(array $data, $where);
	public function add(array $data);
	public function delete($where);
	
	
}
interface tMove{
	
	public function transfer($to);	
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
	
	public function view($where, $order){}
	public function update(array $data, $where){}
	public function delete($where){}
	public function transfer($to){}
	
	
		
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
