<?php include_once("include/modules/includes.module.php"); //echo htmlspecialchars(SID); ?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="pt-br">

	<head >
		
		<base href="http://127.0.0.1:8080/TCC/aqua/pt-br/" />
		
		<title>Index - JOI&amp;D</title>
		
		<!-- Anexos -->
		<script type="text/javascript" src="js/jquery.js"></script>
		
		<link rel="stylesheet" type="text/css" href="css/body.css" media="all"/>
		<?php
		if(isset($_GET["page"]) && $_GET["page"] == "perfil"){
			echo "<link rel='stylesheet' type='text/css' href='css/perfil.css' media='all' id='perUser' />
			<script type='text/javascript' src='js/pontuacao.js'></script>";
		}else echo "<link rel='stylesheet' type='text/css' href='css/center.css' media='all' />";		
		?>
		<link rel="stylesheet" type="text/css" href="css/colorbox.css" media="all"/>
		<link rel="stylesheet" media="screen" type="text/css" href="css/datepick.css" />

		<script type="text/javascript" src="js/colorbox/jquery.colorbox-min.js"></script>
		<script type="text/javascript" src="js/jquery.cycle.all.min.js"></script>
		<script type="text/javascript" src="js/jquery.alerts.js"></script>
		<script type="text/javascript" src="js/ajax.js"></script>
		<script type="text/javascript" src="js/tiny_mce/jquery.tinymce.js"></script>
		<script type="text/javascript" src="js/tiny_mce/tiny_mce.js"></script>
		<script type="text/javascript" src="js/jquery.validate.js"></script>
		<script type="text/javascript" src="js/validaForm.js"></script>
		<script type="text/javascript" src="js/jquery.datepick.js"></script>
		<script type="text/javascript" src="js/containerShow.js"></script>
		<script type="text/javascript" src="js/efeitos.js"></script>
		<script type="text/javascript" src="js/login.js"></script>
		<script type="text/javascript" src="js/bannerPublicidade.js"></script>
		<script type="text/javascript" src="js/jquery.smoothscroll.js"></script>
		<script type="text/javascript" src="js/jquery.limit.js"></script>
		
		<!-- Meta Tags -->
		<meta http-equiv="content-type" content="text/html;charset=iso-8859-1" />
		<meta http-equiv="Content-Style-Type" content="text/css"/> 
		<meta name="author" content="Equipe JOI&amp;D" />
		<meta name="description" content="Jogos, Informações e Downloads" />
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
	
	<?php $objModule->getErrorsAlert(); ?>
	
	<div id="wrapper">
	
		<input type="hidden" value="<?php if($verificaSess == true) echo 'true'; else echo 'false' ?>" id="usLog" />
		
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
				<?php $retornoDados = $objNews->newsArtigo(true); ?>
				<ul id="resume_news">
				<?php
//				var_dump($retornoDados);
					for($i=0;$i<count($retornoDados['linkArtigo']);$i++) echo "<li><a href='artigos/".$objSql->formataUrl($retornoDados['categoria'][$i])."/".$retornoDados['usuario'][$i]."/".$retornoDados['linkArtigo'][$i]."'>".$retornoDados['artigo'][$i]."...</a></li>";
					?>
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
			<?php $resp = $objSession->verificaSessaoUsuario();if($resp == false){ ?>
		
			<form id="frmLoga" action="include/include_sec/loginUsuario.php" method="post">
						
				<div id="cmp_login">
				<div id="bg_login">
				
					
					<input type="submit" id="btn_ent"  name="loga" value=""/>
					<a href="registrar" id="btn_reg"></a>
					
					<a href="../en-us/perfil.html" id="lang_en"></a>
					<a href="../pt-br/perfil.html" id="lang_br"></a>

					<p><a href="javascript:;">Esqueceu a senha?</a></p>

				</div>
				
				<fieldset id="f_login_inp">
					<input type="text" name="login" value="nome de usuário" maxlength="12" id="c_login"/>
					<input type="password" name="senha" value="************" maxlength="12" id="c_senha" maxlength="12" />
				</fieldset>	
				
				</div>
			</form>
			
			<?php

				}else{ 
					$ft = (trim($_SESSION['sessaoUsuario']['foto']) != "") ? $_SESSION['sessaoUsuario']['foto'] : 'img/login/user_default2.png';
					
					echo 
					"<div id='cmp_login2'>
					<a href='perfil/".$_SESSION['sessaoUsuario']['login']."'>
						<img src='".$ft."' alt='Seu Perfil' title='Seu Perfil' id='ftUser' />
					</a>
					<span id='login_name'>
						<a href='perfil/".$_SESSION['sessaoUsuario']['login']."'>".$_SESSION['sessaoUsuario']['nome']."</a></span>
					<ul>
						<li id='l_login'>
						<span><a href='perfil/".$_SESSION['sessaoUsuario']['login']."' class='btn_down_more'>Mais</a></span>
							<ul class='menu_usuario'>
								<li><a href=''>Configurações</a></li>
								<li><a href=''>Configurações</a></li>
								<li><a href='perfil-editar/".$_SESSION['sessaoUsuario']['login']."'>Editar dados</a></li>
								<li><a href='excluir-conta'>Excluir conta</a></li>
							</ul>
						<a href='logoutUsuario' style='margin-left: 88px;'>Sair</a>
						</li>
					</ul>
					</div>";			
			
				}
				
			?>
			<!-- Busca -->
			<div id="bg_search"></div>
			
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