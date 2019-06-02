<?php
class manageNews extends sqlInstruction
{
	
	function noticiasTexto($boo,$qtd,$qtdAtual,$booNormal)//boo == true -> noticia resumida com "..." else noticia normal 
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('noticias');
				
		if(parent::SQLSERVER == TRUE) //TO_DAYS( NOW( ) ) - TO_DAYS( DT_NOT ) <= 40 TO_DAYS( NOW() ) - TO_DAYS( DT_NOT ) >= 7
		{
			if($booNormal == "normal" ) $objRespo = parent::selectSql("LINK_NOT,TIT_NOT,DT_NOT", "", 'DT_NOT', '7',false);
		
			if($qtd == 7) $objRespo = parent::selectSql("LINK_NOT,TIT_NOT,DT_NOT", "", 'DT_NOT', '7',false);
		}
		else
		{
			if($booNormal == "normal" ) $objRespo = parent::selectSql("LINK_NOT,TIT_NOT,DT_NOT", "TO_DAYS( NOW( ) ) - TO_DAYS( DT_NOT ) <= 40", 'DT_NOT', '7',false);
		
			if($qtd == 7) $objRespo = parent::selectSql("LINK_NOT,TIT_NOT,DT_NOT", "TO_DAYS( NOW() ) - TO_DAYS( DT_NOT ) >= 7", 'DT_NOT', '7',false);
		}
		
		$numLinhas = parent::rows($objRespo);$retornoArray = array();
		
		while($dadosNot = parent::fetch($objRespo)){ $retornoArray['linkNoticia'][] = $dadosNot['LINK_NOT']; $retornoArray['noticia'][] = $dadosNot['TIT_NOT']; $retornoArray['dataNoticia'][] =  parent::formataData($dadosNot['DT_NOT']); }
		
		
		parent::encerraConexaoSql($conSql);
						
		return $retornoArray;

	}
	
	function newsDestaque()
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('destaque');
		
		$objRespo = parent::selectSql("TIT_DEST,LINK_DEST,PATH_IMG_INI_DEST,TIT_DEST", "FLAG_ANLS_DEST = 1 OR FLAG_IMG_DEST = 1 OR FLAG_VID_DEST = 1", 'DT_DEST', '3',false);
		
		$numLinhas = parent::rows($objRespo);
		$retornoArray = array();
		
		while($dadosEnt = parent::fetch($objRespo)){ $retornoArray['imagens'][] = $dadosEnt['PATH_IMG_INI_DEST'];  $retornoArray['links'][] = $dadosEnt['LINK_DEST'];$retornoArray['titulos'][] = $dadosEnt['TIT_DEST'];}
		
		return $retornoArray;
	}
	
	function newsArtigo($boo) //$boo = artigo = resumido TO_DAYS ( NOW() ) - TO_DAYS( artigo.DT_POST_ART) AND 
	{
		
		$conSql = parent::conexaoSql(); parent::defineEntidade('usuario,artigo INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG');
	
		if(parent::SQLSERVER == true)
			$objRespo = parent::selectSql("artigo.COD_ART,artigo.LINK_ART,artigo.TIT_ART,artigo.DT_POST_ART, usuario.LOG_USU,categoria.TIT_CTG", "usuario.COD_USU = artigo.COD_USU AND FLAG_ART_AP = 1", 'DT_POST_ART', '30',false);
		else
			$objRespo = parent::selectSql("artigo.COD_ART,artigo.LINK_ART,artigo.TIT_ART,artigo.DT_POST_ART, usuario.LOG_USU", "TO_DAYS ( NOW() ) - TO_DAYS( artigo.DT_POST_ART) AND usuario.COD_USU = artigo.COD_USU AND FLAG_ART_AP = 1", 'DT_POST_ART', '5',false);
		
		$retornoArray = array();

		while($dadosNot = parent::fetch($objRespo)){ $retornoArray['linkArtigo'][] = $dadosNot['LINK_ART']; $retornoArray['artigo'][] = $dadosNot['TIT_ART']; $retornoArray['dataArtigo'][] = parent::formataData($dadosNot['DT_POST_ART']); $retornoArray['usuario'][] = $dadosNot['LOG_USU']; $retornoArray['categoria'][] = $dadosNot['TIT_CTG'];}

		//$numLinhas = mysql_num_rows($objRespo);
		
		parent::encerraConexaoSql($conSql);
	

		return $retornoArray;
	}	
}
?>