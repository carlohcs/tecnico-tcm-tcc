<?php
$dataAtual = date('Y-m-d'); 

$dataAnterior = idate('d',strtotime($dataAtual)); 

echo "DATA DE ATUAL: ".$dataAtual;

echo "<br />DATA DE ANTES: ".($dataAnterior - 2);

TO_DAYS(NOW()) - TO_DAYS(DT_NOT) <= 2

?>