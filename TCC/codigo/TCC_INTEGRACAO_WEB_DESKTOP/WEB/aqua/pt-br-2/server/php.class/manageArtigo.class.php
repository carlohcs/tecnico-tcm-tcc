<?php
class manageArtigo extends sqlInstruction
{

	function escreveArtigo($titArt,$txtArt,$plC1,$plC2,$plC3,$codUsu)
	{
	
		$conSql = parent::conexaoSql(); parent::defineEntidade('artigo');	
		
		if(parent::SQLSERVER == TRUE)
			$objRespo = parent::insertSql("'{$titArt}','{$txtArt}', '".parent::formataUrl($titArt)."',
		'".date("Y/m/d")."', '".date("H:m:s")."',	'0', '{$plC1}','{$plC2}','{$plC3}','0','{$codUsu}'",'relative');
		else
			$objRespo = parent::insertSql("'null', '{$titArt}','{$txtArt}', '".parent::formataUrl($titArt)."',
			'".date("Y/m/d")."', '".date("H:m:s")."',	'0', '{$plC1}','{$plC2}','{$plC3}','0','{$codUsu}'",'relative');
		
		parent::encerraConexaoSql($conSql);
		
		if($objRespo != false) return true; else return false;
			
	}
	
	function selecionarAllArtigos()
	{
	
		$conSql = parent::conexaoSql(); 
		$exSql = mssql_query("SELECT artigo.TIT_ART,artigo.COD_CTG as 'COD_CTG_ART', artigo.DT_POST_ART,artigo.LINK_ART,
		usuario.LOG_USU,
		categoria.TIT_CTG,categoria.COD_CTG
		FROM artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG 
		INNER JOIN usuario ON usuario.COD_USU = artigo.COD_USU WHERE artigo.FLAG_ART_AP = 1 ORDER BY categoria.COD_CTG,categoria.TIT_CTG,artigo.TIT_ART");
			
		$retornoArray = array();
		$cate = "";	
		while($resp = mssql_fetch_assoc($exSql))
		{
			$retornoArray['titulo'][] = $resp['TIT_ART'];
			
			if($cate != $resp['TIT_CTG']){

				$retornoArray['categoria'][] = $resp['TIT_CTG'];
				$retornoArray['codCategoria'][] = $resp['COD_CTG'];
			
			}
			
			$cate = $resp['TIT_CTG'];
			$retornoArray['codigoCateArtigo'][] = $resp['COD_CTG_ART'];
			$retornoArray['link'][] = parent::formataUrl($resp['TIT_CTG']);
			$retornoArray['linkArt'][] = $resp['LINK_ART'];
			$retornoArray['login'][] = $resp['LOG_USU'];
			$retornoArray['data'][] = parent::formataData($resp['DT_POST_ART']);
		}		
		
		return $retornoArray;
	}
	
	
	
}
?>