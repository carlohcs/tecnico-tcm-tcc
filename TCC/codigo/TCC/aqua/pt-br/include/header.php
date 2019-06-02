<?php
session_start();
include_once("server/php.class/sqlInstruction.class.php");
include_once("server/php.class/manageSession.class.php");
include_once("server/php.class/manipulationData.class.php"); 
$obj = new manipulationData; 
include_once("server/php.class/manageNews.class.php");
$objNews = new manageNews;
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="pt-br">

	<head >
		
		<base href="http://127.0.0.1:8080/TCC/aqua/pt-br/" />
		
		<title>JOI&amp;D - Index</title>
		
		<!-- Anexos -->
				
		<link rel="stylesheet" type="text/css" href="css/body.css" media="all"/>
		<?php
		if(isset($_GET["page"]) && $_GET["page"] == "perfil"){
			echo "<link rel='stylesheet' type='text/css' href='css/perfil.css' media='all' id='perUser' />";
		}else echo "<link rel='stylesheet' type='text/css' href='css/center.css' media='all' />";		
		?>
		<link rel="stylesheet" type="text/css" href="css/colorbox.css" media="all"/>
		
		<script type="text/javascript" src="js/jquery.js"></script>
		<script type="text/javascript" src="js/colorbox/jquery.colorbox.js"></script>
		<script type="text/javascript" src="js/jquery.cycle.all.min.js"></script>
		<script type="text/javascript" src="js/jquery.alerts.js"></script>
		<script type="text/javascript" src="js/efeitos.js"></script>
		<script type="text/javascript" src="js/login.js"></script>
		<script type="text/javascript" src="js/bannerPublicidade.js"></script>
		<script type="text/javascript" src="js/jquery.smoothscroll.js"></script>
		<script type="text/javascript" src="js/ajax.js"></script>
		<script type="text/javascript" src="js/jquery.validate.js"></script>
		<script type="text/javascript" src="js/validaForm.js";?>"></script>
		<script type="text/javascript" src="js/jquery.limit.js"></script>
		<script type="text/javascript" src="https://apis.google.com/js/plusone.js">{lang: 'pt-BR'}</script>
		<script type="text/javascript" src="//platform.twitter.com/widgets.js"></script></div>
		<script>(function(d, s, id) {var js, fjs = d.getElementsByTagName(s)[0];if (d.getElementById(id)) {return;}js = d.createElement(s); js.id = id;
		js.src = "//connect.facebook.net/en_US/all.js#xfbml=1"; fjs.parentNode.insertBefore(js, fjs);}(document, 'script', 'facebook-jssdk'));</script>
		
		
		<!-- Meta Tags -->
		<meta http-equiv="content-type" content="text/html;charset=iso-8859-1" />
		<meta http-equiv="Content-Style-Type" content="text/css"/> 
		<meta name="author" content="Equipe JOI&amp;D" />
		<meta name="description" content="Jogos, Informa��es e Downloads" />
		<meta name="keywords" content="jogo, jogos, game, games, mmo, fps, rpg" />
		<meta name="robots" content="all" />
		<meta http-equiv="content-type" content="pt-br" />
		<meta name="reply-to" content="joid@hotmail.com" />

		<!--[if IE]>
		<script type="text/javascript" src="js/iepngfix/iepngfix_tilebg.js"></script>
		<style type="text/css">
			
			img, div, a { behavior: url(js/iepngfix/iepngfix.htc) }
			#backTop{top: 685px; left:1125px;}
			
		</style>
		
		<![endif]-->
		<!---->
		
		
	</head>

