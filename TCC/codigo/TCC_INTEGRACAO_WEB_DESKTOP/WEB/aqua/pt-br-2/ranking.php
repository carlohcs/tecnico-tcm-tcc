<div id="center">
	<!-- ranking -->
	<style>
	.ranking{color:#fff;margin: 0 auto;width:420px;text-align:center;}td{width: 210px;border-left:1px ridge #ccc;border-right:1px ridge #666;text-align:left;}
	.dataRnk{text-align: center;border-bottom: 2px ridge #666;padding-bottom:5px;color:#fff;}</style>
	<div id="box_top"><p id="title_game">Ranking</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<?php
				include_once('server/php.class/manageRanking.class.php');
				$objRnk = new manageRanking;
				
				//$retorno = $objRnk->atualizaRanking();
				
				$objRnk->exibeRanking();
			?>			
		</div>
		<div id="box_down2"></div>

</div>

