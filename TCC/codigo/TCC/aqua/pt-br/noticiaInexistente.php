	<?php $noticiaTit = explode("-", $getNot); $strTit = ''; for($i=0;$i<sizeof($noticiaTit);$i++){$strTit.= $noticiaTit[$i]." ";}?>
	<div id="center">
			<!-- Notícia inexistente -->
		<div id="box_top"><p id="title_game">Notícia/Artigo Não Encontrado</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<p>Desculpe, a notícia/artigo "<?php echo $strTit;?>" não existe.</p>	
		</div>
		<div id="box_down2"></div>
	</div>