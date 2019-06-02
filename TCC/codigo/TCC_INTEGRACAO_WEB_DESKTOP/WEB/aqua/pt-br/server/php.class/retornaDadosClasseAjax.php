<?php
	session_start();
	header("Content-type: text/xml; charset=ISO-8859-1");
	//Retorna notícias via ajax
	$action = isset($_POST['postAcao']) ? $_POST['postAcao'] : FALSE;
	$qtdNot = isset($_POST['qtdNot']) ? $_POST['qtdNot'] : FALSE;
	$qtdAtual = isset($_POST['vlAtual']) ? $_POST['vlAtual'] : FALSE;
	
	$palavraBusca = isset($_POST['valorBusca']) ? $_POST['valorBusca'] : FALSE;
		
	if($action)
	{
		include_once('sqlInstruction.class.php');

		switch($action)
		{
	
			case "maisNoticias":
				include_once('manageNews.class.php');
				$obj = new manageNews;
				$respo = $obj->noticiasTexto(false,$qtdNot,$qtdAtual,"");
				$strRetorno = "";
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['noticia'][$i]."|"; } 
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['linkNoticia'][$i]."|"; }
				for($i=0;$i<$qtdNot;$i++){ $strRetorno.= $respo['dataNoticia'][$i]."|";}
				echo $strRetorno;
			break;
			case "buscaPalChave":
				include_once('manageBusca.class.php');
				$obj = new manageBusca;
				$obj->buscaNotArt('todosReg',$palavraBusca);
			break;
			case "curtir":
				include_once('manageCurtir.class.php');
				$obj = new manageCurtir;
				echo $obj->curtirArtigo($_POST['codCur'],$_POST['codArt'],$_SESSION['sessaoUsuario']['codigo'],$_POST['codUsu'],$_POST['curtir']);
			break;
			case "comentario":
				include_once('manageComentario.class.php');
				$codPost = utf8_decode($_POST['codPost']);$codUsu = $_SESSION['sessaoUsuario']['codigo']; 
				$txtComment = utf8_decode($_POST['postComment']);$tpCommt = utf8_decode($_POST['tpCommt']);
				$obj = new manageComentario;
				echo $obj->comentario($codPost,$codUsu,$txtComment,$tpCommt);
			break;
			case "sinalizar":
				include_once('manageSinalizacao.class.php');
				$obj = new manageSinalizacao;
				$arrPost = array();
				foreach($_POST as $key=>$value){ $arrPost[$key] = $value; }
				$obj->sinalizarUsuario($arrPost);
			break;
			case "escreveArtigo":
				include('manageArtigo.class.php');
				$obj = new manageArtigo;
				
				$plChave = (explode(',',$_POST['plChave']));

				if (utf8_decode($_POST['plChave']) == 'Separe por vírgula ex: palavra1, palavra2, palavra3'){
					$plChave[0] = $plChave[1] = $plChave[2] = "";
				}else {
					if ((!isset($plChave[0])) || (trim($plChave[0]) == "")) $plChave[0] = "";
					if ((!isset($plChave[1])) || (trim($plChave[1]) == "")) $plChave[1] = "";
					if ((!isset($plChave[2])) || (trim($plChave[2]) == "")) $plChave[2] = "";
				}

				$respo = $obj->escreveArtigo(utf8_decode(stripslashes($_POST['titulo'])),
				utf8_decode(stripslashes($_POST['texto'])),utf8_decode(stripslashes(trim($plChave[0]))),
				utf8_decode(stripslashes(trim($plChave[1]))),
				utf8_decode(stripslashes(trim($plChave[2]))),
				$_SESSION['sessaoUsuario']['codigo'], $_POST['codCategoria']);
				if($respo == true) echo 'true'; else echo 'false';
			break;
			case "renascer":
				$obj= new sqlInstruction; $conSql = $obj->conexaoSql(); $obj->defineEntidade('usuario');
				$exSql = $obj->updateSql('FLAG_RNSC = 1,PTS_USU = 0', "COD_USU = {$_SESSION['sessaoUsuario']['codigo']}");
				$obj->encerraConexaoSql($conSql);
				if($exSql != false) echo 'true'; echo 'false';
			break;
			default:
				echo "Servidor temporariamente indisponível, tente novamente mais tarde.";
		}

	}
	else
	{
		echo "Nenhum dado enviado.";
	}
?>