<?php
class manageBusca extends sqlInstruction
{


	function buscaNotArt($tipo,$palavraBusca)
	{
	
		switch($tipo)
		{
			
			case "unicoReg":
			
			break;
			case "todosReg":
			
				$xml = '<?xml version="1.0" encoding="iso-8859-1" ?>'; 
				$xml.="<principal>";
				//ARTIGOS
				$conSql = parent::conexaoSql();
				
				if(parent::SQLSERVER == TRUE)
				{
					$objRespo = mssql_query("
						SELECT DISTINCT LINK_ART, TIT_ART, DT_POST_ART, usuario.LOG_USU,categoria.TIT_CTG
						FROM artigo INNER JOIN usuario ON usuario.COD_USU = artigo.COD_USU
						INNER JOIN categoria ON categoria.COD_CTG = artigo.COD_CTG
						WHERE FLAG_ART_AP = 1
						AND PLV_CHV_ART1 LIKE  '%{$palavraBusca}%'
						OR artigo.PLV_CHV_ART2 LIKE  '%{$palavraBusca}%'
						OR artigo.PLV_CHV_ART3 LIKE  '%{$palavraBusca}%'
						AND FLAG_ART_AP =1");
				}		
				else
				{
					$objRespo = mysql_query("
						SELECT DISTINCT LINK_ART, TIT_ART, DT_POST_ART, usuario.LOG_USU
						FROM artigo INNER JOIN usuario ON usuario.COD_USU = artigo.COD_USU
						WHERE PLV_CHV_ART1 LIKE  '%{$palavraBusca}%'
						OR artigo.PLV_CHV_ART2 LIKE  '%{$palavraBusca}%'
						OR artigo.PLV_CHV_ART3 LIKE  '%{$palavraBusca}%'
						AND FLAG_ART_AP =1
						LIMIT 0 , 30");
				}
				
				$numLinhas = 0;
				
				if($objRespo) $numLinhas = parent::rows($objRespo);
				
				if($numLinhas > 0)
				{
					$xml.= "<artigos>";
					while($dadosRespo = parent::fetch($objRespo))
					{
						$xml.= "<item>";
							$xml.= "<url>".parent::formataUrl($dadosRespo['TIT_CTG'])."/".$dadosRespo['LOG_USU']."/".$dadosRespo['LINK_ART']."</url>";
							$xml.="<titulo>".$dadosRespo['TIT_ART']."</titulo>";
							$xml.="<data>".parent::formataData($dadosRespo['DT_POST_ART'])."</data>";										
						$xml.= "</item>";
					}
					$xml.= "</artigos>";
				}	
				else{ $xml.="<artigos><item><url>0</url></item></artigos>"; }
				
				//JOGOS
				parent::defineEntidade('itens_ctg, categoria');
				
				$objRespo = parent::selectSql("itens_ctg.TIT_ITN_CTG, categoria.TIT_CTG","TIT_ITN_CTG LIKE '%".$palavraBusca."%' AND itens_ctg.COD_CTG = categoria.COD_CTG","","",false);
				$numLinhas = 0;
				if($objRespo != FALSE) $numLinhas = parent::rows($objRespo);
				
				if($numLinhas > 0)
				{
					$xml.= "<jogos>";
					while($dadosRespo = parent::fetch($objRespo))
					{
						$xml.= "<item>";
							$xml.= "<url>".parent::formataUrl($dadosRespo['TIT_CTG'])."/".parent::formataUrl($dadosRespo['TIT_ITN_CTG'])."</url>";
							$xml.="<titulo>".$dadosRespo['TIT_ITN_CTG']."</titulo>";
						$xml.= "</item>";
					}
					$xml.= "</jogos>";
				}	
				else{ $xml.="<jogos><item><url>0</url></item></jogos>"; }
				
				$xml.="</principal>";
				
				parent::encerraConexaoSql($conSql);				
				
			break;
		
		}
		echo $xml;
	}



}
/*$obj = new manageBusca;
$resp = $obj->buscaNotArt($_GET['type'],$_GET['not']);
var_dump($resp);*/
?>