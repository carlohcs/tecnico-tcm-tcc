<?php
class manipulationData extends manageSession
{

	public $dadosPerso;
		
	//Cadastra usuários
	function cadastraUsuario($envPost)
	{

		$conSql = parent::conexaoSql();parent::defineEntidade("usuario");self::timeZone();
		
		$dataCads = date("Y/m/d"); $senha = md5($envPost[4]);
		
		if(parent::SQLSERVER == TRUE)
			$exSql = parent::insertSql("'{$envPost[0]}' ,'{$envPost[1]}','{$envPost[2]}','{$envPost[3]}','{$senha}', '".parent::formataData($envPost[5])."',
			'{$dataCads}','','{$envPost[6]}','','','{$envPost[10]}','{$envPost[11]}','1','{$envPost[7]}','{$envPost[8]}','{$envPost[9]}'",'relative');
		else
			$exSql = parent::insertSql("'null','{$envPost[0]}' ,'{$envPost[1]}','{$envPost[2]}','{$envPost[3]}','{$senha}', '".parent::formataData($envPost[5])."',
			'{$dataCads}','','{$envPost[6]}','','','{$envPost[10]}','{$envPost[11]}','1','{$envPost[7]}','{$envPost[8]}','{$envPost[9]}'",'relative');
		
		if($exSql != false) return true; else return false;
		
	}
	
	//Atualiza o usuário
	function atualizaUsuario($envPost)
	{
				 		
		$conSql = parent::conexaoSql(); parent::defineEntidade("usuario");
		$dtNasc = explode('/',$envPost[4]); $ndt = $dtNasc[2]."/".$dtNasc[1]."/".$dtNasc[0];
		$exSql = parent::updateSql("NOM_USU = '{$envPost[0]}',SOBRE_USU = '{$envPost[1]}',EMAIL_USU = '{$envPost[2]}',SEN_USU = '{$envPost[3]}',DT_NASC_USU = '".$ndt."',DESC_USU = '{$envPost[5]}',
		COD_SEX = '{$envPost[6]}',COD_CIDADE = '{$envPost[7]}',COD_ESTADO = '{$envPost[8]}',FLAG_EMAIL_VIS = '{$envPost[10]}',FLAG_DTNASC_VIS = '{$envPost[11]}'","COD_USU = {$envPost[9]}");
		
		parent::encerraConexaoSql($conSql);
		
		if($exSql != false){
			$_SESSION['sessaoUsuario']['logado'] = true;
			$_SESSION['sessaoUsuario']['email_usuario'] = $envPost[2];
			$_SESSION['sessaoUsuario']['nome'] = $envPost[0];
			$cm = $_SESSION['sessaoUsuario']['nome']." ".$envPost[0];
			return true;
		} else return false;
	
	}
	
	
	//Contato
	function contatoUsuario($nome, $email, $assunto, $mensagem)
	{
	
		$dadosContato = array($nome,$email,$assunto,$mensagem);
		
		$validacoes = array("/^[\w ]{5,20}/","/^([\w\-\.\_]){3,50}@([\w\- ]+\.)+([\w\-]{2,3})$/","/^[0-9]{1}/","/^[\w]{5,500}/");
		
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
			
			parent::defineEntidade("contato");
			
			self::timeZone();
			
			//CONVERT(VARCHAR(8), GETDATE(), 103), CONVERT(VARCHAR(8), GETDATE(), 108)
			
			if(parent::SQLSERVER == true)
				$exSql = parent::insertSql("'{$nome}','{$email}','{$mensagem}', CONVERT(VARCHAR(8), GETDATE(), 103), CONVERT(VARCHAR(8), GETDATE(), 108), '{$assunto}', 0" , "relative");
			else
				$exSql = parent::insertSql("'NULL','{$nome}','{$email}','{$assunto}','{$mensagem}', '{$data}', '{$horario}', 0" , "relative");
			
			parent::encerraConexaoSql($conSql);
			
			if($exSql != false)
		
				return true;
		
			else
			{
				
				$this->erro = "ERRO ao inserir";
				
				$obj->exibeErros();
				
				return false;
			
			}
			
		}
		
	}
	
	//EXLUIR O USUÁRIO
	function excluirUsuario()
	{
		session_start();
		$codUsu = $_SESSION['sessaoUsuario']['codigo'];
			
		$conexaoSql = parent::conexaoSql();
		
		parent::defineEntidade('artigo e, comentario_artigo, comentario_destaque, 
			comentario_noticia, curtir_artigo, ranking_usuario, usuario');
				
		$exSql = parent::deleteSql("COD_USU = '{$codUsu}'");
		
		parent::defineEntidade('sinalizacao_artigo,sinalizacao_destaque, sinalizacao_noticia');
		
		$exSql2 = parent::deleteSql("COD_USU_SINALIZADO = '{$codUsu}' OR COD_USU_SINALIZAR  = '{$codUsu}'");
		
		parent::encerraConexaoSql($conexaoSql);
		return parent::retornaInstrucaoSql();
			//if($exSql != false && $exSql2 != false) return true; else return false;
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