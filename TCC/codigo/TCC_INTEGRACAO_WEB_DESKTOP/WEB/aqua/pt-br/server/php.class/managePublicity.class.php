<?php
class managePublicity extends sqlInstruction
{
	
	//Retornar publicidades
	function retornaPublicidadeLateral()
	{
		$retorno = array();
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade('publicidade_lateral');

		//Busca os dados da enquete
		$exSql = parent::selectSql("COD_PUB,TIT_PUB,LINK_PUB,PATH_IMG_PUB", '', '', '',false);	
		 
		while($row =  parent::fetch($exSql))
		{
			$retorno['caminhoImg'][] = $row['PATH_IMG_PUB'];
			$retorno['titulos'][] = $row['TIT_PUB'];
			$retorno['links'][] = $row['LINK_PUB'];
		}
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
	
		return $retorno;
		
	}
	
	function retornaPublicidadeTop()
	{
		$retorno = array();
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade("publicidade_top");

		//Busca os dados da noticia
		$exSql = parent::selectSql("COD_PUB,TIT_PUB,LINK_PUB,PATH_IMG_PUB", '', '', '4',false);
		
		$retornoArray = array();
				
		$numLinhas = parent::rows($exSql);
			
		while($dadosNot = parent::fetch($exSql)){ $retornoArray['caminhoImg'][] = $dadosNot['PATH_IMG_PUB']; 
		$retornoArray['links'][] = $dadosNot['LINK_PUB']; $retornoArray['descricao'][] = $dadosNot['TIT_PUB']; }
			
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
	
		return $retornoArray;
		
	}
	
}
?>