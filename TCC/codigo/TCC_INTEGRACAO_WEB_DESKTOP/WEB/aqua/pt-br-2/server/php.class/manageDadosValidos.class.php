<?php
	session_start();
		include_once('sqlInstruction.class.php');
	
	class manageDadosValidos extends sqlInstruction{

		function buscaVal($dt,$dc){
	
			$conSql = parent::conexaoSql();
			
			parent::defineEntidade("usuario");
	
			switch($dc)
			{
				case "login":
					
					
					$exSql = parent::selectSql("LOG_USU", "LOG_USU = '{$dt}'", '', '',false);
					
					if($exSql == false) return 'true'; else return 'false';
					
				break;
				case "email":
					
					$exSql = parent::selectSql("EMAIL_USU", "EMAIL_USU = '{$dt}'", '', '',false);
					
					if($exSql == false) return 'true'; return 'false';
					
				break;
				default:
					$retorno = true;
			}
			
			parent::encerraConexaoSql($conSql);
			
		}
		
	}
		if(isset($_GET['loginUsu'])) $dt = $_GET['loginUsu'];
		if(isset($_GET['email_usu'])) $dt = $_GET['email_usu'];
		$dc = isset($_GET['dc']) ? $_GET['dc'] : FALSE;
		if($dt && $dc)
		{
			if(isset($_SESSION['sessaoUsuario']['email_usuario']) && $_SESSION['sessaoUsuario']['email_usuario'] == $dt)
			{
				echo 'true';
			}else{
				$obj = new manageDadosValidos;
				echo $obj->buscaVal($dt,$dc);
			}	
		}
?>