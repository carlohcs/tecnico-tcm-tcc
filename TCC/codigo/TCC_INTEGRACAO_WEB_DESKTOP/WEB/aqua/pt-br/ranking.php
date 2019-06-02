<div id="center">
	<!-- Ranking -->
	<div id="box_top"><p id="title_game">Ranking</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<?php
				include_once('server/php.class/manageRanking.class.php');
				$objRnk = new manageRanking; define("FLAGATU", false);
				/*if(!defined("FLAGATU2"))
				{
					if(FLAGATU == false)
					{
						
						if($retorno == true) runkit_constant_redefine ( "FLAGATU2" , true );
					}
				}	*/
				//$retorno = $objRnk->atualizaRanking();
				
				$objRnk->exibeRanking();
			?>			
		</div>
		<div id="box_down2"></div>

</div>

