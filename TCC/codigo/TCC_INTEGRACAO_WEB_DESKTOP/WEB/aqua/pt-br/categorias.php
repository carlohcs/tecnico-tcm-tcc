<div id="center">
	<!-- categorias -->
	<div id="box_top"><p id="title_game">Categorias</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<?php
				
				$cate = $objJogos->listaCategoria(true);
				$jogosCate = $objJogos->listaJogosCategoria(false);
	
				for($i=0;$i<count($cate);$i++)
				{
					echo "<p class='desc_cat'>".$cate['descricaoCategoria'][$i]."</p>";
					echo "<ul class='cat_list'>";
					for($j=0;$j<count($jogosCate['descricaoJogo']);$j++)
					{
						if(($i + 1) == $jogosCate['codCategoria'][$j])
						echo "<li class='jogos_cat'>&raquo; <a href='jogos/{$cate['linkCategoria'][$i]}/{$jogosCate['linkJogo'][$j]}'>".$jogosCate['descricaoJogo'][$j]."</a></li>";
					}
					echo "</ul>";
				}
			
			?>
			
		</div>
		<div id="box_down2"></div>

</div>