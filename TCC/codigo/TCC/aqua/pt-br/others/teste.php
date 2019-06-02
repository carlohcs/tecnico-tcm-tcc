<?php
//header("Content-Type: text/html; charset=iso-8859-1");
//header("Content-Type: text/html; charset=iso-utf-8");
//print_r(iconv_get_encoding());
include("sqlInstruction.class.php");
include_once("manageEnquete.class.php");
$obj = new manageEnquete(2); $retorno = false;
$obj->listaEnquete();
?>
<html>
<head>
<meta http-equiv="content-type" content="text/html;charset=iso-8859-1" />
<p>ãoáéê</p>
</head>
</html>