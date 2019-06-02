			<?php include_once("server/php.class/manageBannerNews.class.php"); $obj = new manageBannerNews;	$returnData = $obj->retornaBannerNoticias(); ?>
			<!-- Banner notícias -->					
			<div id="bg_cbanner">
				<ul id="b_ul">
				<!--1-->
				<li>
					<a href="noticias/<?php  echo $returnData['links'][0]; ?>"><img src="<?php  echo $returnData['caminhoImg'][0]; ?>" alt="Banner"/></a>
					<div class="fundo"><p><a href="noticias/<?php  echo $returnData['links'][0]; ?>" title="Notícia 1"><?php  echo $returnData['descricao'][0]; ?></a></p></div>
				</li>
				<!--2-->
				<li>
					<a href="noticias/<?php  echo $returnData['links'][1]; ?>"><img src="<?php  echo $returnData['caminhoImg'][1]; ?>" alt="Banner"/></a>
					<div class="fundo"><p><a href="noticias/<?php  echo $returnData['links'][1]; ?>" title="Notícia 2"><?php  echo $returnData['descricao'][1]; ?></a></p></div>
				</li>
				<!--3-->	
				<li>
					<a href="noticias/<?php  echo $returnData['links'][2]; ?>"><img src="<?php  echo $returnData['caminhoImg'][2]; ?>" alt="Banner"/></a>
					<div class="fundo"><p><a href="noticias/<?php  echo $returnData['links'][2]; ?>" title="Notícia 3"><?php  echo $returnData['descricao'][2]; ?></a></p></div>
				</li>
				<!--4-->	
				<li>
					<a href="noticias/<?php  echo $returnData['links'][3]; ?>"><img src="<?php  echo $returnData['caminhoImg'][3]; ?>" alt="Banner"/></a>
					<div class="fundo"><p><a href="noticias/<?php  echo $returnData['links'][3]; ?>" title="Notícia 4"><?php  echo $returnData['descricao'][3]; ?></a></p></div>
				</li>
					</ul>
			</div>
			
			<div id="btn_cbanner"></div>

			<a href="#" id="next_cbanner"><img src="img/btn_down.png" alt="Down"/></a>
			<a href="#" id="prev_cbanner"><img src="img/btn_up.png" alt="Up"/></a>
						
			<!-- Postagens -->		
			<div id="bar"></div>
			
			<div id="post">
			
			<!-- 1 -->

				<span id="nt1">&nbsp;</span>
				
					<div class="new_data">
						<div class="assunto">Campeonato nacional de Combat Arms</div>
						<div class="user">Carlohcs</div>
						<div class="data">20/06/2011</div>
					</div>
					
					<div class="new_avatar">
						<div class="avatar"><img src="img/news/users/user01.jpg" alt="Usuário"/></div>
					</div>
					
					<div class="new_center1">
					
						<div class="new_center2">
						
							<div class="text">
								<p>Jogadores do game de tiro on-line "Combat Arms" terá seu primeiro campeonato 
								nacional, que será realizado em todo o Brasil entre junho e setembro. As partidas, 
								que serão realizadas em lan houses de São Paulo, Rio de Janeiro, Brasília, Manaus, 
								São Luís, Belo Horizonte, Salvador e Curitiba começam no sábado (4).</p><br/>
								Promovido pela Level Up!, que distribui o jogo no país, o 1º Campeonato 
								Brasileiro de Combat Arms terá batalhas no modo "Buscar e Destruir" com times de 
								cinco integrantes. Ao todo, serão 14 rounds por partida, sendo que a equipe vencedora
								é a que conseguir vencer 8 rounds primeiro.
								<br/><br/>
								<div class="more"><img src="img/news/more_icon.png" alt="Comentário"/> <a href="#">Continue lendo</a></div>
							</div>
							
						</div>	
						
					</div>
		
				<div class="new_down"></div>
				<span id="nt2">&nbsp;</span>
			
				<!-- 2 -->
					
					<div class="new_data">
						<div class="assunto">Sony restaura loja on-line do PlayStation</div>
						<div class="user">Jorge Lucas</div>
						<div class="data">18/06/2011</div>
					</div>
					
					<div class="new_avatar">
						<div class="avatar"><img src="img/news/users/user02.jpg" alt="Usuário"/></div>
					</div>
					
					<div class="new_center1">
					
						<div class="new_center2">
						
							<div class="text">
								<p>Depois de sofrer um ataque que comprometeu as contas de mais de 100 milhões de usuários 
								da PlayStation Network, a Sony anunciou na quarta-feira (1) que a loja on-line do videogame 
								foi restaurada para os jogadores da América, Europa e parte da Ásia.</p><br/>
								Com o retorno da loja, a PSN foi totalmente restaurada e permite que os usuários comprem e 
								baixem jogos na internet. A rede on-line de games do PlayStation 3 e do PSP voltou ao ar no 
								Brasil, parcialmente, em 15 de maio. A loja on-line, no entanto, ainda permanecia indisponível
								em todo o mundo.
								<br/><br/>
								<div class="more"><img src="img/news/more_icon.png" alt="Comentário"/> <a href="#">Continue lendo</a></div>
							</div>
							
						</div>	
						
					</div>

				<div class="new_down"></div>
				<span id="nt3">&nbsp;</span>
			
				<!-- 3 -->

					<div class="new_data">
						<div class="assunto" >StarCraft II: Heart of The Swarm</div>
						<div class="user">Deivison</div>
						<div class="data">17/06/2011</div>
					</div>
					
					<div class="new_avatar">
						<div class="avatar"><img src="img/news/users/user03.jpg" alt="Usuário"/></div>
					</div>
					
					<div class="new_center1">
					
						<div class="new_center2">
						
							<div class="text">
								<p>A segunda parte da trilogia de 'StarCraft II' começa a ser divulgada pela Blizzard. 
								No vídeo desta nova edição, podemos ver o exército de Zergs (insetos gigantes) que 
								será controlado pelo jogador. O game ainda não tem data de lançamento oficial.</p><br/> 
								
								<p>Confira: <a href="http://www.youtube.com/watch?v=BtERw16cSHc">www.youtube.com/watch?v=BtERw16cSHc</a></p><br/>
								<div class="more"><img src="img/news/more_icon.png" alt="Comentário"/> <a href="#">Continue lendo</a></div>
								
							</div>
							
						</div>	
						
					</div>

				<div class="new_down"></div>
				<span id="nt4">&nbsp;</span>
					
				<!-- 4 -->	

					<div class="new_data">
						<div class="assunto" >Nintendo reduz o preço do portátil DS Lite</div>
						<div class="user">Monique</div>
						<div class="data">16/06/2011</div>
					</div>
					
					<div class="new_avatar">
						<div class="avatar"><img src="img/news/users/user04.jpg" alt="Usuário"/></div>
					</div>
					
					<div class="new_center1">
					
						<div class="new_center2">
						
							<div class="text">
								<p>A Nintendo anunciou nesta terça-feira (31) que irá reduzir o preço do portátil Nintendo DS Lite 
								para US$ 100 nos Estados Unidos. O corte de US$ 30 será valido a partir do dia 5 de junho.</p><br/>
								<p>Além do novo preço do antigo modelo do portátil, a Nintendo irá relançar seis games de Mario do
								portátil em uma caixa nova, na cor vermelha. "New Super Mario Bros.", "Mario Kart DS", 
								"Super Mario 64 DS", "Mario &amp; Luigi: Bowser's Inside Story", "Mario vs. Donkey Kong" e 
								"Mario Party DS". Os jogos, que funcionam no novo Nintendo 3DS, não terão redução de preço.</p>
								<br/>
								<div class="more"><img src="img/news/more_icon.png" alt="Comentário"/> <a href="#">Continue lendo</a></div>
							</div>
							
						</div>	
						
					</div>
					
				<div class="new_down"></div>
				<span id="nt5">&nbsp;</span>
				
				<!-- 5 -->	

					<div class="new_data">
						<div class="assunto">GOD OF WAR NO XBOX 360?</div>
						<div class="user">Andreas</div>
						<div class="data">16/06/2011</div>
					</div>
					
					<div class="new_avatar">
						<div class="avatar"><img src="img/news/users/user05.jpg" alt="Usuário"/></div>
					</div>
					
					<div class="new_center1">
					
						<div class="new_center2">
						
							<div class="text">
								<p>Bom não é bem isso, mas passeado por alguns sites de comprar de Skin para o meu Xbox eu vi uma das
								coisas mais "sem noção" de todas. Todo mundo sabe que o God of War é um game exclusivo para os consoles
								da Sony e que enquanto a Sony tiver seu console, nunca existira a chance de seu game ir para o Xbox.
								Mas parece que alguns proprietários do Xbox não ligam para o fato de se passar por bobos, e compram o
								Skin do God of War para Xbox 360.</p><br/>
								<br/>
								<div class="more"><img src="img/news/more_icon.png" alt="Comentário"/> <a href="#">Continue lendo</a></div>
							</div>
							
						</div>	
						
					</div>
						
				<div class="new_down"></div>
				<span>&nbsp;</span>
				
			</div>