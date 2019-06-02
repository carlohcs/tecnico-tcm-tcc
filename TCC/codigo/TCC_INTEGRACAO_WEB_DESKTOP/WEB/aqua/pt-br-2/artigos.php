<div id="center">
	<!-- artigos -->
	<div id="box_top"><p id="title_game"><?php echo "Artigos de <a href='perfil/".$getUser."'>".$getUser."</a>";?></p></div>
		<div id="top2"></div>
		<div id="box_center">
					<?php
					
						$objSql->defineEntidade('usuario');
						
						$nmUs = $objSql->selectSql('COD_USU','LOG_USU = "'.$getUser.'"','','',true);
						
						$codUs = $objSql->exibeArrayDados("codigo","usuario");
						
						$objSql->defineEntidade('usuario,artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG');
						
						$exSql = $objSql->selectSql("usuario.COD_USU,usuario.LOG_USU, artigo.TIT_ART,artigo.LINK_ART,artigo.DT_POST_ART, categoria.TIT_CTG","usuario.COD_USU = artigo.COD_USU AND usuario.COD_USU = '".$codUs."'","artigo.DT_POST_ART","",false);
						
						if($exSql != false)
						{
						if($objSql->rows($exSql) != 0)
						{
							echo "<ul>";
						
								while($li = $objSql->fetch($exSql)) echo "<li class='gallery'><a href='artigos/{$li['TIT_CTG']}/{$li['LOG_USU']}/{$li['LINK_ART']}'>{$li['TIT_ART']} - {$objSql->formataData($li['DT_POST_ART'])}</a></li>";
						
							echo "</ul>";
						}else echo "<p>Esse usuário não possui artigos.</p>";
						}else echo "<p>Esse usuário não possui artigos.</p>";
						$objSql->encerraConexaoSql($conSql);
						
						
					?>
					
					
		</div>
		<div id="box_down2"></div>

	</div>