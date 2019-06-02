<?php if(basename($_SERVER["PHP_SELF"]) == "contato.php") header("Location: ./contato");
		//Retorno de mensagens e preenchimento de campos
		$nomeMen = "";$emailMen = "";$assuntoMen = "";$mensagemMen = ""; $nome = ""; $email = ""; $assunto = "";$mensagem = "";
		//Instância o gerenciamento de sessão e de dados de sessão
		$obj->retornaDadosSessaoUsuario('contato');		
		$nome = $obj->exibeArrayDados('nome','usuario');$email = $obj->exibeArrayDados('email','usuario');
		//Realiza o CONTATO
		if(isset($_POST['sendContact'])){
			$retornoObj = $obj->contatoUsuario($_POST['nameContact'],$_POST['emailContact'],$_POST['selectContact'],$_POST['messageContact']);
			if(!is_array($retornoObj)){ echo "<script>jAlert('<p>Obrigado pelo Contato!</p> Retornaremos em breve.', ' ', function() {
				$.alerts.dialogClass = null;});</script>";
			}else{ $nome = ($retornoObj['dados'][0] !="") ? $retornoObj['dados'][0] : FALSE; $nomeMen = ($retornoObj['mensagem'][0]  !="") ? $retornoObj['mensagem'][0] : FALSE;
				$email = ($retornoObj['dados'][1] !="") ? $retornoObj['dados'][1] : FALSE; $emailMen = ($retornoObj['mensagem'][1] !="") ? $retornoObj['mensagem'][1] : FALSE;
			$assunto = ($retornoObj['dados'][2] !="") ? $retornoObj['dados'][2] : FALSE; $assuntoMen = ($retornoObj['mensagem'][2] !="") ? $retornoObj['mensagem'][2] : FALSE;
			$mensagem = ($retornoObj['dados'][3] !="") ? $retornoObj['dados'][3] : FALSE;$mensagemMen = ($retornoObj['mensagem'][3] !="") ? $retornoObj['mensagem'][3] : FALSE;}
		}?>
				<div id="center">
					<!-- Contato -->
					<div id="box_top"><p id="title_game">Contato</p></div>
					<div id="top2"></div>
					<div id="box_center">
						<form id="frmContact" method="post" action="./contato">
							<fieldset>
								<legend>Todos os campos são obrigatórios</legend>
								<dl>
									<dt><label for="name">Nome completo:</label></dt>
									<dd><input type="text" size="60" maxlength="50" name="nameContact" id="name" value="<?php echo $nome; ?>" /></dd>
									
									<?php if($nomeMen != "") echo "<div id='error_icon'>".$nomeMen."</div>"; ?>
									
									<dt><label for="email">E-mail:</label></dt>
									<dd><input type="text" size="60" maxlength="50" name="emailContact" id="email" value="<?php echo $email; ?>"/></dd>
									
									<?php if($emailMen != "") echo "<div id='error_icon'>".$emailMen."</div>"; ?>
									
									<dt><label for="subject">Assunto:</label></dt>
									<dd><select name="selectContact" id="subject">
										<option value=""></option>
										<option value="d">Dúvidas</option>
										<option value="i">Informações</option>
										<option value="s">Sugestões</option>
										<option value="o">Outros</option>
									</select></dd>
									
									<?php if($assuntoMen != "") echo "<div id='error_icon'>".$assuntoMen."</div>"; ?>
									
									<dt><label for="message">Mensagem:</label></dt>
									<dd><textarea name="messageContact" id="mensagem" rows="5" cols="51"><?php echo $mensagem; ?></textarea><span id="cont"></span></dd>
									
									<?php if($mensagemMen != "") echo "<div id='error_icon'>".$mensagemMen."</div>"; ?>
									
									<dd><input type="submit" name="sendContact" class="send" value="Enviar" /></dd>
								</dl>
							</fieldset>
						</form>
					</div>
					<div id="box_down2"></div>

				</div>