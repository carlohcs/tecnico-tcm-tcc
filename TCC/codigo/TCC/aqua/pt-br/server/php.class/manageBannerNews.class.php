<?php
//header("Content-Type: text/html; charset=iso-8859");
class manageBannerNews extends sqlInstruction
{
	
	//Retornar dados do Banner de Noticias
	function retornaBannerNoticias()
	{
		$retorno = array();
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade("noticias");

		//Busca os dados da noticia
		$exSql = parent::selectSql("COD_NOT,TXT_NOT,TIT_NOT,PATH_IMG_INI_NOT", 'FLAG_BANNER_NOT = 1', 'DT_NOT', '4',false);
		
		$numLinhas = mysql_num_rows($exSql);
		$retornoArray = array();
		
		while($dadosNot = mysql_fetch_assoc($exSql)){ $retornoArray['caminhoImg'][] = $dadosNot['PATH_IMG_INI_NOT']; $retornoArray['links'][] = $dadosNot['TIT_NOT']; $retornoArray['descricao'][] = $dadosNot['TXT_NOT']; }
		
		for($i=0;$i<$numLinhas;$i++)
		{
			$palavraAtual = strtr($retornoArray['links'][$i], "SOZsozY¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝ‗אבגדהוזחטיךכלםמןנסעףפץצרשתûü‎ÿ:'", "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy--");
			$retornoArray['links'][$i] = str_replace(" ", "-", $palavraAtual);
		}
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
	
		return $retornoArray;
		
	}
	
}
?>