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
	
	public function add(array $data){
		
		$connection = array("localhost","root","Rushabh","zoo");
		$animal = new Mysql_DatabaseMiddleLayer($connection);
		
		$animal->insert('Cage_tb', $data);
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
				'name'=>'Blackbuck'
				,'size_height'=> 50
				,'size_width'=>75
				,'size_length'=>60
				,'location_latitude'=>1.40495
				,'location_longitude'=>103.79049
				,'doors'=>2
				,'animal_limit'=>2
		
			);
$an->add($data);

?>