<body>
	
		<?php
				if(isset($_GET['lgError'])){ $pss = base64_decode($_GET['user']);$tpErro =  $_GET['lgError'];
				switch($tpErro)
				{
					 case "login": 
						echo '<script>window.onload = function(){jAlert("Login Inv�lido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
					 break;
					 case "pass": 
						echo '<script>window.onload = function(){jAlert("Senha Inv�lida!", " ", function(){$.alerts.dialogClass = null;$("#c_login").val("'.$pss.'");$("#c_senha").focus(); })};</script>';
					 break;
					 case "logt":
						echo '<script>window.onload = function(){jAlert("Login Inv�lido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
					break;
				}
				}
					if(isset($_GET['escreverArtigoNegado']))	echo "<script>jAlert('<p>Voc� precisa estar logado para escrever artigos!</p>Fa�a login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";?>
	
	<div id="wrapper">
		
		<!-- xxxx Header xxxx -->
		<div id="header">

			<!-- Banner -->
			<div id="banner_top">
				<object type="application/x-shockwave-flash" width="475" height="173"  data="media/banner/banner.swf" >
				<param name="movie" value="media/banner/banner.swf" />	
				<param name="wmode" value="transparent" />
				</object>
			</div>

			<!-- Manchete -->
			<div id="bg_news01">
				<a href="javascript:;" id="btn_top"></a>
				<a href="javascript:;" id="btn_down"></a>
			</div>
			<div id="bg_news02"></div>
			<div id="t_news03"></div>
			<div id="bg_news03">
			<?php $retornoDados = $objNews->noticiasTexto(true,5,0,""); ?>
				<ul id="resume_news">
					<li><a href="noticias/<?php echo $retornoDados['linkNoticia'][0];?>"><?php echo $retornoDados['noticia'][0]."...";?></a></li>
					<li><a href="noticias/<?php echo $retornoDados['linkNoticia'][1];?>"><?php echo $retornoDados['noticia'][1]."...";?></a></li>
					<li><a href="noticias/<?php echo $retornoDados['linkNoticia'][2];?>"><?php echo $retornoDados['noticia'][2]."...";?></a></li>
					<li><a href="noticias/<?php echo $retornoDados['linkNoticia'][3];?>"><?php echo $retornoDados['noticia'][3]."...";?></a></li>
					<li><a href="noticias/<?php echo $retornoDados['linkNoticia'][4];?>"><?php echo $retornoDados['noticia'][4]."...";?></a></li>
				</ul>	
			</div>
			
			<!-- Menu principal -->
			<div id="bgtop_banner"></div>
			<div id="bg_banner"></div>
			<div id="bghdown_banner"></div>
			<div id="bgdown_banner"></div>
			
			<p id="menu_top">
				<a id="l_princ" href="index">PRINCIPAL</a>
				<a id="l_faq" href="faq">FAQ</a>
				<a id="l_contato" href="contato">CONTATO</a>
				<a id="l_sobre" href="sobre">SOBRE</a>
			</p>
			
			<!-- Login -->
			<?php $objSess = new manageSession;$resp = $objSess->verificaSessaoUsuario();if($resp == false){ ?>
		
			<form id="frmLoga" action="include/loginUsuario.php" method="post">
						
				<div id="cmp_login">
				<div id="bg_login">
				
					
					<input type="submit" id="btn_ent"  name="loga" value=""/>
					<a href="javascript:;" id="btn_reg"></a>
					
					<a href="../en-us/perfil.html" id="lang_en"></a>
					<a href="../pt-br/perfil.html" id="lang_br"></a>

					<p><a href="javascript:;">Esqueceu a senha?</a></p>

				</div>
				
				<fieldset id="f_login_inp">
					<input type="text" name="login" value="nome de usu�rio" maxlength="12" id="c_login"/>
					<input type="password" name="senha" value="************" maxlength="12" id="c_senha" maxlength="12" />
				</fieldset>	
				
				</div>
			</form>
			
			<?php

				}else{ 
					echo "<div id='cmp_login2'><img src='".$_SESSION['sessaoUsuario']['foto']."' alt='Usu�rio' /><ul><li><span id='login_name'>".$_SESSION['sessaoUsuario']['nome']."</span></li>
				<li><span id='l_login'><a href='perfil/".$_SESSION['sessaoUsuario']['login']."'>Meu perfil</a> | <a href='logoutUsuario'>Sair</a></span></li></ul></div>";
			
				}
				
			?>
			<!-- Busca -->
			<div id="bg_search"></div>
			<a href="javascript:;" id="btn_search"></a>
			<input type="text" name="search" value="Palavra-chave" maxlength="30" id="c_search"/>
			
			<!-- Player -->
			<div id="player">
				<object type="application/x-shockwave-flash" width="231" height="60"  data="media/player/player.swf" >
				<param name="movie" value="media/player/player.swf" />	
				<param name="wmode" value="transparent" />
				</object>
			</div>
			
		</div>
			<!-- Tema -->	
			<span id="theme"><a href="../../dark/pt-br/perfil.html">Mudar tema</a></span>
		<!--//// Body ////-->	
		
		<div id="menu">
		
			<div id="top_menu1"></div>
			<div id="top_menu2"></div>
				
			<div id="bg1_menu">