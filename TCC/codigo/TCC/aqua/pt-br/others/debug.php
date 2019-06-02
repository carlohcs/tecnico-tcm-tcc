<?php
session_start();
include("sqlInstruction.class.php");
include("manageSession.class.php");
include("manipulationData.class.php");
$obb = new manipulationData;
//$ob = new manageSession;
if(isset($_GET['deucerto']) && $_GET['deucerto'] == 'ok'){


}
$ra = $obb->retornaDadosSessaoUsuario('perfil');

echo $obb->exibeArrayDados('nome','usuario');

echo $obb->exibeArrayDados('email','usuario');
var_dump($obb->dadosPerso);


if(isset($_POST['envi'])){

$obb->logaUsuario('carloshcsss','111111111');
}
if(isset($_POST['sair'])){

$obb->encerraSessaoUsuario();
}
if(isset($_SESSION)){
ECHO "SESSAÃO: " .var_dump($_SESSION);
}
?>
<html>
<body>
<form name="frm" method="post">
<input type="submit" name="envi" value="OK" /><input type="submit" name="sair" value="sa" />
</form>
</body>
</html>