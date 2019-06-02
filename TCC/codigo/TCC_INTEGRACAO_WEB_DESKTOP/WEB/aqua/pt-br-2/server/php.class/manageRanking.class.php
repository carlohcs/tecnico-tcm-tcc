<?php
class manageRanking extends sqlInstruction
{
	
	function atualizaRanking()
	{
		// Seta o local para que os nomes e datas apareçam em português do Brasil
		setlocale(LC_TIME, 'pt_BR');
		$conSql = parent::conexaoSql(); //parent::defineEntidade('ranking_usuario'); //conecta e define a entidade de ranking
		/*$exSql = parent::selectSql('DT_RNK','','MAX(DT_RNK)','',false); //Seleciona a última maior data do sql*/
		
		//if($exSql != false) //se encontrar registro
		//{
			/*if(parent::SQLSERVER == true)
				$resp = mysql_fetch_array($exSql);//pega o resultado
			else
				$resp = mssql_fetch_array($exSql);//pega o resultado*/
				
			//$dtBd = $resp['DT_RNK'];//Data do banco de dados
			$dtAt = strtotime(strftime('%Y/%m/%d'));//Data atual
		//	$intDtBd = strtotime("+7 day",strtotime($dtBd)); //Adiciona + 7 a data
			
			//SE A ÚLTIMA DATA ATUAL FOR <= 7 DA DIFERENÇA DA DATA DE ATUALIZAÇÃO, MANDA ATUALIZAR O RANKING
		$i = 1;			
				parent::defineEntidade('usuario');
				$arrDados = parent::selectSql('TOP 5 COD_USU, PTS_USU','','PTS_USU DESC','',false);//seleciona os pontos e códigos dos usuários
				
				$stringQuery = 'VALUES ';//string de query
				
				
					while($ret = mssql_fetch_assoc($arrDados))
					{
					
						$stringQuery.= "('{$ret['COD_USU']}','{$ret['PTS_USU']}' ,'2011-11-18')";
						if($i <  mssql_num_rows($arrDados)) $stringQuery.= ', ';
						$i++;
				
					}	
				
				
				parent::defineEntidade('ranking_usuario');
				$exSql = parent::insertSql($stringQuery,'full'); //insere o ranking atual
				
				return true;
			/*	
			}return false;
			
		}else echo "<p>Não possuímos artigos curtidos.</p>";*/
		
	}

	function exibeRanking()
	{
		$conSql = parent::conexaoSql();
		
		if(parent::SQLSERVER == true)
		{
			$seleUtD = mssql_query("SELECT MAX(DT_RNK) AS 'DT_DATA' FROM ranking_usuario");
		
			$resp = mssql_fetch_assoc($seleUtD);
		}
		else
		{
			$seleUtD = mysql_query("SELECT MAX(DT_RNK) AS 'DT_DATA' FROM ranking_usuario");
		
			$resp = parent::fetch($seleUtD);
		}
		parent::defineEntidade('ranking_usuario INNER JOIN usuario ON usuario.COD_USU = ranking_usuario.COD_USU');
		
		$exSql = parent::selectSql('usuario.LOG_USU, ranking_usuario.DT_RNK,ranking_usuario.PTS_USU', "ranking_usuario.DT_RNK = '{$resp['DT_DATA']}'",
										'ranking_usuario.PTS_USU DESC,DT_RNK DESC', '', false); 
										
		$i=0; $dtRnk = '';
		$html = ''; $qtdusu=0;
		$html.= "<table class='ranking'><tr><th>Usuário</th><th>Pontos</th></tr><tr>";
		
	
			while($retorno = parent::fetch($exSql))
			{
				$i++;
				if($dtRnk != $retorno['DT_RNK']) $html.= "<h4 class='dataRnk'>Última semana: (".parent::formataData($retorno['DT_RNK'])."):</h4>";
					$html.= "<td>{$i} - <a href='perfil/{$retorno['LOG_USU']}'>{$retorno['LOG_USU']}</a></td>";
					$html.= "<td>{$retorno['PTS_USU']}</td></tr>";
				$dtRnk = $retorno['DT_RNK']; 
				$qtdusu++; 
			}
				
		$html.= "</table>";
		
		echo $html;
		
		parent::defineEntidade('ranking_usuario INNER JOIN usuario ON usuario.COD_USU = ranking_usuario.COD_USU');
		
		$exSql = parent::selectSql('usuario.LOG_USU, ranking_usuario.DT_RNK,ranking_usuario.PTS_USU', "ranking_usuario.DT_RNK <> '{$resp['DT_DATA']}'",
										'DT_RNK DESC,ranking_usuario.PTS_USU DESC', '', false); 
		
		if($exSql != false)
		{
			$dtAt = ''; $html = ''; $i=0; $nAtual = 0; $nArr = 0;

			while($res = parent::fetch($exSql))
			{
				if($i == $qtdusu || $i == ($qtdusu + $qtdusu)){ $nAtual++; $nArr = 0; }
				$arrDados['logins'][$nAtual][$nArr] = $res['LOG_USU']; 

				$arrDados['pontos'][] = $res['PTS_USU'];
				if($dtAt != $res['DT_RNK']){ $arrDados['datas'][] = $res['DT_RNK']; $dtAt = $res['DT_RNK'];} $i++; $nArr++;
			}	
				
			parent::encerraConexaoSql($conSql);
			
			$dtAt = ''; $html = ''; $pontos = 0;
			
			for($i=0,$j=0;$i<count($arrDados['datas']),$j<count($arrDados['logins']);$i++,$j++)
			{
				
			
				$html.= "<h4 class='dataRnk'>Data: ".parent::formataData($arrDados['datas'][$i])."</h4>";
				
				$html.= "<table class='ranking'>";	
					
					
				for($k=0;$k<$qtdusu;$k++)
				{
					$html.= "<tr><td>".($k + 1)." - <a href='perfil/{$arrDados['logins'][$j][$k]}'>{$arrDados['logins'][$j][$k]}</a></td>";
					$html.= "<td>{$arrDados['pontos'][$pontos]}</td></tr>";
					$pontos++;
				}
					
				$html.= "</table>";
				
			}
			
			echo $html;
		}
		
	}
	
