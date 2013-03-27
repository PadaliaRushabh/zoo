<?php
include('../../log/MyLogPHP-1.2.1.class.php');

class webgetTable{
	public $row_count, $cols_count;
	public $json_array,$query_array = array();
	public $log;
	
	public function __construct($json_file,$log = null){
		try{
			$this->log = $log;
			$this->log->info('IN constructor');
			
			$json_string = file_get_contents($json_file);
			$this->json_array = json_decode($json_string, TRUE);
			
			$this->log->info('END constructor');
		}
		catch(Exception $e){
			$this->log->error($e->getMessage());
		}
	}

	
	public function GenerateTable(){ // main function reading table structure
		try{
			$this->log->info('IN GenerateTable()');
			
			$this->GetRowCols();
			
			
			$this->log->info('END GenerateTable()');
		}
		catch(Exception $e){

			$this->log->error($e->getMessage());
		}
	}
	
	private function GetRowCols(){ // function to get count of rows and cols
		try{
			$this->log->info('IN GetRowCols()');
			$id = $this->json_array['table']['id'];
			if(!$this->FindDataSetByID($id , $this->json_array['table']['query'])){
				$this->row_count = $this->json_array['table']['row_count'];// else it is an integer
				echo $this->row_count;
			}
			
			/*if(array_key_exists($id,$this->json_array['table']['query'])){// check if row_count is dynamic  
				$this->query_array[$id] = ExecuteQuery();
				$this->row_count = $this->query_array[$id]['row_count'];
			}																
			else{
				
				$this->row_count = $this->json_array['table']['row_count'];// else it is an integer
			}*/
			$this->cols_count = count($this->json_array['table']['cols_name']);
			
			$this->log->info('END GetRowCols()');
		}
		catch(Exception $e){
			$this->log->error($e->getMessage());
		}
		
			
	}
	private function FindDataSetByID($id , $json_array){// function to map dynamic variable in query
		try{
			$this->log->info('IN FindDataSetByID()');
			$con = mysql_connect("localhost", "root" , "Rushabh");
			if(!$con){
				die('could not Connect: ' .mysql_error());
			}
			if(array_key_exists($id,$json_array)){// check if id is dynamic  
				for ($i = 0 ; $i<count($json_array[$id]) ; $i++){
					foreach ($json_array[$id][$i] as $table_attributes => $table_value) {
						//echo $table_attributes.$table_value."\n";
						$this->query_array[$id][$table_attributes] = $this->ExecuteQuery_mysql($con,$table_value);
						print_r($this->query_array[$id][$table_attributes]); 
						echo count($this->query_array[$id][$table_attributes]);
					}	
				}	
			}
			else{
				return false;
			}
			
			return true;
			
			$this->log->info('END FindDataSetByID()');
		}
		catch(Exception $e){
			$this->log->error($e->getMessage());
		}
	}
	private function ExecuteQuery_mysql($con , $table_value){
		try{
			$this->log->info('IN ExecuteQuery_mysql()');
			mysql_select_db('json_test', $con);
			$result = mysql_query($table_value);
			return mysql_fetch_array($result);
			
			$this->log->info('END ExecuteQuery_mysql()');
			
		}
		catch(Exception $e){
			$this->log->error($e->getMessage());
		}
		
	}
	
}
$log = new MyLogPHP();
$obj = new webgetTable("GrideView.3.json",$log);
$obj->GenerateTable();
?>
