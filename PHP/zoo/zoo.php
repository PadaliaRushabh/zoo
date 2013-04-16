<?php
include_once "../DatabaseMiddleLayer/DatabaseMiddleLayer.php"

public interface zoo{
	
	 public function addToZoo(array $data);
	 public function delete($where);
	 public function view($where, $order);
	 public function update(array $data, $where);
	 public function transfer($to); 
}  

public class animal implements zoo{
	
	public function add(array $data){
		
		
	}
		
}

?>
