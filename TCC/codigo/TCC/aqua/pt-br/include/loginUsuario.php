<?php
	$login = isset($_POST['login']) && $_POST['login'] != "" ? addslashes(trim($_POST['login'])) : FALSE;
	$senha = isset($_POST['senha']) && $_POST['senha'] != "" ? trim(md5($_POST['senha'])) : FALSE;
	if($login != FALSE && $senha != FALSE)
	{
		include_once("../server/php.class/sqlInstruction.class.php");
		include_once("../server/php.class/manageSession.class.php");
		$obj = new manageSession;
		$retorno = $obj->logaUsuario($login,$senha);
	}
	else
		header("Location: ../index?lgError=login&user=".$usuario."");
?>