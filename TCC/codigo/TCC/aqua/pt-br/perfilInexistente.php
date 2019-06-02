	<?php echo '<script>document.getElementById("perUser").href= "css/center.css";</script>';?>
	<div id="center">
			<!-- Perfil Inexistente -->
		<div id="box_top"><p id="title_game">Perfil Não Encontrado</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<p>Desculpe, o usuário "<?php echo $getUser;?>" não existe.</p>	
		</div>
		<div id="box_down2"></div>
	</div>
	<?php $obj->encerraConexaoSql($conSql); ?>