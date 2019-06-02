<?php
class manageNews extends sqlInstruction
{
	
	function noticiasTexto($boo,$qtd,$qtdAtual,$booNormal)//boo == true -> noticia resumida com "..." else noticia normal 
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('noticias');
		
		//$dataAtual = date('Y-m-d'); $dataAnterior = date('Y-m-d'); //data anterior = 2 dias
		
		//NOTICIAS RESUMIDAS
		if($boo == true) $objRespo = parent::selectSql("TIT_NOT,DT_NOT", "COD_NOT > 4 AND NOT FLAG_BANNER_NOT AND NOT FLAG_IMAGENS_NOT AND NOT FLAG_VIDEOS_NOT AND NOT FLAG_ANALISE_NOT", 'DT_NOT', '5',false);
		
		//NOTICIAS SEMANAIS
		if($booNormal == "normal" ) $objRespo = parent::selectSql("TIT_NOT,DT_NOT", "TO_DAYS( NOW( ) ) - TO_DAYS( DT_NOT ) <= 7 AND NOT FLAG_BANNER_NOT AND NOT FLAG_IMAGENS_NOT AND NOT FLAG_VIDEOS_NOT AND NOT FLAG_ANALISE_NOT", 'DT_NOT', '7',false);
		
		if($qtd == 7) $objRespo = parent::selectSql("TIT_NOT,DT_NOT", "TO_DAYS( NOW() ) - TO_DAYS( DT_NOT ) >= 7 AND NOT FLAG_BANNER_NOT AND NOT FLAG_IMAGENS_NOT AND NOT FLAG_VIDEOS_NOT AND NOT FLAG_ANALISE_NOT", 'DT_NOT', '7',false);
		
		$numLinhas = mysql_num_rows($objRespo);
		$retornoArray = array();
		
		while($dadosNot = mysql_fetch_assoc($objRespo)){ $retornoArray['noticia'][] = $dadosNot['TIT_NOT']; $retornoArray['dataNoticia'][] = $dadosNot['DT_NOT']; }
		
		parent::encerraConexaoSql($conSql);
		
		for($i=0;$i<$numLinhas;$i++)
		{
			//Formata palavras
			$retornoArray['linkNoticia'][$i] = parent::formataUrl($retornoArray['noticia'][$i]);
			
			//Formata data
			$retornoArray['dataNoticia'][$i] = parent::formataData($retornoArray['dataNoticia'][$i]);
		}
			
		if($boo == true)
		{
			$strRetorno1 = ""; $strRetorno2 = ""; $strRetorno3 = ""; $strRetorno4 = "";$strRetorno5 = "";
			
			$cmp1 = explode(" ",$retornoArray['noticia'][0]);	$cmp2 = explode(" ",$retornoArray['noticia'][1]);
			$cmp3 = explode(" ",$retornoArray['noticia'][2]);	$cmp4 = explode(" ",$retornoArray['noticia'][3]);
			$cmp5 = explode(" ",$retornoArray['noticia'][4]);
			
			
			for($i=0;$i<5;$i++)
			{
				
				$retornoArray['noticia'][0] = $strRetorno1.= ($i != 4) ? $cmp1[$i]." " : $cmp1[$i];
				$retornoArray['noticia'][1] = $strRetorno2.= ($i != 4) ? $cmp2[$i]." " : $cmp2[$i];
				$retornoArray['noticia'][2] = $strRetorno3.= ($i != 4) ? $cmp3[$i]." " : $cmp3[$i];
				$retornoArray['noticia'][3] = $strRetorno4.= ($i != 4) ? $cmp4[$i]." " : $cmp4[$i];
				$retornoArray['noticia'][4] = $strRetorno5.= ($i != 4) ? $cmp5[$i]." " : $cmp5[$i];
				
			}
		}
		
		return $retornoArray;

	}
	
	function newsEntretenimento()
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('noticias');
		
		$objRespo = parent::selectSql("PATH_IMG_INI_NOT,TIT_NOT", "FLAG_ANALISE_NOT = 1 OR FLAG_IMAGENS_NOT = 1 OR FLAG_VIDEOS_NOT = 1", '', '3',false);
		
		
		$numLinhas = mysql_num_rows($objRespo);
		$retornoArray = array();
		
		while($dadosEnt = mysql_fetch_assoc($objRespo)){ $retornoArray['imagens'][] = $dadosEnt['PATH_IMG_INI_NOT'];  $retornoArray['links'][] = $dadosEnt['TIT_NOT'];}
		
		for($i=0;$i<$numLinhas;$i++)
		{
			$palavraAtual = strtr($retornoArray['links'][$i], "SOZsozY¥µÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýÿ:'", "SOZsozYYuAAAAAAACEEEEIIIIDNOOOOOOUUUUYsaaaaaaaceeeeiiiionoooooouuuuyy--");
			$retornoArray['links'][$i] = str_replace(" ", "-", $palavraAtual);
		}
		
		return $retornoArray;
	}

}
?>