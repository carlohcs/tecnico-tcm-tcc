	<?php
	$flagCaOk = false;
	if(isset($_POST['sendAtu']))
	{

		$senha = (isset($_POST['senha_usu']) && $_POST['senha_usu'] != 'joiandd') ? md5($_POST['senha_usu']) : $objSql->exibeArrayDados('senha','usuario');
		$cidade = (isset($_POST['cid_usu']) && $_POST['cid_usu'] != $objSql->exibeArrayDados('cidade','usuario')) ? $_POST['cid_usu'] : $objSql->exibeArrayDados('cidade','usuario');
		
		$nome = isset($_POST['nom_usu']) ? $_POST['nom_usu'] : $objSql->exibeArrayDados('nome','usuario');
		
		$sobre = isset($_POST['sobrenom_usu']) ? $_POST['sobrenom_usu'] : $objSql->exibeArrayDados('sobrenome','usuario');
		
		$email = isset($_POST['email_usu']) ? $_POST['email_usu'] : $objSql->exibeArrayDados('email','usuario');
		
		$dtNasc = isset($_POST['dt_usu']) ? $_POST['dt_usu'] : $objSql->exibeArrayDados('dtNascimento','usuario');
		
		$desc = isset($_POST['messageRegister']) ? $_POST['messageRegister'] : $objSql->exibeArrayDados('descricao','usuario');
		
		$sx = 	isset($_POST['sx_usu']) ? $_POST['sx_usu'] : $objSql->exibeArrayDados('sexo','usuario');
		
		$estado = isset($_POST['estado_usu']) ? $_POST['estado_usu'] : $objSql->exibeArrayDados('estado','usuario');
		
		$checkEmail = isset($_POST['checkEmail']) ? '1' : '0';$checkDtNasc = isset($_POST['checkDtNasc']) ? '1' : '0';
		
		$envPost = array($nome,$sobre,$email,$senha,$dtNasc,$desc,$sx,$cidade,$estado,$_SESSION['sessaoUsuario']['codigo'],$checkEmail,$checkDtNasc);
	
		$insere = $objData->atualizaUsuario($envPost);
		if($insere == false){ echo '<script>jAlert("<p>Desculpe,falha no servidor.Tente novamente!</p>", " ", "");</script>'; $flagCaOk = false;}
		else{$flagCaOk = true; }//echo '<script>window.location.reload(true);</script>'; }
	}	
		
		if($flagCaOk == true) echo '<script>jAlert("<p>Dados alterados com sucesso!</p>", " ", function(){});</script>';
	?>
	<div id="top2"></div>

		<div id="box_top2"></div>
		<div id="box_data_user">
				
					<form name="frmUpdDataUser"  id="frmUpdDataUser" class="frmData" method="POST" action="perfil-editar/<?php echo  $objSql->exibeArrayDados('login','usuario');?>">

				<fieldset>
					<dl>
						<legend>Todos os campos são obrigatórios</legend>
						<dt><label for="nome">Nome:</label></dt>
						<dd><input type="text" name="nom_usu" size="60" maxlength="10" id="nome" value="<?php echo $objSql->exibeArrayDados('nome','usuario'); ?>" /></dd>
						<dd>Máximo de 10 caracteres</dd>
						
						<dt><label for="sobrenom">Sobrenome:</label></dt>
						<dd><input type="text" name="sobrenom_usu" size="60" maxlength="20" id="sobrename" value="<?php echo $objSql->exibeArrayDados('sobrenome','usuario'); ?>" /></dd>
						<dd>Máximo de 20 caracteress</dd>
						
						<dt><label for="email">Email:</label></dt>
						<dd><input type="text" name="email_usu" maxlength="25"  id="email" size="60" value="<?php echo $objSql->exibeArrayDados('email','usuario'); ?>" /></dd>
						<dd>Formato:exemplo@servidor.com</dd>
						
						<dt class="chkReg"><label for="chkEmail"><input type="checkbox" name="chkEmail" style="position:absolute;left:482px" <?php if($objSql->exibeArrayDados('flagEmail','usuario') == 1) echo "checked='cheked'"; ?>/><span>E-mail visível a outros usuários:</span></label></dt>
						
						<dt><label for="senha">Senha:</label></dt>
						<dd><input type="password" name="senha_usu" maxlength="12"  id="senha" size="60" value="joiandd"/></dd>
						<dd>Mínimo de 6 e máximo de 12 caracteres</dd>
						
						<dt><label for="senhaConf">Confirme senha:</label></dt>
						<dd><input type="password" name="senha_usu_conf" maxlength="12"  id="senhaConf" size="60"  value="joiandd" /></dd>
						
						<dt><label for="dataNasc">Data de Nascimento:</label></dt>
						<dd><input type="text" name="dt_usu"maxlength="10" id="dataNasc" value="<?php echo $objSql->formataData($objSql->exibeArrayDados('dtNascimento','usuario')); ?>"/></dd>
						<dd>Formato: dd/mm/aaaa</dd>
						
						<dt><label for="chkDtNasc">Data de Nascimento visível a outros usuários: </label><input type="checkbox" name="chkDtNasc" style="position:absolute;left:572px" <?php if($objSql->exibeArrayDados('flagEmail','usuario') == 1) echo "checked='cheked'"; ?>/></dt>
						
						<dt><label for="sexo">Sexo:</label></dt>
						<dd><select name="sx_usu" id="sexo">
							<option value="0">--Selecione sexo--</option>
							<?php $fm = ''; $ms = ''; if($objSql->exibeArrayDados('sexo','usuario') == '2') $fm = 'selected'; else $ms = 'selected'; ?>
							<option value="2" selected="<?php echo $fm; ?>">Feminino</option>
							<option value="1" selected="<?php echo $ms; ?>">Masculino</option>
						</select></dd>
						
						<?php	echo "<input name='hd1' type='hidden' id='codEstSl' value='{$objSql->exibeArrayDados('estado','usuario')}' />"; echo "<input name='hd2' type='hidden' id='codCidSl' value='{$objSql->exibeArrayDados('cidade','usuario')}' />";	?>		
						
						<?php include_once('server/php.class/manageEstCid.class.php'); $objSqlEst = new manageEstadoCidade;  ?>
						<dt><label for="slcEst">Estado:</label></dt>
						<dd>
							<select name="estado_usu" id="slcEst">
									<?php echo $objSqlEst->listaEstados('slc');?>
							</select>
						</dd>
						
						<dt><label for="slcCid">Cidade:</label></dt>	
						<dd><select id='slcCid' name='cid_usu'></select></dd>

						<dt><label for="message">Descrição:</label></dt>
						<dd><textarea name="messageRegister" id="message" maxlength="140"><?php echo $objSql->exibeArrayDados('descricao','usuario'); ?></textarea><span id="cont"></span></dd>
						
						</textarea><span id="cont"></span></dd>
					
						<dd><input type="submit" name="sendAtu" class="send" value="Salvar" /></dd>
					</dl>
				</fieldset>	
			
					
		</form>
</div>
<div id="box_down2"></div>	