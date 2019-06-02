<?php
//Classe responsável por Instruções Sql
class SqlInstruction
{

	//Váriaveis de escopo
	const SQLSERVER = TRUE;
	protected $sql;
	public $erro;
	public $dadosPerso;
	
	//Função responsável pela conexao com o banco de dados
	function conexaoSql()
	{
		$ph = $_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/2245023265ae4cf87d02c8b6ba991139/35fc0c66599f33b8d8b7483263b3f200.ini";
		if(file_exists($ph))
		
			$dBd = parse_ini_file($ph,true);
			
		else

			$this->erro = "Arquivo *.ini não encontrado"; 
	
		$sgbd = 'MYSQL';
		
		if(self::SQLSERVER == TRUE)
		{	
			$myServer = "CARLOSHENRIQUE";
			$myUser = "sa";
			$myPass = "etecpj";
			$myDB = "joiandd";
			$conSql = mssql_connect($myServer, $myUser, $myPass) or die("Não foi possivel se conectar a $myServer");
			$sqlDb = mssql_select_db($myDB);
			
		}else{
			$conSql = mysql_connect($dBd[$sgbd]['h'],$dBd[$sgbd]['u'],$dBd[$sgbd]['p']) or die(mysql_errno());
			$sqlDb = mysql_select_db($dBd[$sgbd]['d']);
		}
		
		return $conSql;
	
	}
	
	//Função responsável por encerrar a conexão
	function encerraConexaoSql($conSql)
	{

		if(self::SQLSERVER == TRUE)
		
			mssql_close($conSql);
			
		else
		
			mysql_close($conSql);
			
		$conSql = null;
		
	}
	
	//Função responsável por definir entidade de manipulação
	function defineEntidade($entidade)
	{
	
		$this->entidade = $entidade;
	
	}

	//Função responsável por retornar string de query
	function retornaInstrucaoSql()
	{
	
		return $this->sql;
	
	}
	
	//Função responsável por retornar os erros
	function exibeErros()
	{
	
		if($this->erro != "")
			
			echo "Erro em: ".$this->erro;
	
	}
	
	//Função responsável por inserir dados no banco de dados
	function insertSql($instrucao,$tipo)
	{
	
		switch($tipo)
		{
		
			case "relative":
			
				$this->sql = "INSERT INTO {$this->entidade} VALUES ({$instrucao})";
				
			break;
			
			case "full":
			
				$this->sql = "INSERT INTO {$this->entidade} {$instrucao}";
				
			break;
			
			default:
			
				$this->sql = "INSERT INTO {$this->entidade} {$instrucao}";
				
		}
		
		if(self::SQLSERVER == TRUE)
		{
			$exSql = mssql_query($this->sql);
		
			if($exSql)
		
				return true;
			
			else
			{	
				$this->erro = mssql_error();
				return false;
			}
		}
		else
		{
			$exSql = mysql_query($this->sql);
		
			if(mysql_affected_rows())
		
				return true;
			
			else
			{	
				$this->erro = mysql_error();
				return false;
			}
			
		}	
		
	}
	
	//Função responsável por deletar registro em banco de dados
	function deleteSql($condicao)
	{
	
		$this->sql = "DELETE FROM {$this->entidade}";
		
		if($condicao)
		{
		
			$this->sql.= ' WHERE '.$condicao;
										
		}
		
		if(self::SQLSERVER == TRUE)
		{
			$exSql = mssql_query($this->sql);
			if($exSql) return true; else return false;	
		}
		else
		{
			$exSql = mysql_query($this->sql);
			if(mysql_affected_rows()) return true; else return false;	
		}	
			
	}
	
