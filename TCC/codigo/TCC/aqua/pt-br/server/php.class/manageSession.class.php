<?php
class manageSession extends sqlInstruction
{
	protected $usuario;
	protected $senha;
	public $dadosPerso;
	
	//Fun��o para logar um usu�rio
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
				
					//Verifica se usu�rio e senha est�o no bando de dados
					//$obj = new SqlInstruction;
					$conSql = parent::conexaoSql();
					parent::defineEntidade('usuario');
					
					//Verifica Usu�rio
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
		//Se j� estiver logado, emite aviso
		else
		{
		
			header("Location: ../index/lgError/logt");		
			
		
		}
		
	}
	//Verifica sess�o de usuario
	function verificaSessaoUsuario()
	{	
		
		if(!empty($_SESSION) && $_SESSION["sessaoUsuario"]['logado'] == true)

			return true;
			
		else
			
			return false;
		
	}
	
	//Finaliza sess�o
	function encerraSessaoUsuario()
	{	
		session_start();
		$_SESSION = array();
		session_destroy();
		return header("Location: index");
		
	}
}
?>