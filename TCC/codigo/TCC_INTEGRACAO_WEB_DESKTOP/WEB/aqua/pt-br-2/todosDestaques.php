<div id="center">
	<!-- Todos os destaques -->
	<div id="box_top"><p id="title_game">Destaques</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<?php
				echo "<p>::Imagens::</p>";
				
				$exSql = $objSql->selectSql('LINK_DEST, TIT_DEST, DT_DEST', 'FLAG_IMG_DEST =1', 'DT_DEST ASC', '20', false); 
				$dtAnte = "";
				
				echo "<ul>";
				while($retornoArray = $objSql->fetch($exSql)){
					if($retornoArray['DT_DEST'] != $dtAnte) echo "<li>".$objSql->formataData($retornoArray['DT_DEST'])."</li>";
					echo "<li><a href='destaques/{$retornoArray['LINK_DEST']}'>{$retornoArray['TIT_DEST']}</a></li>";
					$dtAnte = $retornoArray['DT_DEST'];
				}
				echo "</ul>";
				
				echo "<p>::Análises::</p>";
			
				$exSql = $objSql->selectSql('LINK_DEST, TIT_DEST, DT_DEST', 'FLAG_ANLS_DEST =1', 'DT_DEST', '20', false);
			
				echo "<ul>";
				while($retornoArray = $objSql->fetch($exSql)){
					if($retornoArray['DT_DEST'] != $dtAnte) echo "<li>".$objSql->formataData($retornoArray['DT_DEST'])."</li>";
					echo "<li><a href='destaques/{$retornoArray['LINK_DEST']}'>{$retornoArray['TIT_DEST']}</a></li>";
					$dtAnte = $retornoArray['DT_DEST'];
				}
				echo "</ul>";
			
				echo "<p>::Vídeos::</p>";
			
				$exSql = $objSql->selectSql('LINK_DEST, TIT_DEST, DT_DEST', 'FLAG_VID_DEST =1', 'DT_DEST', '20', false);
			
				echo "<ul>";
				while($retornoArray = $objSql->fetch($exSql)){
					if($retornoArray['DT_DEST'] != $dtAnte) echo "<li>".$objSql->formataData($retornoArray['DT_DEST'])."</li>";
					echo "<li><a href='destaques/{$retornoArray['LINK_DEST']}'>{$retornoArray['TIT_DEST']}</a></li>";
					$dtAnte = $retornoArray['DT_DEST'];
				}
				echo "</ul>";

				$objSql->encerraConexaoSql($conSql);
			?>
		</div>
		<div id="box_down2"></div>

</div>