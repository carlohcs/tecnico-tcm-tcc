<html>
	<head>
		<?php
			class CadastraUser{
				function cadastra(){
					if($_SERVER["REQUEST_METHOD"] == "POST"){
						$nome = isset($_POST['unome']) ? trim($_POST['unome']) : FALSE; 
						$dataNasc = isset($_POST['udtnasc']) ? trim($_POST['udtnasc']) : FALSE; 
						$email = isset($_POST['uemail']) ? trim($_POST['uemail']) : FALSE; 
						$login = isset($_POST['ulogin']) ? trim($_POST['ulogin']) : FALSE; 
						$senha = isset($_POST['usenha1']) ? trim($_POST['usenha1']) : FALSE; 
						if(empty($nome) || empty($dataNasc) || empty($email) || empty($login) || empty($senha)){
							echo "<p>COMPLETE TODOS OS CAMPOS!</p>";
						}else{
							//Monta array com os dados
							$arr = Array(0=>$login, 1=>$senha, 2=>$nome, 3=>$email, 4=>$dataNasc);
							//Associa array com quebras de linha
							$info = "Login:".$arr[0]."\r\nUSenha: ".$arr[1]."\r\nUSNome:".$arr[2]."\r\nUSEEmail:".$arr[3]."\r\nDataNasc:".$arr[4]."\r\n- - - -\r\n";
							//Abre o arquivo no modo de gravação colocando o ponteiro no final do arquivo
							$abreAr = fopen("class/confUser/users.txt", "a+");
							//Insere os dados
							$insere = fwrite($abreAr, $info);
							//Exibe Msg de confirmação
							if($insere) echo "<p>CADASTRO EFETUADO COM SUCESSO!</p>";
							//Fecha arquivo
							fclose($abreAr);
						}
					}	
				}
			}
			$cadaUs = new CadastraUser;
			$cadaUs->cadastra();
		?>
	</head>
	<body>
	<form name="frmCadastro" method="POST" action="" id="frmCadastro">
		<p>Nome <input type="text" maxlength="10" name="unome" /> </p>
		<span id="errno"></span>
		<p>Data de nascimento <input type="text" maxlength="10" name="udtnasc" /></p>
		 <span id="errd"></span>
		<p>Email <input type="text" maxlength="10" name="uemail" /></p>
		 <span id="erre"></span>
		<p>Login <input type="text" maxlength="10" name="ulogin" /></p>
		 <span id="errl"></span>
		<p>Senha <input type="password" maxlength="10" name="usenha1" /></p>
		<p>Repetir Senha <input type="password" maxlength="10" name="usenha2" /></p>
		 <br /><span id="errse"></span>
		<p><input type="submit" name="uok" value="Enviar" /></p>
	</form>
	</body>
</html>