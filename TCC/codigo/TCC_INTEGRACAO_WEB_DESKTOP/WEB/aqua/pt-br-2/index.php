<?php
//HEADER
include("include/body/header.php");

switch($getPage)
{
	//INDEX
	case 'index':
		include("include/body/center.php");
		echo "<script>document.title = 'JOI&D - Jogos, Informações & Download';</script>";
	break;
	//NOTÍCIAS
	case 'noticias':
		$conSql = $objSql->conexaoSql();$objSql->defineEntidade('noticias');
		$objRespo = $objSql->selectSql('*', "LINK_NOT = '".$getNot."'", '', '1',true);
		$objSql->encerraConexaoSql($conSql);
		if($objRespo == false) include("include/errors/404.php");else include("noticias.php");
	break;
	//CATEGORIAS
	case 'categoria':
		include('categorias.php');
		echo "<script>document.title = 'Categorias de Jogos - JOI&D';</script>";
	break;
	//JOGOS
	case 'jogos':
		$conSql = $objSql->conexaoSql();$objSql->defineEntidade('itens_ctg');
		$url = ucwords($objSql->formataUrlSemTraco($getJogo));
		$objRespo = $objSql->selectSql("TIT_ITN_CTG", "TIT_ITN_CTG = '".$url."'", '', '',true);
		if($objRespo == false) include("include/errors/404.php");else include("jogos.php");
		$objSql->encerraConexaoSql($conSql);
		echo "<script>document.title = '".$url." - Jogos - JOI&D';</script>";
	break;
	//PERFIL
	case 'perfil':
		if($verificaSess == false){
		echo "<script>jAlert('<p>Você precisa estar logado para visualizar perfis!</p>Faça login ou cadastra-se.', ' ', function(){
		$.alerts.dialogClass = null;});</script>";include("include/body/center.php");$flaN = false;}
		else{$conSql = $objSql->conexaoSql();$objSql->defineEntidade('usuario');
		$objRespo = $objSql->selectSql("*", "LOG_USU = '".$getUser."'", '', '',true); $flaN = false;
		if($objRespo == false) include("include/errors/404.php");else include("perfil.php"); $flaN = true;}	
		if($flaN == true){ echo "<script>document.title = '".$getUser." - Perfil - JOI&D ';</script>";}else{echo "<script>document.title = 'Perfil - JOI&D ';</script>";}
	break;
	//REGISTRO
	case 'registrar':
		include('registrar.php');
		echo "<script>document.title = 'Registrar - JOI&D';</script>";
	break;
	//TODOS OS ARTIGOS
	case 'todos-artigos':
		include("todosArtigos.php");
	break;
	//VISUALIZAR ARTIGOS USUÁRIOS
	case 'artigos':
		if($verificaSess == false){
			echo "<script>jAlert('<p>Você precisa estar logado para visualizar artigos!</p>Faça login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";
			include('include/body/center.php');
		}else{		
			$conSql = $objSql->conexaoSql();
			if($getArt){
				$objSql->defineEntidade('artigo');
				if($objSql->selectSql('COD_ART,TIT_ART',"LINK_ART = '{$getArt}'",'','',true) != false) include("include/include_sec/artigoescrito.php");
				else{ $objSql->encerraConexaoSql($conSql); include('include/errors/404.php'); }
			}else include("artigos.php");
			
		}	
	//VISUALIZAR E EDITAR ARTIGOS USUÁRIO SESSÃO	
	break;	
	case 'meusartigos':
		if($verificaSess == true){ include("include/include_sec/meusartigos.php"); echo "<script>document.title = 'Meus Artigos - JOI&D'; </script>";}
		else {echo "<script>jAlert('<p>Você precisa estar logado para escrever artigos!</p>Faça login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";
		include("include/body/center.php");}
	break;
	//DESTAQUES
	case 'destaques':
		$conSql = $objSql->conexaoSql();$objSql->defineEntidade('destaque');
		$objRespo = $objSql->selectSql('COD_DEST,TXT_DEST,DT_DEST,HR_DEST,TIT_DEST', "LINK_DEST = '{$getDestaque}'", '', '1',true);
		if($objRespo == false) include("include/errors/404.php");else include("destaques.php");;
	break;
	//VISUALIZAR TODOS OS DESTAQUES
	case 'todosdestaques':
		$conSql = $objSql->conexaoSql();$objSql->defineEntidade('destaque');
		include("todosDestaques.php");
		echo "<script>document.title = 'Todos Destaques - JOI&D';</script>";
	break;
	case 'rankingusuarios':
		include("ranking.php");
		echo "<script>document.title = 'Ranking de Usuários - JOI&D';</script>";
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
	//Termos de uso
	case "termosdeuso":
		include("include/documents/termosDeUso.php");
	break;	
	case '404':
		include("include/errors/404.php");
		echo "<script>document.title = 'Página não encontrada - JOI&D';</script>";
	break;
	//ERRO
	default:
		include('include/errors/404.php');
		echo "<script>document.title = 'Página não encontrada - JOI&D';</script>";
}

//MENU LEFT
include("include/body/menuLeft.php");
//MENU RIGHT
include("include/body/menuRight.php");
//FOOTER
include("include/body/footer.php"); 
?>