<?php
class manageSession extends sqlInstruction
{
	protected $usuario;
	protected $senha;
	public $dadosPerso;
	
	//Funчуo para logar um usuсrio -> recebe usuсrio e senha por POST
	function logaUsuario($usuario,$senha)
	{	
		//Se existe sessуo, ou seja, se a pessoa estiver logada, n deixa fazer login novamente
		if(!isset($_SESSION["sessaoUsuario"]))
		{
			//retira caracteres especiais do usuario
			$this->usuario = stripslashes($usuario);
			$this->senha = $senha;
			//Define as validaчѕes para usuсrio e senha	
			$validacoes = array("/^([\w._-]){6,10}/","/^([\w]){6,32}/");
					
			//Compara login e verifica se щ vсlido, se nуo for, jс volta para a pсgina dizendo o erro e mostrando o usuсrio
			if(!preg_match($validacoes[0], $this->usuario))
			{
				$enUsu = base64_encode($this->usuario);	
				header("Location: ../index/lgError/login/".$enUsu."");
			}	
			else
			{
				//Compara senha Compara senha e verifica se щ vсlido, se nуo for, jс volta para a pсgina dizendo o erro e mostrando o usuсrio
				if(!preg_match($validacoes[1], $this->senha))
				{
					$enUsu = base64_encode($this->usuario);
					header("Location: http://127.0.0.1:88/TCC/aqua/pt-br/index/lgError/pass/".$enUsu."");
				}
				else
				{
				
					//Verifica se usuсrio e senha estуo no bando de dados
					//$obj = new SqlInstruction;
					$conSql = parent::conexaoSql();
					parent::defineEntidade('usuario');
					
					//Verifica Usuсrio
					$exSql = parent::selectSql("COD_USU,EMAIL_USU,LOG_USU, NOM_USU, FT_USU", "LOG_USU = '{$this->usuario}'", '', '',true);
					
					$nU = parent::exibeArrayDados("nome","usuario");
					$fU = parent::exibeArrayDados("foto","usuario");
					$cdU = parent::exibeArrayDados("codigo","usuario");
					$eU = parent::exibeArrayDados("email","usuario");
					
					if($exSql != false)
					{
					
						//Verifica Senha
						
						$exSql = parent::selectSql("SEN_USU", "LOG_USU = '{$this->usuario}' AND SEN_USU = '{$this->senha}'", '', '',false);
						
						if($exSql != false)
						{
							//Se tudo for vсlido, inicia a sessуo e passa os dados do usuсrio para a sessуo
							session_start();
							$_SESSION['sessaoUsuario']['logado'] = true;
							$_SESSION['sessaoUsuario']['email_usuario'] = $eU;
							$_SESSION['sessaoUsuario']['codigo'] = $cdU;
							$_SESSION['sessaoUsuario']['login'] = $this->usuario;					
							$_SESSION['sessaoUsuario']['nome'] = $nU;
							$_SESSION['sessaoUsuario']['foto'] = $fU;
							
							$respo = true;							
							$pos = strpos($_SERVER['HTTP_REFERER'],'lgError');
							
							if($pos != false) $respo = false;
		
							if($respo == true) return header("Location: {$_SERVER['HTTP_REFERER']}"); else return header("Location: http://127.0.0.1:8080/TCC/aqua/pt-br/index");
						}						
						
						else
						{
							$enUsu = base64_encode($this->usuario);
							header("Location: http://127.0.0.1:88/TCC/aqua/pt-br/index/lgError/pass/".$enUsu."");		
							
						}
					
					}
					
					else
					{
						$enUsu = base64_encode($this->usuario);
						header("Location: http://127.0.0.1:8080/TCC/aqua/pt-br/index/lgError/login/".$enUsu."");		
					
					}
				
				}
			
			}
		
		}
		//Se jс estiver logado, emite aviso
		else
		{
		
			header("Location: ../index/lgError/logt");		
			
		
		}
		
	}
	//Verifica sessуo de usuario
	function verificaSessaoUsuario()
	{	
		
		if(!empty($_SESSION) && $_SESSION["sessaoUsuario"]['logado'] == true)

			return true;
			
		else
			
			return false;
		
	}
	
	//Finaliza sessуo
	function encerraSessaoUsuario()
	{	
		session_start();
		$_SESSION = array();
		session_destroy();
				
		$pageAt = $_SERVER['HTTP_REFERER'];
		
		$ex1  = 'perfil';
		$ex2 = 'artigos';
		$ex3 = 'lgError';
		
		$respo = true;
		
		$pos1 = strpos($pageAt, $ex1); 
		if($pos1 != false) $respo = false;
		
		$pos2 = strpos($pageAt, $ex2); 
		if($pos2 != false) $respo = false;
		
		$pos3 = strpos($pageAt, $ex3); 
		if($pos3 != false) $respo = false;
		
		if($respo == true) return $pageAt; else return 'http://127.0.0.1:8080/TCC/aqua/pt-br/index';
		
	}
}
?>