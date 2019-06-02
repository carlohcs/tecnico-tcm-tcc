		<!-- Menu esquerdo -->
		<?php 
		/*$jogCat1 = $mnJogos->listaJogosCategoria($rpCat['codCategoria'][0]);
			$jogCat2 = $mnJogos->listaJogosCategoria($rpCat['codCategoria'][1]);
			$jogCat3 = $mnJogos->listaJogosCategoria($rpCat['codCategoria'][2]); */
			include_once("server/php.class/manageJogos.class.php");
			$mnJogos = new manageJogos; $rpCat = $mnJogos->listaCategoria();
			$jogosCat = $mnJogos->listaJogosCategoria("",false);
		?>
		<div id="pos_fix1"></div>
			<ul id="l_left1">
				<li><a href="lista.html">Categorias</a></li>
				<li><a href="detonados.html">Detonados</a></li>
				<li><a href="tutoriais.html">Tutoriais</a></li>
				<li><a href="emuladores.html">Emuladores</a></li>
				<li><a href="<?php if($verificaSess == true) echo "index/escreverArtigo"; else echo $getPage."/escreverArtigoNegado";?>">Escrever matéria</a></li>
			</ul>
				
			<div id="menu_left">	
		
				<div class="bg_link">
				
				<?php
					echo "<div class='bgt_link'><p>{$rpCat['descricaoCategoria'][0]}</p></div>";
					echo "<ul class='l_left2'>";
					for($i=0;$i<5;$i++){ echo "<li><a href='jogos/{$rpCat['linkCategoria'][0]}/{$jogosCat['linkJogo'][$i]}'>{$jogosCat['descricaoJogo'][$i]}</a></li>"; }
					echo "</ul>";
					echo "<div class='bgt_link'><p>{$rpCat['descricaoCategoria'][1]}</p></div>";
					echo "<ul class='l_left2'>";
					for($i=5;$i<10;$i++){ echo "<li><a href='jogos/{$rpCat['linkCategoria'][1]}/{$jogosCat['linkJogo'][$i]}'>{$jogosCat['descricaoJogo'][$i]}</a></li>"; }
					echo "</ul>";	
					echo "<div class='bgt_link'><p>{$rpCat['descricaoCategoria'][2]}</p></div>";
					echo "<ul class='l_left2'>";
					for($i=10;$i<15;$i++){ echo "<li><a href='jogos/{$rpCat['linkCategoria'][2]}/{$jogosCat['linkJogo'][$i]}'>{$jogosCat['descricaoJogo'][$i]}</a></li>"; }
					echo "</ul>";
				?>
					
				</div>
				
				<div id="close_menu1"></div>
			
			</div>