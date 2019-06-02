<?php
class manipulationData extends manageSession
{

	public $dadosPerso;
	//Cadastra usuários
	function cadastraUsuario()
	{
	
		$this->nome = $nome;
		$this->grupo = $grupo;
		$this->email = $email;
		$this->pontos = $nome;
		$this->descricao = $nome;
		
		
		$this->dataCadastro = $dataCadastro;
		$this->dataNascimento = $dataNascimento;
		$this->idade = $idade;
		$this->sexo = $sexo;
		$this->localizacao = $localizacao;
		
		$conSql = parent::conexaoSql();
			
		parent::defineEntidade("usuario");
			
		self::timeZone();
			
		$data = date("Y/m/d");
		
		$horario = date("H:i:s");
			
		$exSql = parent::insertSql("'NULL','{$nome}','{$email}','{$assunto}','{$mensagem}', '{$data}', '{$horario}', 0" , "relative");
			
		if($exSql == true)
		
			return true;
		
		else
		{
				
				$this->erro = mysql_error();
				
				$obj->exibeErros();
				
				return false;
			
		}
		
	}
		
	//Contato
	function contatoUsuario($nome, $email, $assunto, $mensagem)
	{
	
		$dadosContato = array($nome,$email,$assunto,$mensagem);
		
		$validacoes = array("/^[\w ]{5,20}/","/^([\w\-\.\_]){3,50}@([\w\- ]+\.)+([\w\-]{2,3})$/","/^[a-zA-Z]{1}/","/^[a-zA-Z]{5,500}/");
		
		$errosMensagens = array("Insira nome válido.", "Insira e-mail no formato 'usuario@servidor.com'.", "Selecione um assunto.", "Insira mensagem.");
		
		$retornoArray = array();
		
		$cont = 0;
					
		for($i=0;$i<count($dadosContato);$i++)
		{
						
			if(!preg_match($validacoes[$i], $dadosContato[$i]))
			{
				
				$retornoArray['dados'][] = "";
				$retornoArray['mensagem'][] = $errosMensagens[$i];
				$cont++;
				
			}
			
			else
			{
			
				$retornoArray['dados'][] = $dadosContato[$i];
				$retornoArray['mensagem'][] = "";
				
			}
			
		}
		
		if($cont > 0)
		
			return $retornoArray;
		
		else
		{
			
			$conSql = parent::conexaoSql();
			
			parent::defineEntidade("contato1");
			
			self::timeZone();
			
			$data = date("Y/m/d");
			
			$horario = date("H:i");
			
			$exSql = parent::insertSql("'NULL','{$nome}','{$email}','{$assunto}','{$mensagem}', '{$data}', '{$horario}', 0" , "relative");
			
			parent::encerraConexaoSql($conSql);
			
			if($exSql == true)
		
				return true;
		
			else
			{
				
				$this->erro = mysql_error();
				
				$obj->exibeErros();
				
				return false;
			
			}
			
		}
		
	}
	
	function retornaDadosSessaoUsuario($tipo)
	{
	
		$retorno = false;
		$sessAtivada = parent::verificaSessaoUsuario();
		if($sessAtivada == true)
		{
		
			$usuario = $_SESSION["sessaoUsuario"]['login'];
			
			$conSql = parent::conexaoSql();
			
			parent::defineEntidade("usuario");
			
			switch($tipo)
			{
				case "contato":
					$exSql = parent::selectSql("NOM_USU, EMAIL_USU", "LOG_USU = '{$usuario}'", '', '',true);
					if($exSql != false) $retorno = true;
				break;
				case "perfil":
					$exSql = parent::selectSql("*", "LOG_USU = '{$usuario}'", '', '',true);
					if($exSql != false) $retorno = true;
				break;
				
			}
			
			parent::encerraConexaoSql($conSql);
		
			return $retorno;		
			
		}

		return $retorno;
		
	}
		
	//Define hora de zona
	function timeZone()
	{	
		
		date_default_timezone_set('America/Sao_Paulo');
	
	}

	
}
?>