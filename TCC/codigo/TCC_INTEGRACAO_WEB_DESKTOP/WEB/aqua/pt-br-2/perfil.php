	<?php  
	
		if(basename($_SERVER["PHP_SELF"]) == "perfil.php") header("Location: ./perfil/".$_GET['user']);
		$flaUsSess = false;
		if($objSql->exibeArrayDados('nome','usuario') == $_SESSION['sessaoUsuario']['nome']) $flaUsSess = true;	
		
		
		//VERIFICA SE O USUÁRIO JÁ POSSUI FLAG DE RENASCIMENTO
		$permiRenasc = ($objSql->exibeArrayDados('flagRenascimento','usuario') == 0 && $objSql->exibeArrayDados('pontos','usuario') >= 850) ? 'true' : 'false';
			
		if($permiRenasc == 'true')
		{
			//BUSCA PONTOS DE ARTIGO MAIOR OU IGUAL A 50
			$objSql->defineEntidade('artigo');
			$pontosArtigo = $objSql->selectSql('PTS_ART', "COD_USU = {$_SESSION['sessaoUsuario']['codigo']} AND PTS_ART >=50", '', '',false);
			if($pontosArtigo != false) $permiRenasc = 'true';
		}

	?>
	<div id="center">

					<!-- Perfil -->

					<div id="ini_box_top"></div>

					<div id="ini_box_center">	
						<?php if($getUser == $_SESSION['sessaoUsuario']['login']) echo '<p id="change_img"><a href="javascript:;" id="change_img_link">Trocar imagem</a></p>'; ?>
						<img src="<?php if($flaUsSess == true){ $ft = ($_SESSION['sessaoUsuario']['foto'] != "") ? $_SESSION['sessaoUsuario']['foto'] : 'img/login/user_default2.png'; echo $ft; }else{
						$ft = ($objSql->exibeArrayDados('foto','usuario') != "") ? $objSql->exibeArrayDados('foto','usuario')  : 'img/login/user_default.png'; echo $ft; }?>" width="114" height="112" id="user_img" alt="Usuário"/>
					

						<div id="bg_username">
							<?php
								if($getUser == $_SESSION['sessaoUsuario']['login'] || $objSql->exibeArrayDados('flagEmail','usuario') == 1)
								echo '<ul id="user_name" style="margin-top:0">';
								else echo '<ul id="user_name" style="margin-top:9px">';
								echo "<li>{$objSql->exibeArrayDados('nome','usuario')} {$objSql->exibeArrayDados('sobrenome','usuario')}</li>";
								if($getUser == $_SESSION['sessaoUsuario']['login'] || $objSql->exibeArrayDados('flagEmail','usuario') == 1)
								echo "<li>{$objSql->exibeArrayDados('email','usuario')}</li>";
								echo "</ul>";
							?>
						</div>
						
						<div id="awards_status"></div>

						<div id="box_premium">
							
							<div id="crystal" style="display:<?php if($objSql->exibeArrayDados('flagRenascimento','usuario') == 1) echo 'block'; ?>;"></div>

							<div id="bar_doubt" style="display:<?php if($objSql->exibeArrayDados('flagRenascimento','usuario') == 1) echo 'none'; ?>;"></div>

							<div id="doubt_percent" style="display:<?php if($objSql->exibeArrayDados('flagRenascimento','usuario') == 1) echo 'none'; ?>;"></div>

							<div id="doubt" style="display:<?php if($objSql->exibeArrayDados('flagRenascimento','usuario') == 1) echo 'none'; ?>;"></div>

							

						</div>

						<div id="border_perfil"></div>

					</div>

					<div id="mini_trophy"></div>

					<div id="medal"></div>

					<div id="ini_box_down">

						<div id="master"></div>

						<?php if($getUser == $_SESSION['sessaoUsuario']['login']){ ?> <a href="javascript:;" id="btn_reborn" class="efeito_fade"></a> <?php } ?>

					</div>

					<div id="classif_name">
						<?php
							$objSql->defineEntidade('titulo_usuario');
							$objRetorno = $objSql->selectSql("DESC_TIT","COD_TIT = '".$objSql->exibeArrayDados('titulo','usuario')."'", '', '',false);
							$retorno = $objSql->retornaDadosSecund($objRetorno); echo $retorno['DESC_TIT'];
						?>
					</div>

					<?php 	switch($getEditPerf){case 'true':include_once('include/include_sec/editarDadosPerfil.php');break;
							default:include_once('include/include_sec/dadosPerfil.php');}?>
					
					<div id="box_trophy">

						<div id="trophy01"></div>

						<div id="trophy02"></div>

						<div id="trophy03"></div>

						<div id="trophy04"></div>

						<div id="trophy05"></div>

						<div id="bar_nivel01"></div>

						<div id="bar_nivel02"></div>

						<div id="bar_nivel03"></div>

						<div id="bar_nivel04"></div>

						<div id="bar_nivel05"></div>

						

						<div id="nivel_percent">

							<div class="nivel_percent1"><div class="bar_percent"><p></p></div></div>

							<div class="nivel_percent2"><div class="bar_percent"><p></p></div></div>

							<div class="nivel_percent3"><div class="bar_percent"><p></p></div></div>

							<div class="nivel_percent4"><div class="bar_percent"><p></p></div></div>

							<div class="nivel_percent5"><div class="bar_percent"><p></p></div></div>

						</div>

						

						<div id="reflect"></div>

						

					</div>

					<input type="hidden" value="<?php echo $permiRenasc; ?>" id="flagCristal" />
				</div>