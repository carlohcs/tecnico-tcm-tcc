<?php
//Classe respons�vel por Instru��es Sql
class SqlInstruction
{

	//V�riaveis de escopo
	protected $sql;
	public $erro;
	public $dadosPerso;
	
	//Fun��o respons�vel pela conexao com o banco de dados
	function conexaoSql()
	{
		$ph = $_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/2245023265ae4cf87d02c8b6ba991139/35fc0c66599f33b8d8b7483263b3f200.ini";
		if(file_exists($ph))
		
			$dBd = parse_ini_file($ph);
			
		else

			$this->erro = "Arquivo *.ini n�o encontrado"; 

		// $conSql = mysql_connect($dBd['h'],base64_decode($dBd['u']),$dBd['p']) or die(mysql_errno());
		$conSql = mysql_connect($dBd['h'], $dBd['u'], $dBd['p']) or die(mysql_errno());
		
		$sqlDb = mysql_select_db(base64_decode($dBd['d']));
		
		return $conSql;
	
	}
	
	//Fun��o respons�vel por encerrar a conex�o
	function encerraConexaoSql($conSql)
	{

		mysql_close($conSql);
		$conSql = null;
		
	}
	
	//Fun��o respons�vel por definir entidade de manipula��o
	function defineEntidade($entidade)
	{
	
		$this->entidade = $entidade;
	
	}

	//Fun��o respons�vel por retornar string de query
	function retornaInstrucaoSql()
	{
	
		return $this->sql;
	
	}
	
	//Fun��o respons�vel por retornar os erros
	function exibeErros()
	{
	
		if($this->erro != "")
			
			echo "Erro em: ".$this->erro;
	
	}
	
	//Fun��o respons�vel por inserir dados no banco de dados
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
		
		$exSql = mysql_query($this->sql);
		
		if(mysql_affected_rows())
		
			return true;
			
		else
		{	
			$this->erro = mysql_error();
			return false;
		}
		
	}
	
	//Fun��o respons�vel por deletar registro em banco de dados
	function deleteSql($condicao)
	{
	
		$this->sql = "DELETE FROM {$this->entidade}";
		
		if($condicao)
		{
		
			$this->sql .= ' WHERE '.$condicao;
										
		}
		
		$exSql = mysql_query($this->sql);
		
		if(mysql_affected_rows())
		
			return true;
			
		else

			return false;
			
	}
	
	//Fun��o respons�vel por selecionar campos no banco de dados
	function selectSql($instr1,$instr2,$instr3,$instr4,$boo)
	{
	
		$this->sql = "SELECT {$instr1} FROM {$this->entidade}";
		
		if($instr2 != '')
		
			$this->sql .= ' WHERE '.$instr2;
										
		if($instr3 != '')
		
			$this->sql .= ' ORDER BY '.$instr3;
			
		if($instr4 != '')
		
			$this->sql .= ' LIMIT '.$instr4;
		
		$exSql = mysql_query($this->sql);
								
		if(mysql_num_rows($exSql) > 0)
		{	
			if($boo == TRUE)
			{
				
				$this->dadosPerso = mysql_fetch_assoc($exSql);
				
			}
						
			return $exSql;
		}
		else
			
			return false;
		
	}
	
	//Fun��o respons�vel por atualizar registros no banco de dados
	function updateSql($instr1,$instr2)
	{
	
		$this->sql = "UPDATE {$this->entidade} SET {$instr1} WHERE {$instr2}";
				
		$exSql = mysql_query($this->sql) or die(mysql_error());
		
		if(mysql_affected_rows())
		
			return true;
		
		else
		{	
			$this->erro = mysql_error();
			return false;
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
				
				case "login": $ret = 'LOG_USU'; break;
				
				case "senha": $ret = 'SEN_USU'; break;	
					
				case "email": $ret = 'EMAIL_USU'; break;	
				
				case "dtNascimento": $ret = 'DT_NASC_USU'; break;
				
				case "dtCadastro": $ret = 'DT_CADS_USU'; break;
				
				case "pontos": $ret = 'PTS_USU'; break;
				
				case "medBro": $ret = 'MED_BRO_USU'; break;
				
				case "medPra": $ret = 'MED_PRA_USU'; break;
				
				case "medOur": $ret = 'MED_OUR_USU'; break;
				
				case "troBro": $ret = 'TROF_BRO_USU'; break;
				
				case "troPra": $ret = 'TROF_PRA_USU'; break;
				
				case "troOur": $ret = 'TROF_OUR_USU'; break;
				
				case "troPla": $ret = 'TROF_PLA_USU'; break;
				
				case "troDia": $ret = 'TRO_DIA_USU'; break;

				case "descricao": $ret = 'DESC_USU'; break;
					
				case "ativoMa": $ret = 'ATIVO_USU'; break;
				
				case "numMat": $ret = 'NUM_MAT_USU'; break;
				
				case "progresso": $ret = 'PROG_TOT_USU'; break;
				
				case "foto": $ret = 'FT_USU'; break;		
				
				case "titulo": $ret = 'COD_TIT_USU'; break;

				case "sexo": $ret = 'COD_SX'; break;

				case "cidade": $ret = 'COD_CID'; break;
				
				case "estado": $ret = 'COD_EST'; break;
				
			}
		
		}
		
		if($secao == "noticia")
		{
			
			switch($dadoRetornar)
			{
			
				case "codigo": $ret = 'COD_NOT'; break;
			
				case "titulo": $ret = 'TIT_NOT'; break;
			
				case "texto": $ret = 'TXT_NOT'; break;
			
				case "data": $ret = 'DT_NOT'; break;
			
				case "hora": $ret = 'HR_NOT'; break;
			
				case "imgIni": $ret = 'PATH_IMG_INI_NOT'; break;
			
				case	"img1": $ret = 'PATH_IMG1_NOT'; break;
			
				case	"img2": $ret = 'PATH_IMG2_NOT'; break;
			
				case	"img3": $ret = 'PATH_IMG3_NOT'; break;
				
			}	
			
		}
		
		if($secao == "enquete")
		{
			
			switch($dadoRetornar)
			{
			
				//T�tulo
				case "titulo":
			
					$ret = 'TIT_ENQ';
					break;		
					
				//Op��es para votar
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
				
				//Valores de cada Op��o
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
	
		$dados = mysql_fetch_assoc($exSql);
		return $dados;
	}
	public function formataUrl($string)
	{
		$palavraAtual = strtr($string, "SOZsozY��������������������������������������������������������������:,'", "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy---");
		$retorno = str_replace(" ", "-", $palavraAtual);
		return $retorno;
	}
	public function formataData($string)
	{
		$dataAtual = explode("-",$string);
		$retorno = $dataAtual[2]."/".$dataAtual[1]."/".$dataAtual[0];	
		return $retorno;
	}	
}
?>