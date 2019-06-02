<?php
	header("Content-type: text/xml; charset='ISO-8859-1'");
	
	//Retorna notícias via ajax
	$action = isset($_POST['postAcao']) ? $_POST['postAcao'] : FALSE;
	$qtdNot = isset($_POST['qtdNot']) ? $_POST['qtdNot'] : FALSE;
	$qtdAtual = isset($_POST['vlAtual']) ? $_POST['vlAtual'] : FALSE;
	
	$palavraBusca = isset($_POST['valorBusca']) ? $_POST['valorBusca'] : FALSE;
	
	if($action)
	{
		include_once('sqlInstruction.class.php');
		include_once('manageNews.class.php');
		include_once('manageBusca.class.php');

		switch($action)
		{
	
			case "maisNoticias":
				$obj = new manageNews;
				$respo = $obj->noticiasTexto(false,$qtdNot,$qtdAtual,"");
				$strRetorno = "";
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['noticia'][$i]."|"; } 
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['linkNoticia'][$i]."|"; }
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['dataNoticia'][$i]."|";}
				echo $strRetorno;
			break;
			case "buscaPalChave":
				$obj =new manageBusca;
				$obj->buscaNotArt('todosReg',$palavraBusca);
			break;
			default:
				echo "O servidor está indiponível, tente novamente mais tarde.";
		}

	}
	else
	{
		echo "Não está sendo mandado nada!";
	}
?>