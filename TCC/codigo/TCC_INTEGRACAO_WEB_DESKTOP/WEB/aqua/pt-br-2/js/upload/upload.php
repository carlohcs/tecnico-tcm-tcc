<?php
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/sqlInstruction.class.php");

$extensao = explode("/",$_FILES['uploadfile']['type']);
$nomeFt = "u_".date('dmy')."_".time().".".$extensao[1];

$final = "../../img/usuarios/".$nomeFt;

if($_FILES['uploadfile']['size'] > 2 * 1024 * 1024){ echo "error";}
else{
	if (move_uploaded_file($_FILES['uploadfile']['tmp_name'],$final)) { 
		session_start();
		$_SESSION['sessaoUsuario']['foto'] = 'img/usuarios/'.$nomeFt;
		$sql = new sqlInstruction;$sql->defineEntidade('usuario'); $conSql = $sql->conexaoSql();
		$sql->updateSql("FT_USU = 'img/usuarios/".$nomeFt."'","COD_USU = '".$_SESSION['sessaoUsuario']['codigo']."'");
		$sql->encerraConexaoSql($conSql);
		echo "success;img/usuarios/".$nomeFt.""; 
	}else echo "error";
}
?>