<?php
class manageJogos extends sqlInstruction
{
	
	function listaCategoria()
	{
		$conSql = parent::conexaoSql(); parent::defineEntidade('categoria');
		$objRespo = parent::selectSql("COD_CTG, TIT_CTG", "", '', '',false);
		$retornoArray = array(); $numLinhas = mysql_num_rows($objRespo);
		while($dadosRetorno = mysql_fetch_assoc($objRespo))
		{
			$retornoArray['codCategoria'][] = $dadosRetorno['COD_CTG'];
			$retornoArray['descricaoCategoria'][] = $dadosRetorno['TIT_CTG'];
		}
		parent::encerraConexaoSql($conSql);
		for($i=0;$i<$numLinhas;$i++)
		{
			//Formata palavras
			$palavraAtual = strtr($retornoArray['descricaoCategoria'][$i], "SOZsozY¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿª:,'", "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy----");
			$retornoArray['linkCategoria'][$i] = str_replace(" ", "-", $palavraAtual);
			
		}	
		return $retornoArray;
	}
	
	function listaJogosCategoria($codCategoria,$booSecao)
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('jogos');
		
		if($booSecao == true) $objRespo = parent::selectSql("COD_JOGO, DESC_JOGO", "COD_CTG = ".$codCategoria."", '', '5',false);
		else $objRespo = parent::selectSql("COD_JOGO, DESC_JOGO", "", '', '',false);
		
		$retornoArray = array(); $numLinhas = mysql_num_rows($objRespo);
		while($dadosRetorno = mysql_fetch_assoc($objRespo))
		{
			$retornoArray['codJogo'][] = $dadosRetorno['COD_JOGO'];
			$retornoArray['descricaoJogo'][] = $dadosRetorno['DESC_JOGO'];
		}
		parent::encerraConexaoSql($conSql);
		for($i=0;$i<$numLinhas;$i++)
		{
			//Formata palavras
			$palavraAtual = strtr($retornoArray['descricaoJogo'][$i], "SOZsozY¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿª:,'", "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy----");
			$retornoArray['linkJogo'][$i] = str_replace(" ", "-", $palavraAtual);
			
		}	
		return $retornoArray;
		
	}
	
}
?>	