<?php
	session_start();
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/include/modules/index.module.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/sqlInstruction.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageSession.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manipulationData.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageNews.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/managePublicity.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageJogos.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageEnquete.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageComentario.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageRanking.class.php");
	
	$objModule = new module;
	$objSql = new sqlInstruction;
	$objSession = new manageSession;
	$objNews = new manageNews;
	$objData = new manipulationData; 
	$objPublic = new managePublicity;
	$objJogos = new manageJogos;
	$objComt = new manageComentario;
	$conSql = $objSql->conexaoSql(); $objSql->defineEntidade('enquete');
	$exSql = $objSql->selectSql('COD_ENQ','','COD_ENQ DESC','1',false);
	$objSql->encerraConexaoSql($conSql); $re = $objSql->fetch($exSql);
	$objEnq = new manageEnquete($re['COD_ENQ']);
	$objRanking = new manageRanking();
	$getPage = isset($_GET['page']) ? $_GET['page'] : FALSE;
	$getUser = isset($_GET['user']) ? $_GET['user'] : FALSE;
	$getNot = isset($_GET['noticia']) ? $_GET['noticia'] : FALSE;
	$getJogo = isset($_GET['jogoEsc']) ? $_GET['jogoEsc'] : FALSE;
	$getDestaque = isset($_GET['destaque']) ? $_GET['destaque'] : FALSE;
	$getArt = isset($_GET['artEsc']) ? $_GET['artEsc'] : FALSE;
	$getEditPerf = isset($_GET['editarPerfil']) ? $_GET['editarPerfil'] : FALSE;
	$getActJ = isset($_GET['actJo']) ? $_GET['actJo'] : FALSE;
	
	$verificaSess = $objSession->verificaSessaoUsuario();	
?>