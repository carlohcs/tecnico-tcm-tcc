<div id="center">
<!-- TODOS OS ARTIGOS -->
<div id="box_top"><p id="title_game">Todos os artigos</p></div>
	<div id="top2"></div>
	<div id="box_center">
		<?php
		include_once('server/php.class/manageArtigo.class.php');
		$objArt = new manageArtigo;
		$exSql = $objArt->selecionarAllArtigos();
		$cateAtual = ""; $dataAt = "";
		for($i=0;$i<count($exSql['categoria']);$i++)
		{
			
			echo "<p class='desc_cat'>{$exSql['categoria'][$i]}</p>";
			echo "<ul class='cat_list'>";
				for($j = 0; $j<count($exSql['titulo']); $j++)
				{
					
					if($exSql["codigoCateArtigo"][$j] == $exSql["codCategoria"][$i])
					{						
							echo "<li  class='jogos_cat'>&raquo; <a href='artigos/{$exSql['link'][$i]}/{$exSql['login'][$j]}/{$exSql['linkArt'][$j]}' >
							 {$exSql['titulo'][$j]}</a></li>";	 
					}
					$dataAt = $exSql['data'][$j];
				}			
			echo "</ul>";	
			
		}
		?>
	
	</div>
	<div id="box_down2"></div>

</div>