<?php
$str = "perfil/carlohcs";
$strCom = "/^perfil\/([a-z0-9.-_]{3,}+)/";

$ve = preg_match($strCom, $str);

if($ve != 0){ echo "BATEU"; } else{ "N�o BATEU";  }

var_dump($ve);

?>

