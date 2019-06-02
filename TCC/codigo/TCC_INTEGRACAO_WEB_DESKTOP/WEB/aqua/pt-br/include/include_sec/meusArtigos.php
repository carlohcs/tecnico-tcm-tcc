<div id="center">
	<div id="box_top"><p id="title_game">Meus artigos</p></div>
	<div id="top2"></div>
	<div id="box_center">
	
		<?php
			$conSql = $objSql->conexaoSql();$objSql->defineEntidade('usuario,artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG');
			$exSql = $objSql->selectSql("usuario.LOG_USU, artigo.TIT_ART,artigo.DT_POST_ART","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$_SESSION['sessaoUsuario']['codigo']."'","artigo.DT_POST_ART","",false);
			
			if($exSql != false)
			{
				
				$exSql = $objSql->selectSql("usuario.LOG_USU, artigo.TIT_ART,artigo.DT_POST_ART,categoria.TIT_CTG","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$_SESSION['sessaoUsuario']['codigo']."' AND FLAG_ART_AP = 1","artigo.DT_POST_ART","",false);
				
				if($exSql != false)
				{
					if($objSql->rows($exSql) != 0)
					{
				
						echo '<p class="desc_cat">Aprovados</p>';
						echo "<ul>";
						
							while($li = $objSql->fetch($exSql)) echo "<li class='gallery'><a href='artigos/".$objSql->formataUrl($li['TIT_CTG'])."/{$li['LOG_USU']}/{$objSql->formataUrl($li['TIT_ART'])}'>{$objSql->formataData($li['DT_POST_ART'])} - {$li['TIT_ART']}</a></li>";
				
						echo "</ul>";
					
					}else echo "<p>Nenhum artigo aprovado</p>";
				}	
				
				$exSql = $objSql->selectSql("usuario.LOG_USU, artigo.TIT_ART,artigo.DT_POST_ART,categoria.TIT_CTG","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$_SESSION['sessaoUsuario']['codigo']."' AND FLAG_ART_AP = 0","artigo.DT_POST_ART","",false);
				
				if($exSql != false)
				{
					if($objSql->rows($exSql) != 0)
					{
				
						echo '<p class="desc_cat">Aguardando moderação</p>';
						echo "<ul>";
						
						while($li = $objSql->fetch($exSql)) echo "<li class='gallery'><a href='artigos/".$objSql->formataUrl($li['TIT_CTG'])."/{$li['LOG_USU']}/{$objSql->formataUrl($li['TIT_ART'])}'>{$objSql->formataData($li['DT_POST_ART'])} - {$li['TIT_ART']}</a></li>";
				
						echo "</ul>";
					
					}else echo "<p>Nenhum artigo enviado</p>";
				}
				
				echo "<p id='art_refused'>* Artigos recusados pela moderação serão excluídos automaticamente</p>";
				
			}else echo "<p>Você não possui artigos.</p>";
			$objSql->encerraConexaoSql($conSql);
		?>			
	</div>
	<div id="box_down2"></div>

</div>