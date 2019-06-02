	<?php
		if(basename($_SERVER["PHP_SELF"]) == "destaques.php"){ header("Location: ./index"); }
		$tit = $objSql->exibeArrayDados("titulo","destaque");
		echo "<script type='text/javascript'>window.onload= function(){document.title = '{$tit} - Destaques - JOI&D';};</script>";
	?>	
	<div id="center">
	<!-- destaques -->
	<div id="box_top"><p id="title_game"><?php echo $tit; ?></p></div>
	<div id="top2"></div>
	<div id="box_center">
	
		<?php
			$codDest = $objSql->exibeArrayDados('codigo','destaque');
			$itn = '';
			//Verifica se possui conteudo de img
			$exSql = $objSql->selectSql("PATH_IMG1_DEST,PATH_IMG2_DEST,PATH_IMG3_DEST,
			PATH_IMG4_DEST,PATH_IMG5_DEST,PATH_IMG6_DEST,PATH_IMG7_DEST
			PATH_IMG8_DEST,PATH_IMG9_DEST","LINK_DEST = '{$getDestaque}' AND FLAG_IMG_DEST = 1", '', '', false);
			if($exSql == false)
			{
				//Verifica se possui conteudo de análise
				$exSql = $objSql->selectSql("TXT_DEST","LINK_DEST = '{$getDestaque}' AND FLAG_ANLS_DEST = 1", '', '', false);
				if($exSql == false)
				{
					//Verifica se possui conteudo de vídeo
					$exSql = $objSql->selectSql("LINK1_VID_DEST,LINK2_VID_DEST,LINK3_VID_DEST,
					LINK4_VID_DEST","LINK_DEST = '{$getDestaque}' AND FLAG_VID_DEST = 1", '', '', false);	
					$itn = 'vid';
				}
				else $itn = 'ana';		
			}
			else $itn = 'img';					
			
			//var_dump($objSql->SQLSERVER);
			
			//if($objSql->SQLSERVER == TRUE)
				$resp = mssql_fetch_row($exSql);
			/*else	
				$resp = mysql_fetch_row($exSql);*/
			
			
			$objSql->encerraConexaoSql($conSql);
			
			switch($itn)
			{
				case 'vid':
					echo "<p class='t_vid'><strong>Vídeos</strong></p>";
					echo "<iframe width='400' height='315' src='".$resp[0]."' frameborder='0' name='frameVid' id='game_vid' allowfullscreen='true'></iframe><div id='l_vid'>";
					for($i=0;$i<count($resp);$i++){	if($resp[$i] != "")	echo "<a href='".$resp[$i]."' target='frameVid' />Video ".($i + 1)."</a>";	}
					echo "</div>";
				break;
				case 'ana':
					echo "<p class='desc_game'>{$resp[0]}</p>";
				break;
				case 'img':
					echo "<div id='t_screen'><p>Galeria de imagens</p></div>";
					echo "<ul>";
					for($i=0;$i<count($resp);$i++){ if($resp[$i] != "") echo "<li class='gallery'><a  href='img/articles/img/".$resp[$i]."' rel='clbx' title='".$tit.$i."'><img class='gallery_img' src='img/articles/img/".$resp[$i]."' alt='Imagem' rel='cl' /></a></li>"; }
					echo "</ul>";
					echo "<div style='clear: both;padding-bottom: 35px;'></div>";
				break;
			}
			

			include_once('include/include_sec/sharer.php');
			
		?>

			<span id="top_comment"></span>
			<p id="comment"><a href="comentarDestaque"></a><input type="hidden" value="<?php echo $codDest ?>" id="codPost" />
			<input type="hidden" value="<?php echo $codUs; ?>" id="codUsu" /><input type="hidden" value="<?php echo $permCmt; ?>" id="permCmt" />
			<input type="hidden" value="<?php echo $stCur; ?>" id="statusCurtir" /><input type="hidden" value="<?php echo $codCur; ?>" id="codCur" /></p>
			<p class="t_comments">Comentários</p>
			<?php $objComt->exibeComentarioEcho($codDest,'destaque');	$permCmt = ($verificaSess == true) ? 'true' : 'false'; ?>	
			

	</div>
	<div id="box_down2"></div>

</div>