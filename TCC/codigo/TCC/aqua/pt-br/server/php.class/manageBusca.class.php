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
				
				$conSql = parent::conexaoSql(); parent::defineEntidade('artigo');
				$objRespo = parent::selectSql("TIT_ART,DT_POST_ART","PLV_CHV_NOT1 LIKE '%".$palavraBusca."%' OR PLV_CHV_NOT2 LIKE '%".$palavraBusca."%' OR PLV_CHV_NOT3 LIKE '%".$palavraBusca."%' AND FLAG_ART_AP = 1","","",false);
				$numLinhas = 0;
				if($objRespo != FALSE) $numLinhas = mysql_num_rows($objRespo);
				
				if($numLinhas > 0)
				{
					while($dadosRespo = mysql_fetch_assoc($objRespo)) echo "<li><a href='artigos/".parent::formataUrl($dadosRespo['TIT_ART'])."'>".$dadosRespo['TIT_ART']." - ".parent::formataData($dadosRespo['DT_POST_ART'])."</a></li>";										
					parent::encerraConexaoSql($conSql);
				}else echo "<li>Nenhum Artigo/Notícia encontrada.</li>";
				
				
			break;
		
		}
	
	}



}
?>