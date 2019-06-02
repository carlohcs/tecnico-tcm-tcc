		<!-- Menu direito -->
		<?php	$opc = isset($_POST['tpOp']) && $_POST['tpOp'] != "" ? $_POST['tpOp'] : FALSE; ?>
				<div id="menu_right">
				<!-- Enquete -->
					<div id="pos_fix2">
					<div id="poll">
						<?php
							$voEnqt = isset($_POST['frmVoto']) ? $_POST['frmVoto'] : false;$viEnqt = isset($_POST['frmResult']) ? $_POST['frmResult'] : false;
							if($voEnqt){ $retorno = $objEnq->votaEnquete($opc);if($retorno == true){echo '<script>jAlert("<p>Voto Enviado!</p> Obrigado.", " ", function(){$.alerts.dialogClass = null;});</script>';$objEnq->listaEnquete();}	
							else{echo '<script>jAlert("<p>Escolha uma opção!</p>", " ", function(){$.alerts.dialogClass = null;});</script>'; $objEnq->listaEnquete();}
							}else if($viEnqt) $objEnq->resultadoEnquete(); else $objEnq->listaEnquete();
						?>
					</div>					
					<!-- Aliados -->
					<div class="bgt_link"><p>Aliados</p></div>
					<div class="bg_link">
						<ul class="l_left2">
							<li><a href="http://www.gamestnt.com" target="_blank">GamesTNT</a></li>
							<li><a href="http://www.gamevicio.com.br"  target="_blank">Games Vicio</a></li>
							<li><a href="http://www.jogosbr.net"  target="_blank">Jogos BR</a></li>
							<li><a href="http://www.rpgonline.com.br"  target="_blank">RPG Online</a></li>
						</ul>
						<div class="bgt_link"><p>Publicidade</p></div>
					</div>	
					<!-- Publicidade -->
					<?php $returnData = $objPublic->retornaPublicidadeLateral();
					$caminhoImg = implode("|", $returnData["caminhoImg"]);$titulos = implode("|", $returnData["titulos"]);$links = implode("|", $returnData["links"]); ?>
					<script>var param1 = '"<?php echo $caminhoImg; ?>"';var param2 = '"<?php echo $titulos; ?>"';var param3 = '"<?php echo $links; ?>"';
					window.setInterval("troca(" + param1 + ", " + param2 + ", " + param3 + ")",4000);</script>
					<div id="banner_adv"></div>
					<div id="close_menu2"></div>
					</div>
				</div>
			</div>
		</div>