	function exibePosicaoUsuarioRanking($codUsu)
	{
	
		$conSql = parent::conexaoSql(); parent::defineEntidade('ranking_usuario');
		//$codUsu = 2;
		$arrRetorno = array();
		$arrDadosUsers = array();
		
		//BUSCANDO AS TRÊS MELHORES POSIÇÕES DE UM USUÁRIO
		
		$exSql = parent::selectSql('PTS_USU,DT_RNK', "COD_USU = '{$codUsu}'", 'PTS_USU DESC', '3', false);
		
		if($exSql != false)
		{
		
			//PREENCHE O ARRAY COM AS INFORMAÇÕES
			while($resp = parent::fetch($exSql))
			{
				$arrRetorno['datas'][] = $resp['DT_RNK'];
				$arrRetorno['ptsUsuario'][] = $resp['PTS_USU'];
			}
		
			//SELECIONA TODOS OS PONTOS DOS USUÁRIOS NA DATA X
			
			//PONTUAÇÃO 1
			$exSql = parent::selectSql('PTS_USU,DT_RNK', "DT_RNK = '{$arrRetorno['datas'][0]}'",'PTS_USU DESC','',false);
			if($exSql != false)
			{
				
				while($resp = parent::fetch($exSql)) $arrDadosUsers['ptsUsuarios'][0][] = $resp['PTS_USU'];
				//--PONTUAÇÃO 1
								
				//PONTUAÇÃO 2
				$exSql = parent::selectSql('PTS_USU,DT_RNK', "DT_RNK = '{$arrRetorno['datas'][1]}'",'PTS_USU DESC','',false);
				
				if($exSql != false)
				{
					
					while($resp = parent::fetch($exSql)) $arrDadosUsers['ptsUsuarios'][1][] = $resp['PTS_USU'];
					
					//--PONTUAÇÃO 2
					
					//PONTUAÇÃO 3
					$exSql = parent::selectSql('PTS_USU,DT_RNK', "DT_RNK = '{$arrRetorno['datas'][2]}'",'PTS_USU DESC','',false); $i=0;
					
					if($exSql != false)
					{
						
						while($resp = parent::fetch($exSql)) $arrDadosUsers['ptsUsuarios'][2][] = $resp['PTS_USU'];
						//--PONTUAÇÃO 3
						
					}
				}	
			}
			
			
			//VERIFICA EM QUAIS POSIÇÕES O USUÁRIO FICOU
			
			for($i=0;$i<count($arrDadosUsers['ptsUsuarios']);$i++)
			{
				for($j=0;$j<count($arrDadosUsers['ptsUsuarios'][$i]);$j++)
				{
					if($arrRetorno['ptsUsuario'][$i] == $arrDadosUsers['ptsUsuarios'][$i][$j])
					{
						$arrRetorno['posicoes'][$i] = $j + 1;
						break;
					}
				}
			}

		}
		else
		{
		
			return false;
		}
		
		return $arrRetorno;
		
	}
}
?>