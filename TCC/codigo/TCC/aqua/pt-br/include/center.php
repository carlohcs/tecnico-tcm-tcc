<!-- Banner notícias -->
			<div id="center1">
			<div id="center_cp">
			<?php include_once("server/php.class/manageBannerNews.class.php"); $obj = new manageBannerNews;	$returnData = $obj->retornaBannerNoticias(); ?>
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
		
			<div id="cbanner_detail_left"></div>
			<div id="cbanner_detail_right"></div>
			
			<div id="cbanner_detail_down">
				<div id="btn_cbanner1"></div>
				<div id="btn_cbanner2"></div>
				<div id="btn_cbanner3"></div>
				<div id="btn_cbanner4"></div>
			</div>
			<div id="cbanner_over_down"></div>
			<div id="btn_cbanner"></div>
			<div id="top_main"></div>
			<?php $retornoDados = $objNews->newsEntretenimento();?>
			<div id="bg_main_article">
				<p class="art1">Warhammer: Space Marine</p>
				<p class="art2">Syndicate</p>
				<p class="art3">Resistance 3</p>
				
				<div id="img_art">
					<a href="noticias/<?php echo $retornoDados['links'][0];?>"><img class="art1" src="<?php echo $retornoDados['imagens'][0];?>"/></a>
					<a href="noticias/<?php echo $retornoDados['links'][1];?>"><img class="art2" src="<?php echo $retornoDados['imagens'][1];?>"/></a>
					<a href="noticias/<?php echo $retornoDados['links'][2];?>"><img class="art3" src="<?php echo $retornoDados['imagens'][2];?>"/></a>
				</div>
				
			</div>
			<table>
			  <tr>
				<td>Imagens</td>
				<td>An&aacute;lise</td>
				<td>V&iacute;deos</td>
			  </tr>
			</table>
			
			<div id="bar_list_article">
				<p>Conteúdo Semanal <span>++</span></p>
			</div>
			<?php $retornoDados = $objNews->noticiasTexto(false,0,0,"normal");?>
			<div id="bg_list_article">
				<ul id="bg_list_li">
					<li><span><?php echo $retornoDados['dataNoticia'][0]; ?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][0];?>"><?php echo $retornoDados['noticia'][0];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][1]; ?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][1];?>"><?php echo $retornoDados['noticia'][1];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][2]; ?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][2];?>"><?php echo $retornoDados['noticia'][2];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][3]; ?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][3];?>"><?php echo $retornoDados['noticia'][3];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][4];?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][4];?>"><?php echo $retornoDados['noticia'][4];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][5];?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][5];?>"><?php echo $retornoDados['noticia'][5];?></a></li>
					<li><span><?php echo $retornoDados['dataNoticia'][6];?></span><a href="noticias/<?php echo $retornoDados['linkNoticia'][6];?>#"><?php echo $retornoDados['noticia'][6];?></a></li>
				</ul>
			</div>
			<div id="bg_list_down">
				<a href="javascript:;" id="btn_list_plus"></a>
			</div>
			</div>
			</div>