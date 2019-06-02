<?php
class managePublicity extends sqlInstruction
{
	
	//Retornar publicidades
	function retornarPublicidade()
	{
		$retorno = array();
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade('publicidade');

		//Busca os dados da enquete
		$exSql = parent::selectSql("COD_PUB,TIT_PUB,LINK_PUB,PATH_IMG_PUB", '', '', '',false);
		
		while($row = mysql_fetch_array($exSql))
		{
			$retorno['caminhoImg'][] = $row['PATH_IMG_PUB'];
			$retorno['titulos'][] = $row['TIT_PUB'];
			$retorno['links'][] = $row['LINK_PUB'];
		}
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
	
		return $retorno;
		
	}
	
}
?>