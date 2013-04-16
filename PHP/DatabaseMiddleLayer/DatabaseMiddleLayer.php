<?php
class MysqlAdapterException extends Exception{}

interface DatabaseMiddleLayer_t {
		
	function connect();
   
    function disconnect(); 
   
    function query($query); // Execute Query
   
    function select($table, $fields, $where, $order); // Select query
   
    function insert($table, array $data);
   
    function update($table, array $data, $where);
   
   	function delete($table, $where);
   
    function getInsertId();
   
    function countRows(); // return how many rows are fetched
   
    function getAffectedRows();
    
    function fetch(); // fetch row by row
    
    function createTable($table , array $col , $pk , array $fk);
    	
	}


class Mysql_DatabaseMiddleLayer implements DatabaseMiddleLayer_t {
		protected $_link;
		protected $_result;
		protected $_config = array();
		
		public function __construct(array $config){

			if(count($config)!=4){
				 throw new MySQLAdapterException('Invalid number of connection parameters.');  
			}
			$this->_config = $config;
		}
				
		public function connect(){
			
			if($this->_link!==null){
				return $this->_link;
			}
			
			list($host, $user, $password, $database) = $this->_config;
			if(($this->_link=@mysqli_connect($host,$user,$password,$database))){
				unset($host,$user,$password,$database);
				return $this->_link;
			}
			throw new MySQLAdapterException('Error connecting to the server : '.mysqli_connect_error());
		}
		
		public function query($query){
			
			if(!is_string($query)||empty($query)){
				 throw new MySQLAdapterException('The specified query is not valid.');  

			}
			$this->connect();
			if ($this->_result = mysqli_query($this->_link, $query)) {
				return $this->_result;
			}
			throw new MySQLAdapterException('Error executing the specified query ' . $query . mysqli_error($this->_link));
		}
		
		function createTable($table , array $col , $pk  , array $fk = null){
			
				//get cols 
				if($this->is_assoc($col)){
					$value = array();
					foreach($col as $col => $Dtype){
						$value[] = $col .' '. $Dtype;
					}
					$value = implode(',' , $value);
				}
				else{
					throw new Exception('Invalid Data: Array not associative');
				}
					 
				//get fk
				if ($fk!=null){
					if($this->is_assoc($fk)){
						$fk_v = array();
						foreach($fk as $col => $fk_t){
							$fk_v[] = ' FOREIGN KEY ' . '(' . $col . ') ' . 'REFERENCES ' . $fk_t;
						}
						$fk_v = implode(',' , $fk_v);
					}
					else{
						throw new Exception('Invalid Data: Array not associative');
					}
				}
				$sql = 'CREATE TABLE ' . $table . '( '
						.($value)
						.' ,PRIMARY KEY (' . $pk .') '
						.(isset($fk_v) ? ' ,' . $fk_v : null)
						.') ENGINE=InnoDB' ; 
						
				$this->query($sql);
				return $this->getAffectedRows();
				
			
		}
		
		public function delete($table, $where = null){
			
			$sql = 'DELETE FROM ' . $table
					. ($where ? ' WHERE ' . $where . " " : null);
			$this->query($sql);
			return $this->getAffectedRows();
		}
		
		public function update($table, array $data, $where = null){
			if($this->is_assoc($data)){
				$set = array();	
				foreach($data as $col => $value){
					$set[] = $col . ' = ' . $this->quoteValue($value);
				}
				$set = implode(',' , $set);
				$sql = 'UPDATE ' . $table 
						. ' SET '. $set
						. ($where ? ' WHERE ' . $where . " " : null);
				$this->query($sql);
				return $this->getAffectedRows();	
				
			}
			throw new Exception('Invalid Data: Array not associative');
		}
		
		public function getAffectedRows()
		{
			if ($this->_result !== null) {
				mysqli_affected_rows($this->_link);
				return true;
			}
			return false;
		}	
			
		public function select($table, $fields="*", $where=null,  $order=null){
			$sql = 'SELECT ' . (strcmp($fields , "*") || strcasecmp($fields , 'ALL') ? '* ' :$fields . " ") 
					. 'FROM '. $table . " "
					. ($where ? 'WHERE ' . $where . " " : null)
					. ($order ? 'ORDER BY ' . $order. " " : null);
			$this->query($sql);
			return $this->countRows();
		}
		
		public function insert($table, array $data){
			if($this->is_assoc($data)){
				$fields = implode(',' , array_keys($data));
				$values = implode(',' , array_map(array($this, 'quoteValue'), array_values($data)));
				
				$sql = 'INSERT INTO '. $table . " " 
						. '('. $fields .')' . 'VALUES (' . $values . ')';
				$this->query($sql);
				return $this->getInsertId();
			}
			throw new Exception('Invalid Data: Array not associative');
		}
		
		public function quoteValue($value) // put quote on string 
		{
			$this->connect();
			if ($value === null) {
				$value = 'NULL';
			}
			else if (!is_numeric($value)) {
				$value = "'" . mysqli_real_escape_string($this->_link, $value) . "'";
			}
			return $value;
		}

		function is_assoc($array) {
			return (bool)count(array_filter(array_keys($array), 'is_string'));
		}
		
		function getInsertID(){ // check if insert is succefull 
			if($this->_link !== null){
				return mysqli_insert_id($this->_link);
			}
			return false;
		}
		
		public function countRows(){
			if($this->_result !== null){
				return mysqli_num_rows($this->_result) ;
			}
		
			return null;
			
		}
		public function fetch()
		{
			if ($this->_result !== null) {
				if (($row = mysqli_fetch_array($this->_result))!== false) {
					return $row;
				}
				$this->freeResult();
				return false;
			}
			return null;
		}
			
		public function freeResult()
		{
			if ($this->_result !== null) {
				mysqli_free_result($this->_result);
				return true;
			}
			return false;
		}
		
		public function disconnect()
		{
			if ($this->_link !== null) {
				mysqli_close($this->_link);
				$this->_link = null;
				return true;
			}
			return false;
		}
		
		public function __destruct()
		{
			$this->disconnect();
		}
	}
	/*$array = array("localhost","root","Rushabh","zoo1");
	$obj = new Mysql_DatabaseMiddleLayer($array);
	$data = array(	
				'cage_name' => 'forcat'
				, 'cage_type' => 'gold'
				, 'cage_location' => 'new and old location'
				, 'cage_width' => 12
				, 'cage_height' => 30
				, 'cage_doors' => 40
	
			);
	$CR = $obj->update('test_mysql' , $data , 'id = 3');
	//echo $CR;
	
	//$result = 	$obj->query("SELECT * FROM test_mysql");
	$data = array('Customer_SID' => 'Customer(ID)' ,'Order_Date' => 'test_TB8(Order_Date)' );
	$data2 = array('Order_ID' =>'varchar(30)', 'Order_Date'=>'date','Customer_SID'=>'integer');
	
	$obj->createTable('test_TB275' , $data2 ,'Order_ID');*/
	

?>
