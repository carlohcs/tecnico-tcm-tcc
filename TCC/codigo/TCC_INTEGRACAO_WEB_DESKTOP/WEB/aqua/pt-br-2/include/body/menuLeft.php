		<!-- Menu Left -->
			<div id="menu_left">	
			<ul id="l_left1">
				<li class="bgl_menu_left"><a href="jogos-categoria">Categorias</a></li>
				<li><a href="tutoriais.html">Tutoriais</a></li>
				<li><a href="ranking-usuarios">Ranking</a></li>
				<li><a href="escreverArtigo.html">Escrever artigo</a></li>
				<li class="pdd_menu_left"></li>
			</ul>
			<div class="bg_link">
				
				<?php
				$cate = $objJogos->listaCategoria(true);
				$jogosCate = $objJogos->listaJogosCategoria(true);
	
				for($i=0;$i<count($cate);$i++)
				{
					echo "<div class='bgt_link'><p>".$cate['descricaoCategoria'][$i]."</p></div>";
					echo "<ul class='l_left2'>";
					for($j=0;$j<count($jogosCate['descricaoJogo']);$j++)
					{
						if(($i + 1) == $jogosCate['codCategoria'][$j])
						echo "<li><a href='jogos/{$cate['linkCategoria'][$i]}/{$jogosCate['linkJogo'][$j]}'>".$jogosCate['descricaoJogo'][$j]."</a></li>";
					}
					echo "</ul>";
				}
				?>
					
				</div>
				
				<div id="close_menu1"></div>
			
			</div>