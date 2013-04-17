<?php
include_once "../DatabaseMiddleLayer/DatabaseMiddleLayer.php"

public interface tView{
	
	 public function view($where, $order);
}  

public interface tEdit{
	
	public function update(array $data, $where);
	public function add(array $data);
	public function delete($where);
	
	
}

public interface tMove{
	
	public function transfer($to);	
}

/*public class concreteFactory implements tView, tEdit,tMove{
	
	
} */

public class animal implements tView, tEdit, tMove{
	
	public function add(array $data){
		
		
	}
		
}

public class cage implements tview, tEdit{
	
}

?>
