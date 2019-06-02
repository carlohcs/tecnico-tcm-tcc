	<?php
	if(basename($_SERVER["PHP_SELF"]) == "artigoescrito.php") header("Location: ./index");
	echo "<script>window.onload = function(){document.title = '".$objSql->exibeArrayDados('titulo','artigo')." - Artigos - JOI&D';};</script>";
	?>		
	<div id="center">
	<div id="box_top"><p id="title_game"><?php echo $objSql->exibeArrayDados('titulo','artigo');?></p></div>
	<div id="top2"></div>
	<div id="box_center">
		<?php
		
			//EXIBIR O TEXTO DO ARTIGO
			$permCmt = ($verificaSess == true) ? 'true' : 'false';
			$codArt = $objSql->exibeArrayDados("codigo","artigo");			
			$objSql->defineEntidade('usuario');
			//PEGANDO CÓDIGO DO USUÁRIO
			$nmUs = $objSql->selectSql('COD_USU','LOG_USU = "'.$getUser.'"','','',true);
			$codUs = $objSql->exibeArrayDados("codigo","usuario");
			//--PEGANDO CÓDIGO DO USUÁRIO
			
			//SELECIONANDO O ARTIGO COM BASE NO CÓDIGO DO USUÁRIO E TÍTULO					
			$objSql->defineEntidade('usuario,artigo');
		
			$exSql = $objSql->selectSql("usuario.LOG_USU, artigo.TXT_ART,artigo.DT_POST_ART","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$codUs."'	
			AND artigo.COD_ART = '".$codArt."'","artigo.DT_POST_ART","",false);
			//--SELECIONANDO O ARTIGO COM BASE NO CÓDIGO DO USUÁRIO E CÓDIGO DE ARTIGO				
			
			//EXIBINDO O TEXTO
			$li = $objSql->fetch($exSql);
			echo "<p>Usuário: <a href='perfil/".$getUser."'>".$getUser."</a> em ".$objSql->formataData($li['DT_POST_ART'])."</p>";
			echo "<p>".$li['TXT_ART']."</p>";
			//--EXIBINDO O TEXTO
			
			
			//VERIFICANDO SE USUÁRIO CURTIU O ARTIGO
			$objSql->defineEntidade('curtir_artigo');
			$exSql = $objSql->selectSql("COD_CUR", "COD_ART = '{$codArt}' AND COD_USU = '{$_SESSION['sessaoUsuario']['codigo']}'", '', '', false);
			
			if($exSql != false){ $cod = $objSql->fetch($exSql);$stCur = 'false'; $codCur = $cod['COD_CUR']; }else{ $stCur = 'true'; $codCur = "false"; }
			//--VERIFICANDO SE USUÁRIO CURTIU O ARTIGO
			
			$objSql->encerraConexaoSql($conSql);
			
			
			//EXIBIR OS COMENTÁRIOS DO ARTIGO
						
			$objComt->exibeComentarioEcho($codArt,'artigo');
						
		?>
		
			<p><input type="button" value="comentarArtigo" id="comment"/><input type="hidden" value="<?php echo $codArt; ?>" id="codPost" />
			<input type="hidden" value="<?php echo $codUs; ?>" id="codUsu" /><input type="hidden" value="<?php echo $permCmt; ?>" id="permCmt" />
			<input type="hidden" value="<?php echo $stCur; ?>" id="statusCurtir" /><input type="hidden" value="<?php echo $codCur; ?>" id="codCur" /></p>
		
		<?php

		if($_SESSION['sessaoUsuario']['codigo'] != $codUs){ 
			
			if($codCur != 'false')	echo '<p><a href="javascript:;" class="curtir">Desfazer Curtir!</a></p>';
			else echo '<p><a href="javascript:;" class="curtir" >Curtir Artigo!</a></p>';
			
		}
		
		?>		
	</div>
	<div id="box_down2"></div>

</div>