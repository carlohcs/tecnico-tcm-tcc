	<?php echo "<script>window.onload= function(){document.title = '".$obj->exibeArrayDados('titulo','noticia')." - Notícias - JOI&D'};</script>"; ?>
	<div id="center">
		<!-- Notícias -->
		<div id="box_top"><p id="title_game"><?php echo $obj->exibeArrayDados('titulo','noticia'); ?></p></div>
		<div id="top2"></div>
		<div id="box_center">
				<img src="<?php echo $obj->exibeArrayDados('imgIni','noticia'); ?>" id="imgIni" width="300px" height="200px"/>
				<p><?php echo $obj->exibeArrayDados('texto','noticia'); ?></p>
				<ul id="sharer_btn">
					<li class="cp1">Compartilhe: </li>
					<li class="cp2"><a href="https://twitter.com/share" class="twitter-share-button" data-count="horizontal" data-via="JOI&D">Tweet</a></li>
					<li class="cp3"><div id="fb-root"></div><div class="fb-like" data-href="www.joi&amp;d.com.br" data-send="false" data-layout="button_count" data-width="225" data-show-faces="false" data-action="recommend"></div></li>
					<li class="cp4"><g:plusone></g:plusone></li>
				</ul>
		</div>	
		<div id="box_down2"></div>

		
	</div>	