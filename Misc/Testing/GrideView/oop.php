<?php
class webgetTable{
	public $json_string, $json_array ;
	
	public function __construct($json_file){
		$this->json_string = file_get_contents($json_file);
		$this->json_array = json_decode($this->json_string, TRUE);
		//echo "A new constructor in " . __CLASS__ . ".<br />";
	
	}
	public function printstr(){
		echo var_dump($this->json_array);
	}
	


	
}

$obj = new webgetTable("GrideView.2.json");
$obj->printstr();
?>