	//Função responsável por selecionar campos no banco de dados
	function selectSql($instr1,$instr2,$instr3,$instr4,$boo)
	{
	
		if(self::SQLSERVER == TRUE)
		{
		
		$this->sql = "SELECT";
		
		if($instr4 != '')
		
			$this->sql .= ' TOP '.$instr4;		
			
		$this->sql.= " {$instr1} FROM {$this->entidade}";
		
		if($instr2 != '')
		
			$this->sql.= ' WHERE '.$instr2;
										
		if($instr3 != '')
		
			$this->sql.= ' ORDER BY '.$instr3;
		
			$exSql = mssql_query($this->sql);

			if($exSql != false)
			{		
				if(mssql_num_rows($exSql) > 0)
				{	
					if($boo == TRUE) $this->dadosPerso = mssql_fetch_assoc($exSql);
					return $exSql;
				}
			}
			else
			
				return false;
		
		}
		else
		{
		
		$this->sql = "SELECT {$instr1} FROM {$this->entidade}";
		
		if($instr2 != '')
		
			$this->sql .= ' WHERE '.$instr2;
										
		if($instr3 != '')
		
			$this->sql .= ' ORDER BY '.$instr3;
			
		if($instr4 != '')
		
			$this->sql .= ' LIMIT '.$instr4;
			$exSql = mysql_query($this->sql);
		
		
			if($exSql != false)
			{		
				if(mysql_num_rows($exSql) > 0)
				{	
					if($boo == TRUE) $this->dadosPerso = mysql_fetch_assoc($exSql);
					return $exSql;
				}
			}
			else
			
				return false;
		}
	}
	
	//Função responsável por atualizar registros no banco de dados
	function updateSql($instr1,$instr2)
	{
	
		$this->sql = "UPDATE {$this->entidade} SET {$instr1} WHERE {$instr2}";
				
		if(self::SQLSERVER == true)
		{
			$exSql = mssql_query($this->sql);
		
			if($exSql)
		
			return true;
		
			else
			{	
				$this->erro = mssql_error();
				return false;
			}
		}
		else
		{
			$exSql = mysql_query($this->sql);
		
			if(mysql_affected_rows())
		
			return true;
		
			else
			{	
				$this->erro = mysql_error();
				return false;
			}
		}	
		
	}
	
	public function exibeArrayDados($dadoRetornar,$secao)
	{
	
		if($secao == "usuario")
		{
			
			switch($dadoRetornar)
			{

				//Entidade Usuario
				case "codigo": $ret = 'COD_USU'; break;
				
				case "nome": $ret = 'NOM_USU'; break;
				
				case "sobrenome": $ret = 'SOBRE_USU'; break;
				
				case "login": $ret = 'LOG_USU'; break;
				
				case "senha": $ret = 'SEN_USU'; break;	
					
				case "email": $ret = 'EMAIL_USU'; break;	
				
				case "dtNascimento": $ret = 'DT_NASC_USU'; break;
				
				case "dtCadastro": $ret = 'DT_CADS_USU'; break;
				
				case "pontos": $ret = 'PTS_USU'; break;
				
				case "flagRenascimento": $ret = 'FLAG_RNSC'; break;

				case "descricao": $ret = 'DESC_USU'; break;
				
				case "flagEmail": $ret = 'FLAG_EMAIL_VIS'; break;
				
				case "flagDtNasc": $ret = 'FLAG_EMAIL_VIS'; break;
					
				case "ativoMa": $ret = 'ATIVO_USU'; break;

				case "foto": $ret = 'FT_USU'; break;		
				
				case "titulo": $ret = 'COD_TIT_USU'; break;

				case "sexo": $ret = 'COD_SEX'; break;

				case "cidade": $ret = 'COD_CIDADE'; break;
				
				case "estado": $ret = 'COD_ESTADO'; break;
				
			}
		
		}else if($secao == "jogos")
		{
			
			switch($dadoRetornar)
			{
				
				case "codigo": $ret = 'COD_ITN_CTG'; break;
				case "titulo": $ret = 'TIT_ITN_CTG'; break;
					
			}	
				
		}else if($secao == "artigo")
		{
			
			switch($dadoRetornar)
			{
				
				case "codigo": $ret = 'COD_ART'; break;
				case "titulo": $ret = 'TIT_ART'; break;
				
			}	
			
		}else if($secao == "noticia")
		{
			
			switch($dadoRetornar)
			{
			
				case "codigo": $ret = 'COD_NOT'; break;
			
				case "titulo": $ret = 'TIT_NOT'; break;
			
				case "texto": $ret = 'TXT_NOT'; break;
			
				case "data": $ret = 'DT_NOT'; break;
			
				case "hora": $ret = 'HR_NOT'; break;
			
				case "imgIni": $ret = 'PATH_IMG_INI_NOT'; break;
			
				case "img1": $ret = 'PATH_IMG1_NOT'; break;
			
				case "img2": $ret = 'PATH_IMG2_NOT'; break;
			
				case "img3": $ret = 'PATH_IMG3_NOT'; break;
				
			}	
			
		}else if($secao == "destaque")
		{
			
			switch($dadoRetornar)
			{
			
				case "titulo": $ret = 'TIT_DEST'; break;	
				case "codigo": $ret = 'COD_DEST'; break;
				
			}

		}else if($secao == "enquete")
		{
			
			switch($dadoRetornar)
			{
			
				//Título
				case "titulo":
			
					$ret = 'TIT_ENQ';
					break;		
					
				//Opções para votar
				case "opcao1":
			
					$ret = 'ITN1_ENQ';
					break;
				
				case "opcao2":
			
					$ret = 'ITN2_ENQ';
					break;	
				
				case "opcao3":
			
					$ret = 'ITN3_ENQ';
					break;
					
				case "opcao4":
			
					$ret = 'ITN4_ENQ';
					break;	
				
				//Valores de cada Opção
				case "valorOp1":
			
					$ret = 'PCT_ITN1_ENQ';
					break;
				
				case "valorOp2":
			
					$ret = 'PCT_ITN2_ENQ';
					break;	
				
				case "valorOp3":
			
					$ret = 'PCT_ITN3_ENQ';
					break;
					
				case "valorOp4":
			
					$ret = 'PCT_ITN4_ENQ';
					break;	
			}
		
		}
		
		return $this->dadosPerso[$ret];
		
	}	
	public function retornaDadosSecund($exSql){
	
		if(self::SQLSERVER == true) 
			$dados = mssql_fetch_assoc($exSql);
		else
			$dados = mysql_fetch_assoc($exSql);
		return $dados;
	}
	
