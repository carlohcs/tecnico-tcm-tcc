<?php
include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/sqlInstruction.class.php");
include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageSession.class.php");
$obj = new manageSession;
header("Location: ".$obj->encerraSessaoUsuario());
?>