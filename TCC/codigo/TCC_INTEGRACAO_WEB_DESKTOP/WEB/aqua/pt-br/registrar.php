<?php
//if(basename($_SERVER["PHP_SELF"]) == "registrar.php") header("Location: ./index");

if($_SERVER["REQUEST_METHOD"] == "POST" && isset($_POST['sendCadas']))
{
	$emChk = isset($_POST['chkEmail']) ? "1" : "0";
	$dtChk = isset($_POST['chkDtNasc']) ? "1" : "0";
	$envPost = array(
		$_POST['nom_usu'],$_POST['sobrenom_usu'],$_POST['email_usu'],$_POST['loginUsu'],$_POST['senha_usu'],
		$_POST['dt_usu'],$_POST['messageRegister'],$_POST['sx_usu'],$_POST['cid_usu'],
		$_POST['estado_usu'],$emChk,$dtChk);
	
	$obj = new manipulationData();
	$insere = $obj->cadastraUsuario($envPost);
	if($insere != false) echo '<script>jAlert("<p>Registro efetuado com sucesso!</p>", " ", "");</script>'; 
	else echo '<script>jAlert("<p>Dados inv�lidos!</p>", " ", "");</script>';

}	
?>
	<div id="center">
		<div id="box_top"><p id="title_game">Registro</p></div>
		<div id="top2"></div>
		<div id="box_center">
			<form id="frmRegister"  class="frmData" method="POST" action="./registrar">
				<fieldset>
					<dl>
						<legend>Todos os campos s�o obrigat�rios</legend>
						<dt><label for="name">Nome:</dt>
						<dd><input type="text" name="nom_usu" size="60" maxlength="10" id="name" /></dd>
						<dd>M�ximo de 10 caracteres</dd>
						
						<dt><label for="name">Sobrenome:</dt>
						<dd><input type="text" name="sobrenom_usu" size="60" maxlength="20" id="last_name" /></dd>
						<dd>M�ximo de 20 caracteress</dd>
						
						<dt><label for="email">Email:</dt>
						<dd><input type="text" name="email_usu" maxlength="50"  id="email" size="60"/></dd>
						<dd>M�ximo de 50 caracteres</dd>
						
						<dt class="chkReg"><label for="chkEmail"><input type="checkbox" name="chkEmail"/><span>E-mail vis�vel a outros usu�rios</span></label></dt>
						
						<dt><label for="login">Login:</dt>
						<dd><input type="text" name="loginUsu" maxlength="12"  id="login" size="60"/></dd>
						<dd>M�nimo de 6 e m�ximo de 12 caracteres</dd>
						
						<dt><label for="senha">Senha:</dt>
						<dd><input type="password" name="senha_usu" maxlength="12"  id="senha" size="60"/></dd>
						<dd>M�nimo de 6 e m�ximo de 12 caracteres</dd>
						
						<dt><label for="senhaConf">Confirme senha:</dt>
						<dd><input type="password" name="senha_usu_conf" maxlength="12"  id="senhaConf" size="60"/></dd>
						
						<dt><label for="dataNasc">Data de Nascimento:</dt>
						
						<dd><input type="text" name="dt_usu"maxlength="10" id="dataNasc"/></dd>
						<dd>Formato: dd/mm/aaaa</dd>
						
						<dt class="chkReg"><label for="chkDtNasc"><input type="checkbox" name="chkDtNasc"/><span>Data de Nascimento vis�vel a outros usu�rios</span></label></dt>
												
						<dt><label for="sexo">Sexo:</label></dt>
						<dd><select name="sx_usu" id="sexo">
							<option value="0">--Selecione sexo--</option>
							<option value="1">Masculino</option>
							<option value="2">Feminino</option>
						</select></dd>
						
					
						<dt><label for="slcEst">Estado:</label></dt>
						<dd>
							<select name="estado_usu" id="slcEst">
								<option value="0">--Selecione estado--</option>
									<?php include_once('server/php.class/manageEstCid.class.php'); $obj= new manageEstadoCidade; echo $obj->listaEstados('slc'); ?>
							</select>
						</dd>
						
						<dt><label for="slcCid">Cidade:</label></dt>	
						<dd><select id='slcCid' name='cid_usu'><option value="0">--Selecione estado--</option></select></dd>
						
						<dt><label for="message">Descri��o:</label></dt>
						<dd><textarea name="messageRegister" id="message" maxlength="140"></textarea><span id="cont"></span></dd>
						
						</textarea><span id="cont"></span></dd>
						<dd id="chkTerm"><span id="term_use">Li e aceito os<a href="termos-de-uso" target="_blank"> termos</a> de uso.</span><input type="checkbox" name="chkTermUse" id="chkTermUseI" value="terOk" /></dd>

						<dd><input type="submit" name="sendCadas" class="send" value="Enviar" /></dd>
					</dl>
				</fieldset>	
			</form>			
		</div>
		<div id="box_down2"></div>
	</div>