	public function fetch($exSql)
	{
		
		if(self::SQLSERVER == true)
			return mssql_fetch_assoc($exSql);
		else
			return mysql_fetch_assoc($exSql);
	}
	
	public function rows($exSql)
	{
		
		if(self::SQLSERVER == true)
			return mssql_num_rows($exSql);
		else
			return mysql_num_rows($exSql);
	}
	
	public function formataUrl($string,$slug = '-')
	{
		// * @autor Thiago Belem <contato@thiagobelem.net>

		$string = strtolower($string);

		// Código ASCII das vogais

		$ascii['a'] = range(224, 230);

		$ascii['e'] = range(232, 235);

		$ascii['i'] = range(236, 239);

		$ascii['o'] = array_merge(range(242, 246), array(240, 248));

		$ascii['u'] = range(249, 252);

		// Código ASCII dos outros caracteres

		$ascii['b'] = array(223);

		$ascii['c'] = array(231);

		$ascii['d'] = array(208);

		$ascii['n'] = array(241);

		$ascii['y'] = array(253, 255);

 

		foreach ($ascii as $key=>$item) {

			$acentos = '';
	
			foreach ($item AS $codigo) $acentos .= chr($codigo);

			$troca[$key] = '/['.$acentos.']/i';

		}

	   $string = preg_replace(array_values($troca), array_keys($troca), $string);

    // Slug?
	
		if ($slug) {

        // Troca tudo que não for letra ou número por um caractere ($slug)

			$string = preg_replace('/[^a-z0-9]/i', $slug, $string);

			// Tira os caracteres ($slug) repetidos

			$string = preg_replace('/' . $slug . '{2,}/i', $slug, $string);

			$string = trim($string, $slug);

		}
		return $string;
	}
	public function formataUrlSemTraco($string)
	{		
		$retorno = str_replace("-", " ", $string);
		return $retorno;
	}
	public function formataData($string)
	{
		if(strpos($string , "-") === false) $dataAtual = explode("/",$string); else  $dataAtual = explode("-",$string);
		$retorno = $dataAtual[2]."/".$dataAtual[1]."/".$dataAtual[0];	
		return $retorno;
	}	
	public function formataData2casas($string)
	{
		if(strpos($string , "-") === false) $dataAtual = explode("/",$string); else  $dataAtual = explode("-",$string);
		$retorno = $dataAtual[2]."/".$dataAtual[1];	
		return $retorno;
	}	
}
?>