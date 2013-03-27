<?php

$string = file_get_contents("GrideView.2.json");
/*$json_a = new RecursiveIteratorIterator(
    new RecursiveArrayIterator(json_decode($string, TRUE)),
    RecursiveIteratorIterator::SELF_FIRST);

foreach ($json_a as $table_attributes => $table_value) {
    echo $table_attributes . "=>" . $table_value . "\n";
}*/

//print_r($json_a['table']['row_count']);
//echo $json_a->table->row_content[0]->element;
//$e = $json_a['table']['row_content'][0]['element'];
//echo $e;*/


	$json_array = json_decode($string, TRUE);
	//$id = $json_array['table']['row_content'][2]['id'];
	//var_dump($json_array);
	echo $json_array['table']['query'][$json_array['table']['id']] ;
	//var_dump($json_array['table']['query']['age']);
	foreach ($json_array['table']['query']['age'][0] as $table_attributes => $table_value) {
    	echo $table_attributes.$table_value."\n";
	}
	

?>



