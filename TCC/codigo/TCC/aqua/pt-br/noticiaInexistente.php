	<?php $noticiaTit = explode("-", $getNot); $strTit = ''; for($i=0;$i<sizeof($noticiaTit);$i++){$strTit.= $noticiaTit[$i]." ";}?>
	<div id="center">
			<!-- Not�cia inexistente -->
		<div id="box_top"><p id="title_game">Not�cia/Artigo N�o Encontrado</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<p>Desculpe, a not�cia/artigo "<?php echo $strTit;?>" n�o existe.</p>	
		</div>
		<div id="box_down2"></div>
	</div>