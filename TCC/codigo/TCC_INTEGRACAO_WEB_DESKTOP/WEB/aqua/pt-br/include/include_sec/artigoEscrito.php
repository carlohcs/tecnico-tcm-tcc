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
			//PEGANDO C�DIGO DO USU�RIO
			$nmUs = $objSql->selectSql('COD_USU','LOG_USU = "'.$getUser.'"','','',true);
			$codUs = $objSql->exibeArrayDados("codigo","usuario");
			//--PEGANDO C�DIGO DO USU�RIO
			
			//SELECIONANDO O ARTIGO COM BASE NO C�DIGO DO USU�RIO E T�TULO					
			$objSql->defineEntidade('usuario,artigo');
		
			$exSql = $objSql->selectSql("usuario.LOG_USU, artigo.TXT_ART,artigo.DT_POST_ART","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$codUs."'	
			AND artigo.COD_ART = '".$codArt."'","artigo.DT_POST_ART","",false);
			//--SELECIONANDO O ARTIGO COM BASE NO C�DIGO DO USU�RIO E C�DIGO DE ARTIGO				
			
			//EXIBINDO O TEXTO
			$li = $objSql->fetch($exSql);
			echo "<p class='user_art'><span class='by_art'>por <span class='user_comment'><a href='perfil/".$getUser." '>".$getUser."</a></span> <span class='date_art'> ".$objSql->formataData($li['DT_POST_ART'])."</span></p>";
			echo "<p class='desc_art'>".$li['TXT_ART']."</p>";
			//--EXIBINDO O TEXTO
			
			
			//VERIFICANDO SE USU�RIO CURTIU O ARTIGO
			$objSql->defineEntidade('curtir_artigo');
			$exSql = $objSql->selectSql("COD_CUR", "COD_ART = '{$codArt}' AND COD_USU = '{$_SESSION['sessaoUsuario']['codigo']}'", '', '', false);
			
			if($exSql != false){ $cod = $objSql->fetch($exSql);$stCur = 'false'; $codCur = $cod['COD_CUR']; }else{ $stCur = 'true'; $codCur = "false"; }
			//--VERIFICANDO SE USU�RIO CURTIU O ARTIGO
			
			$objSql->encerraConexaoSql($conSql);
			
			
			//EXIBIR OS COMENT�RIOS DO ARTIGO
						
			include_once('include/include_sec/sharer.php');
				
			
			if($_SESSION['sessaoUsuario']['codigo'] != $codUs){ 
				if($codCur != 'false')	echo '<a href="javascript:;" class="curtir"></a>';
				else echo '<a href="javascript:;" id="desfazer" class="curtir" ></a>';
			}
			
			?>
			<span id="top_comment"></span>
			<p id="comment"><a href="comentarArtigo"></a>

			<input type="hidden" value="<?php echo $codArt; ?>" id="codPost" />
			<input type="hidden" value="<?php echo $codUs; ?>" id="codUsu" /><input type="hidden" value="<?php echo $permCmt; ?>" id="permCmt" />
			<input type="hidden" value="<?php echo $stCur; ?>" id="statusCurtir" /><input type="hidden" value="<?php echo $codCur; ?>" id="codCur" /></p>

			<p class="t_comments">Coment�rios</p>
			<?php $objComt->exibeComentarioEcho($codArt,'artigo'); ?>	

		
		
	</div>
	<div id="box_down2"></div>

</div>