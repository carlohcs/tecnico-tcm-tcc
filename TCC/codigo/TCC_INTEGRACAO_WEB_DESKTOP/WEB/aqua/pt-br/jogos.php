	<?php	if(basename($_SERVER["PHP_SELF"]) == "jogos.php") header("Location: ./index");	echo "<script>window.onload= function(){document.title = '".$objSql->exibeArrayDados('titulo','jogos')." - Jogos - JOI&D'};</script>";	?>
	<div id="center">
		<div id="box_top"><p id="title_game"><a href=""><?php echo $objSql->exibeArrayDados('titulo','jogos'); ?></a></p></div>
		<div id="top2"></div>
			
		<div id="box_center">
					<?php
						switch($getActJ)
						{
							
							case 'descricao':
								$objRespo = $objSql->selectSql("PATH_IMG1_DESC_INT_CTG,TXT_ITN_CTG", "TIT_ITN_CTG = '{$url}'", '', '1',false);
								$li = $objSql->fetch($objRespo);
								echo "<p class='img_game'><img src='{$li['PATH_IMG1_DESC_INT_CTG']}' /></p>";
								echo "<p class='desc_game'>{$li['TXT_ITN_CTG']}</p>";
							break;
							case 'download':
								echo "<p class='t_down'><strong>Download</strong></p>
									<p class='desc_down'><strong><a href='' target='_blank'>Clique aqui</a></strong> para fazer o download.</p>
									<p class='t_down'>Requisitos de Sistema</p>
									<p class='desc_down'>Você já verificou as configurações do seu computador?</p> 
									<p class='desc_down'>Se o sistema não atende os requisitos do jogo, talvez possa ter um desempenho abaixo do desejável.
									Para garantir uma boa experiência durante a jogabilidade, recomendamos as configurações abaixo:</p>
									<p class='t_down2'>Requisitos mínimos</p>
									<ul class='desc_req'>"; 
										$objRespo = $objSql->selectSql("LINK_DOWN_INT_CTG,SIS_OP_INT_CTG,PROC_INT_CTG,RAM_INT_CTG,HD_INT_CTG,PL_VD_INT_CTG,PL_RD_INT_CTG", "TIT_ITN_CTG = '".$url."'", '', '1',false);
										$li = $objSql->fetch($objRespo);
										echo "<li>Sistema Operacional: ".$li['SIS_OP_INT_CTG']."</li>
										<li>Processador: ".$li['PROC_INT_CTG']."</li>
										<li>Memória: ".$li['RAM_INT_CTG']."</li>
										<li>HD: ".$li['HD_INT_CTG']."</li>
										<li>Placa de vídeo: ".$li['PL_VD_INT_CTG']."</li>
										<li>Placa de rede: ".$li['PL_RD_INT_CTG']." </li>
										<li>Download DirectX</li></ul>";
									break;
							
							case 'imagens':
								$objRespo = $objSql->selectSql("PATH_IMG1_DESC_INT_CTG,PATH_IMG2_DESC_INT_CTG, PATH_IMG3_DESC_INT_CTG,
								PATH_IMG4_DESC_INT_CTG, PATH_IMG5_DESC_INT_CTG,	PATH_IMG6_DESC_INT_CTG, PATH_IMG7_DESC_INT_CTG,
								PATH_IMG8_DESC_INT_CTG, PATH_IMG9_DESC_INT_CTG", "TIT_ITN_CTG = '{$url}'", '', '',false);
								//if($objSq->SQLSERVER == TRUE)
									$li = mssql_fetch_row($objRespo);
								/*else
									$li = mysql_fetch_row($objRespo);*/
								echo "<div id='t_screen'><p>Galeria de imagens</p></div>";
								echo "<ul>";
								for($i=0;$i<count($li);$i++){ 
								if(trim($li[$i]) != "")
									echo "<li class='gallery'><a  href='".$li[$i]."' rel='clbx' title='".$url.$i."'>
									<img class='gallery_img' src='".$li[$i]."' alt='Imagem' rel='cl' /></a></li>"; 
								}
								echo "</ul>";
								echo "<div style='clear: both;padding-bottom: 35px;'></div>";
							break;
							case 'videos':
								echo "<p class='t_vid'><strong>Vídeos</strong></p>";
								$objRespo = $objSql->selectSql("LINK1_VD_INT_CTG,LINK2_VD_INT_CTG,LINK3_VD_INT_CTG", "TIT_ITN_CTG = '{$url}'", '', '',false);
								//if($objSq->SQLSERVER == TRUE)
									$li = mssql_fetch_row($objRespo);
								/*else
									$li = mysql_fetch_row($objRespo);*/
								if($li[0] != '' || $li[1] != '' || $li[2] != ''){
								if($li[0] != '') $video = $li[0]; else if($li[1] != "") $video = $li[1]; else $video = $li[3]; 
									echo "<iframe width='400' height='315' src='".$video."' frameborder='0' name='frameVid' id='game_vid' allowfullscreen='true'></iframe><div id='l_vid'>";
									
									for($i=0;$i<count($li);$i++){
											if($li[$i] != "")
											echo "<a href='".$li[$i]."' target='frameVid' />Video ".($i + 1)."</a>";
									}
									echo "</div>";
								}else echo "<p>Não existem vídeos para esse jogo.</p>";
								
							break;
							default:
								$objRespo = $objSql->selectSql("PATH_IMG1_DESC_INT_CTG,TXT_ITN_CTG", "TIT_ITN_CTG = '{$url}'", '', '1',false);
								$li =$objSql->fetch($objRespo);
								echo "<p class='img_game'><img src='{$li['PATH_IMG1_DESC_INT_CTG']}' width='420px' height='126px'/></p>";
								echo "<p class='desc_game'>{$li['TXT_ITN_CTG']}</p>";
								
							
						}
						include_once('include/include_sec/sharer.php');
					?>
		</div>
		<div id="menu_box">
			<ul>
				<li class="desc"><a href="<?php echo 'jogos/'.$_GET['categoria'].'/'.$getJogo.'/descricao'; ?>">Descrição</a></li>
				<li class="down"><a href="<?php echo 'jogos/'.$_GET['categoria'].'/'.$getJogo.'/download'; ?>">Download</a></li>
				<li class="img"><a href="<?php echo 'jogos/'.$_GET['categoria'].'/'.$getJogo.'/imagens'; ?>">Imagens</a></li>
				<li class="vid"><a href="<?php echo 'jogos/'.$_GET['categoria'].'/'.$getJogo.'/videos'; ?>">Vídeos</a></li>
			</ul>
		</div>
		<div id="box_down1"></div>

	</div>