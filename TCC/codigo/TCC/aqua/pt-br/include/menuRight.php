		<!-- Menu direito -->
				<div id="menu_right">
				
					<!-- Enquete -->
					<div id="pos_fix2">
					<div id="poll">
						<?php	
							include_once("server/php.class/manageEnquete.class.php");
							$objEn = new manageEnquete(2);$opc = isset($_POST['tpOp']) && $_POST['tpOp'] != "" ? $_POST['tpOp'] : FALSE;
							if(isset($_POST['frmVoto'])){ $retorno = $objEn->votaEnquete($opc);
							if($retorno == true) echo '<script>jAlert("<p>Voto Enviado!</p> Obrigado.", " ", function(){$.alerts.dialogClass = null;});</script>';
							else echo '<script>jAlert("<p>Escolha uma opção!</p>", " ", function(){$.alerts.dialogClass = null;});</script>';
							}
							$getEnquete = isset($_GET['enquete']) ? $_GET['enquete'] : FALSE;
							switch($getEnquete){case "visualizar": $objEn->listaEnquete();break;case "resultado": $objEn->resultadoEnquete();break;				
							default:$objEn->listaEnquete();}
						?>
					</div>	
					
					<!-- Aliados -->
					<div class="bgt_link"><p>Aliados</p></div>
					<div class="bg_link">
						<ul class="l_left2">
							<li><a href="http://www.gamestnt.com">GamesTNT</a></li>
							<li><a href="http://www.gamevicio.com.br">Games Vicio</a></li>
							<li><a href="http://www.jogosbr.net">Jogos BR</a></li>
							<li><a href="http://www.rpgonline.com.br">RPG Online</a></li>
						</ul>
						<div class="bgt_link"><p>Publicidade</p></div>
					</div>
						
					<!-- Publicidade -->
					<?php include_once("server/php.class/managePublicity.class.php"); $objPub = new managePublicity;$returnData = $objPub->retornarPublicidade();
					$caminhoImg = implode("|", $returnData["caminhoImg"]);$titulos = implode("|", $returnData["titulos"]);$links = implode("|", $returnData["links"]); ?>
					<script>var param1 = '"<?php echo $caminhoImg; ?>"';var param2 = '"<?php echo $titulos; ?>"';var param3 = '"<?php echo $links; ?>"';
					window.setInterval("troca(" + param1 + ", " + param2 + ", " + param3 + ")",4000);</script>
					<div id="banner_adv"></div>
					<div id="close_menu2"></div>
					</div>
				
				</div>
				
			</div>

		</div>