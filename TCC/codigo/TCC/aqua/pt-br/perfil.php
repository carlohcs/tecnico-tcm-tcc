	<?php  
		if(basename($_SERVER["PHP_SELF"]) == "perfil.php") header("Location: ./perfil/".$_GET['user']);
		$flaUsSess = false;
		if($obj->exibeArrayDados('nome','usuario') == $_SESSION['sessaoUsuario']['nome']) $flaUsSess = true;	
	?>
				<div id="center">
				
					<!-- Perfil -->
						
					<div id="ini_box_top"></div>
					<div id="ini_box_center">	
						<img src="<?php if($flaUsSess == true) echo $_SESSION['sessaoUsuario']['foto']; else echo $obj->exibeArrayDados('foto','usuario');  ?>" width="114" height="112" id="user_img" alt="Usuário"/>
						
						<div id="bg_username"><p id="user_name"><?php if($flaUsSess == true) echo $_SESSION['sessaoUsuario']['nome']; else echo $obj->exibeArrayDados('nome','usuario');  ?></p></div>
						<div id="awards_status"></div>
						<div id="box_premium">
							<div id="crystal"></div>
							<div id="bar_doubt"></div>
							<div id="doubt_percent"></div>
							<div id="doubt"></div>
							
						</div>
						<div id="border_perfil"></div>
					</div>
								
					<div id="mini_trophy"></div>
					<div id="medal"></div>
						
					<div id="ini_box_down">
						<div id="master"></div>
						<a href="javascript:;" id="btn_reborn" class="efeito_fade"></a>
					</div>
					
					<div id="classif_name">
						<?php
							$obj->defineEntidade('titulo_usuario');
							$objRetorno = $obj->selectSql("DESC_TIT","COD_TIT = '".$obj->exibeArrayDados('titulo','usuario')."'", '', '',false);
							$retorno = $obj->retornaDadosSecund($objRetorno); echo $retorno['DESC_TIT'];
						?>
					</div>
					
					<div id="top2"></div>
					<div id="box_top"></div>
					
					<div id="box_center">
					
						<ul class="perfil_user">
							<li><strong>Grupo:</strong> Membros</li>
							<li><strong>Pontos: </strong><?php echo $obj->exibeArrayDados('pontos','usuario'); ?></li>
							<li><strong>Matérias: </strong><?php echo $obj->exibeArrayDados('numMat','usuario'); ?></li>
							<li><strong>Mais ativo em: </strong>MMORPG</li>
							<li><strong>Cadastrado em: </strong><?php echo $obj->formataData($obj->exibeArrayDados('dtCadastro','usuario')); ?></li>
							<li><strong>Status: </strong><span>Online</span></li>
						</ul>
						<ul class="desc_user">
							<li><?php echo $obj->exibeArrayDados('descricao','usuario'); ?></li>
						</ul>
						
					</div>
					
					<div id="box_down">
					
						<ul class="desc_data">
							<li><?php echo $obj->formataData($obj->exibeArrayDados('dtNascimento','usuario')); ?></li>
							<li>19</li>
							<li>
							<?php
								$obj->defineEntidade('sexo');
								$objRetorno = $obj->selectSql("DESC_SEXO","COD_SEXO = '".$obj->exibeArrayDados('sexo','usuario')."'", '', '',false);
								$retorno = $obj->retornaDadosSecund($objRetorno); echo $retorno['DESC_SEXO'];
							?>
							</li>
							<li>
							<?php 
								$obj->defineEntidade('cidades');
								$objRetorno = $obj->selectSql("DESC_CIDADE","COD_CIDADE = '".$obj->exibeArrayDados('cidade','usuario')."'", '', '',false);
								$retorno = $obj->retornaDadosSecund($objRetorno); echo $retorno['DESC_CIDADE'];
							?>
							</li>
						</ul>
						
						<table class="perfil_classif">
						
							<tr>
								<td><strong>1° Lugar</strong></td>
								<td>18/09</td>
								<td>100</td>
							</tr>
							<tr>
								<td><strong>2° Lugar</strong></td>
								<td>18/05</td>
								<td>70</td>
							</tr>
							<tr>
								<td><strong>3° Lugar</strong></td>
								<td>18/07</td>
								<td>50</td>
							</tr>
						</table>
						
					</div>
					
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
							<div class="nivel_percent1"><div class="bar_percent"><p>20%</p></div></div>
							<div class="nivel_percent2"><div class="bar_percent"><p>30%</p></div></div>
							<div class="nivel_percent3"><div class="bar_percent"><p>50%</p></div></div>
							<div class="nivel_percent4"><div class="bar_percent"><p>70%</p></div></div>
							<div class="nivel_percent5"><div class="bar_percent"><p>100%</p></div></div>
						</div>
						
						<div id="reflect"></div>
						
					</div>
					
				</div>
				<?php $obj->encerraConexaoSql($conSql); ?>