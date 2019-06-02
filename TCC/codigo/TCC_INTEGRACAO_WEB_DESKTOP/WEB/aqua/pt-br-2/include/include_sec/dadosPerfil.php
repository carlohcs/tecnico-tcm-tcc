	<div id="top2"></div>

		<div id="box_top1"></div>

		<div id="box_center">

			<ul class="perfil_user">

				<li><strong>Pontos: </strong><span><?php echo $objSql->exibeArrayDados('pontos','usuario'); ?></span></li>
				<li><strong>Número de Artigos: </strong>
				<?php 
					$objSql->defineEntidade('artigo');$objRetorno = $objSql->selectSql("COD_USU","FLAG_ART_AP = 1 AND COD_USU = '".$objSql->exibeArrayDados('codigo','usuario')."'", '', '',false);
					if($objRetorno != false) echo $objSql->rows($objRetorno); else echo "0"; ?></li>
					<li><strong>Mais ativo em: </strong>MMORPG</li>
					<li><strong>Cadastrado em: </strong><?php echo $objSql->formataData($objSql->exibeArrayDados('dtCadastro','usuario')); ?></li>
					<li><strong>Artigos: </strong>
					<?php if($getUser == $_SESSION['sessaoUsuario']['login']) echo "<a href='meus-artigos/".$_SESSION['sessaoUsuario']['login']."'>Meus Artigos</a>";
					else echo "<a href='artigos/".$getUser."'>Ver todos</a>"; ?>
					<li><strong>Status: </strong><span>Online</span></li>

			</ul>

			<ul class="desc_user">
				<li><?php echo wordwrap($objSql->exibeArrayDados('descricao','usuario'), 30, "<br />"); ?></li>
			</ul>

		</div>

					

					<div id="box_down">
						
						<?php
						$usuario = ($getUser == $_SESSION['sessaoUsuario']['login']) ? $_SESSION['sessaoUsuario']['codigo'] : $objSql->exibeArrayDados('codigo','usuario');
						$resp = $objRanking->exibePosicaoUsuarioRanking($usuario);
						
						if($resp != false)
						{
						?>
						<table class="perfil_classif">
							<tr>
								<td><strong><?php echo $resp['posicoes'][0]; ?>° Lugar</strong></td>
								<td><?php echo $objSql->formataData2casas($resp['datas'][0]); ?></td>
								<td><?php echo $resp['ptsUsuario'][0]; ?></td>
							</tr>
							<tr>
								<td><strong><?php echo $resp['posicoes'][1]; ?>° Lugar</strong></td>
								<td><?php echo $objSql->formataData2casas($resp['datas'][1]); ?></td>
								<td><?php echo $resp['ptsUsuario'][1]; ?></td>
							</tr>
							<tr>
								<td><strong><?php echo $resp['posicoes'][2]; ?>° Lugar</strong></td>
								<td><?php echo $objSql->formataData2casas($resp['datas'][2]); ?></td>
								<td><?php echo $resp['ptsUsuario'][2]; ?></td>
							</tr>
						</table>
						<?php
							}
							else
							{
						?>
								<table class="perfil_classif">
							<tr>
								<td>---</td>
								<td>---</td>
								<td>---</td>
							</tr>
							<tr>
								<td>---</td>
								<td>---</td>
								<td>---</td>
							</tr>
							<tr>
								<td>---</td>
								<td>---</td>
								<td>---</td>
							</tr>
						</table>
						<?php
							}
						?>

						<ul class="desc_data">
							<?php if($getUser == $_SESSION['sessaoUsuario']['login'] || $objSql->exibeArrayDados('flagDtNasc','usuario') == 1) echo "<li>{$objSql->formataData($objSql->exibeArrayDados('dtNascimento','usuario'))}</li>";
							else echo "<li>- - -</li>";
							$anos = explode("-",$objSql->exibeArrayDados('dtNascimento','usuario'));
							echo "<li>".(2011 - $anos[0])."</li>";
							?>
							<li>
							<?php
								$objSql->defineEntidade('sexo');
								$objRetorno = $objSql->selectSql("DESC_SEX","COD_SEX = '".$objSql->exibeArrayDados('sexo','usuario')."'", '', '',false);
								$retorno = $objSql->retornaDadosSecund($objRetorno); echo $retorno['DESC_SEX'];
							?>
							</li>
							<li>
							<?php 
								$objSql->defineEntidade('estados');
								$objRetorno = $objSql->selectSql("DESC_ESTADO","COD_ESTADO = '".$objSql->exibeArrayDados('estado','usuario')."'", '', '',false);
								$retorno = $objSql->retornaDadosSecund($objRetorno); echo $retorno['DESC_ESTADO'];
							?>
							</li>

						</ul>

					</div>