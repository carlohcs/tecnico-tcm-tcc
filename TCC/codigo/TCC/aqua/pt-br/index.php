<?php
//HEADER
include("include/header.php");
$getPage = isset($_GET['page']) ? $_GET['page'] : FALSE;
$getUser = isset($_GET['user']) ? $_GET['user'] : FALSE;
$getNot = isset($_GET['noticia']) ? $_GET['noticia'] : FALSE;
$getJogo = isset($_GET['jogoEsc']) ? $_GET['jogoEsc'] : FALSE;
$verificaSess = $obj->verificaSessaoUsuario();
switch($getPage)
{
	//INDEX
	case 'index':
		include("include/center.php");
		echo "<script>document.title = 'JOI&D - Index';</script>";
	break;
	//NOTÍCIAS
	case 'noticias':
		$conSql = $obj->conexaoSql();$obj->defineEntidade('noticias'); $strUrl = ""; 
		$newUrl = explode("-",$getNot); for($i=0;$i<count($newUrl);$i++){ if($i == count($newUrl) -1) $strUrl.=$newUrl[$i]; else $strUrl.=$newUrl[$i]." ";}
		$objRespo = $obj->selectSql("*", "TIT_NOT = '".$strUrl."'", '', '',true);
		if($objRespo == false) include("noticiaInexistente.php");else include("noticias.php");
		$obj->encerraConexaoSql($conSql);
		echo "<script>document.title = 'Notícias - JOI&D';</script>";
	break;
	//JOGOS
	case 'jogos':
		$conSql = $obj->conexaoSql();$obj->defineEntidade('jogos'); $strUrl = "";
		$newUrl = explode("-",$getJogo); for($i=0;$i<count($newUrl);$i++){ if($i == count($newUrl) -1) $strUrl.=$newUrl[$i]; else $strUrl.=$newUrl[$i]." ";}
		$objRespo = $obj->selectSql("*", "DESC_JOGO = '".$strUrl."'", '', '',true);
		if($objRespo == false) include("jogoInexistente.php");else include("jogos.php");
		$obj->encerraConexaoSql($conSql);
		echo "<script>document.title = 'Jogos - JOI&D';</script>";
	break;
	//PERFIL
	case 'perfil':
		if($verificaSess == false){
		echo "<script>jAlert('<p>Você precisa estar logado para visualizar perfis!</p>Faça login ou cadastra-se.', ' ', function(){
		$.alerts.dialogClass = null;});</script>";include("include/center.php");}
		else{$conSql = $obj->conexaoSql();$obj->defineEntidade('usuario');
		$objRespo = $obj->selectSql("*", "LOG_USU = '".$getUser."'", '', '',true); $flaN = false;
		if($objRespo == false) include("perfilInexistente.php");else include("perfil.php"); $flaN = true;}	
		if($flaN == true){ echo "<script>document.title = '".$getUser." - Perfil - JOI&D ';</script>";}else{echo "<script>document.title = 'Perfil - JOI&D ';</script>";}
	break;
	//ESCREVER ARTIGO
	case 'escreverArtigo':
		if($verificaSess == false){
			echo "<script>jAlert('<p>Você precisa estar logado para escrever artigos!</p>Faça login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";
		}
		else include("escreverArtigo.php");
	break;	
		//FAQ
	case 'faq':
		include("faq.php");
		echo "<script>document.title = 'Faq - JOI&D';</script>";
	break;
	//CONTATO
	case 'contato':
		include("contato.php");
		echo "<script>document.title = 'Contato - JOI&D';</script>";
	break;
	//SOBRE
	case 'sobre':
		include("sobre.php");
		echo "<script>document.title = 'Sobre - JOI&D';</script>";
	break;
	//ERRO
	default:
		include('404.php');
}

//MENU LEFT
include("include/menuLeft.php");
//MENU RIGHT
include("include/menuRight.php");
//FOOTER
include("include/footer.php"); 
?>