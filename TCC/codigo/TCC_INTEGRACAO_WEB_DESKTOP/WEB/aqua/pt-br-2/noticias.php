	<?php
		if(basename($_SERVER["PHP_SELF"]) == "noticias.php"){ header("Location: ./index"); }
		$tit = $objSql->exibeArrayDados("titulo","noticia");
		echo "<script type='text/javascript'>window.onload= function(){document.title = '{$tit} - Notícias - JOI&D';};</script>";
	?>
	<div id="center">
		<!-- Notícias -->
		<div id="box_top"><p id="title_game"><?php echo $objSql->exibeArrayDados('titulo','noticia'); ?></p></div>
		<div id="top2"></div>
		<div id="box_center">
			
				<img src="<?php echo $objSql->exibeArrayDados('imgIni','noticia'); ?>" id="imgIni" width="300px" height="200px"/>
				<p><?php echo $objSql->exibeArrayDados('texto','noticia'); ?></p>
			
			<?php	$codNot = $objSql->exibeArrayDados('codigo','noticia'); 	$permCmt = ($verificaSess == true) ? 'true' : 'false'; ?>
			
			<p id="comment"><a href="comentarNoticia">Comentar</a><input type="hidden" value="<?php echo $codNot; ?>" id="codPost" />
			<input type="hidden" value="<?php if(!empty($_SESSION)) echo $_SESSION["sessaoUsuario"]['codigo']; else echo "";?>" id="codUsu" /><input type="hidden" value="<?php echo $permCmt; ?>" id="permCmt" /></p>
			
			<?php $objComt->exibeComentarioEcho($codNot,'noticias'); include_once('include/include_sec/sharer.php'); ?>
		</div>	
		<div id="box_down2"></div>

		
	</div>	