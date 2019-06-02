<?php
class manageJogos extends sqlInstruction
{
	
	function listaCategoria($limite)
	{
		$conSql = parent::conexaoSql(); parent::defineEntidade('categoria');
		if($limite == true) $objRespo = parent::selectSql("COD_CTG, TIT_CTG", "FLAG_MEN = 1", '', '3',false);
		else $objRespo = parent::selectSql("COD_CTG, TIT_CTG", "", '', '',false);
		

		$retornoArray = array(); $numLinhas = parent::rows($objRespo);
		while($dadosRetorno = parent::fetch($objRespo))
		{
			$retornoArray['codCategoria'][] = $dadosRetorno['COD_CTG'];
			$retornoArray['descricaoCategoria'][] = $dadosRetorno['TIT_CTG'];
		}
		
		parent::encerraConexaoSql($conSql);
		for($i=0;$i<$numLinhas;$i++)	$retornoArray['linkCategoria'][$i] = parent::formataUrl($retornoArray['descricaoCategoria'][$i]);
		
		return $retornoArray;
	}
	
	function listaJogosCategoria($limite)
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('itens_ctg');
		
		if($limite == true) $objRespo = parent::selectSql("COD_ITN_CTG, TIT_ITN_CTG, COD_CTG", "FLAG_INT_CTG = 1", '', '15',false);
		else $objRespo = parent::selectSql("COD_ITN_CTG, TIT_ITN_CTG, COD_CTG", "", '', '',false);
		

		$retornoArray = array(); $numLinhas = parent::rows($objRespo);
		while($dadosRetorno = parent::fetch($objRespo))
		{
			$retornoArray['descricaoJogo'][] = $dadosRetorno['TIT_ITN_CTG'];
			$retornoArray['codCategoria'][] = $dadosRetorno['COD_CTG'];
		}
		
		parent::encerraConexaoSql($conSql);
		
		for($i=0;$i<$numLinhas;$i++)	$retornoArray['linkJogo'][$i] = parent::formataUrl($retornoArray['descricaoJogo'][$i]);
				
		return $retornoArray;
		
	}
	
}
?>	