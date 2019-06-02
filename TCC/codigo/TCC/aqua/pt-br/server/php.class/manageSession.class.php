<?php
class manageSession extends sqlInstruction
{
	protected $usuario;
	protected $senha;
	public $dadosPerso;
	
	//Funчуo para logar um usuсrio
	function logaUsuario($usuario,$senha)
	{	
	
		if(!isset($_SESSION["sessaoUsuario"]))
		{
			
			$this->usuario = stripslashes($usuario);
			$this->senha = $senha;
				
			$validacoes = array("/^([\w._-]){6,10}/","/^([\w]){6,32}/");
					
			//Compara login
			if(!preg_match($validacoes[0], $this->usuario))
			{
				$enUsu = base64_encode($this->usuario);	
				header("Location: ../index/lgError/login/".$enUsu."");
			}	
			else
			{
				//Compara senha
				if(!preg_match($validacoes[1], $this->senha))
				{
					$enUsu = base64_encode($this->usuario);
					header("Location: ../index/lgError/pass/".$enUsu."");
				}
				else
				{
				
					//Verifica se usuсrio e senha estуo no bando de dados
					//$obj = new SqlInstruction;
					$conSql = parent::conexaoSql();
					parent::defineEntidade('usuario');
					
					//Verifica Usuсrio
					$exSql = parent::selectSql("LOG_USU, NOM_USU, FT_USU", "LOG_USU = '{$this->usuario}'", '', '',true);
					
					$nU = parent::exibeArrayDados("nome","usuario");
					$fU = parent::exibeArrayDados("foto","usuario");
					
					if($exSql != false)
					{
					
						//Verifica Senha
						$exSql = parent::selectSql("SEN_USU", "LOG_USU = '{$this->usuario}' AND SEN_USU = '{$this->senha}'", '', '',false);
						
						if($exSql != false)
						{
							session_start();
							$_SESSION['sessaoUsuario']['logado'] = true;
							$_SESSION['sessaoUsuario']['login'] = $this->usuario;					
							$_SESSION['sessaoUsuario']['nome'] = $nU;
							$_SESSION['sessaoUsuario']['foto'] = $fU;	
							header("Location: ../index");
						
						}						
						
						else
						{
							$enUsu = base64_encode($this->usuario);
							header("Location: ../index/lgError/pass/".$enUsu."");		
							
						}
					
					}
					
					else
					{
						$enUsu = base64_encode($this->usuario);
						header("Location: ../index/lgError/login/".$enUsu."");		
					
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
		return header("Location: index");
		
	}
}
?>