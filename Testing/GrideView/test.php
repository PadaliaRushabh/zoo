<?php

$string = file_get_contents("GrideView.2.json");
$json_a = new RecursiveIteratorIterator(
    new RecursiveArrayIterator(json_decode($string, TRUE)),
    RecursiveIteratorIterator::SELF_FIRST);

foreach ($json_a as $table_attributes => $table_value) {
    echo $table_attributes . "=>" . $table_value . "\n";
}

//print_r($json_a['table']['row_count']);
//echo $json_a->table->row_content[0]->element;
//$e = $json_a['table']['row_content'][0]['element'];
//echo $e;*/


	//$json_a = json_decode($string, TRUE);
	//echo sizeof($json_a['table']);

?>



