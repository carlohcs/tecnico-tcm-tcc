<!-- Banner notícias -->
			<div id="center1">
			<div id="center_cp">
			
			<?php $returnData = $objPublic->retornaPublicidadeTop(); ?>
			
			<div id="bg_cbanner">
				<ul id="b_ul">
				<?php 
					for($i=0;$i<4;$i++)
						echo "<li><a href='http://{$returnData['links'][$i]}' target='_blank'><img src='{$returnData['caminhoImg'][$i]}' alt='BannerPublicidade' /></a>
						<div class='fundo'><p><a href='http://{$returnData['links'][$i]}' title='Publicidade ".($i + 1)."' target='_blank'>{$returnData['descricao'][$i]}</a></p></div></li>";
				?>
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
			<?php $retornoDados = $objNews->newsDestaque();?>
			<div id="bg_main_article">
				<p class="art1"><?php echo $retornoDados['titulos'][2]; ?></p>
				<p class="art2"><?php echo $retornoDados['titulos'][1]; ?></p>
				<p class="art3"><?php echo $retornoDados['titulos'][0]; ?></p>
				
					<div id="img_art">
					<a href="<?php echo 'destaques/'.$retornoDados['links'][2];?>"><img class="art1" src="img/articles/img_ini/<?php echo $retornoDados['imagens'][2];?>"/></a>
					<a href="<?php echo 'destaques/'.$retornoDados['links'][1];?>"><img class="art2" src="img/articles/img_ini/<?php echo $retornoDados['imagens'][1];?>"/></a>
					<a href="<?php echo 'destaques/'.$retornoDados['links'][0];?>"><img class="art3" src="img/articles/img_ini/<?php echo $retornoDados['imagens'][0];?>"/></a>
				</div>

			</div>
			<table class="destaque">
			  <tr>
				<td>An&aacute;lise</td>
				<td>Imagens</td>
				<td>V&iacute;deos</td>
			  </tr>
			</table>
			
			<div id="bar_list_article">
				<p>Conteúdo Semanal <span>++</span></p>
			</div>
			<?php $retornoDados = $objNews->noticiasTexto(false,0,0,"normal");?>
			<div id="bg_list_article">
				<ul id="bg_list_li">
				<?php for($i=0;$i<7;$i++)echo "<li><span>{$retornoDados['dataNoticia'][$i]}</span><a href='noticias/{$retornoDados['linkNoticia'][$i]}'>{$retornoDados['noticia'][$i]}</a></li>";?>
				</ul>
			</div>
			<div id="bg_list_down">
				<a href="javascript:;" id="btn_list_plus"></a>
			</div>
			</div>
			</div>