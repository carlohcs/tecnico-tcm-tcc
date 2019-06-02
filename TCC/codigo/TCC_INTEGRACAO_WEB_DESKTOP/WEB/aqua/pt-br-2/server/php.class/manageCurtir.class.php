<?php
include_once('sqlInstruction.class.php');
class manageCurtir extends sqlInstruction
{

	function curtirArtigo($codCur,$codArt,$codUsuSess,$codUsu,$curtir)
	{
		
		$conSql = parent::conexaoSql();  
		if($curtir == 'true'){
		
			//RETORNA OS PONTOS DO USUÁRIO
			parent::defineEntidade('usuario');
			$exSql = parent::selectSql('PTS_USU',"COD_USU = '{$codUsu}'", '', '', false);
			
			
			$resp = parent::fetch($exSql);
			
			$pontos = $resp['PTS_USU'];
			
			$codTitulo = self::retornaTituloUsuario($pontos);
			
			//ATUALIZA OS PONTOS DO ARTIGO E DO USUÁRIO
			parent::defineEntidade('usuario');
			$exSql1 = parent::updateSql("PTS_USU = PTS_USU + 1, COD_TIT_USU = '{$codTitulo}'","COD_USU = '{$codUsu}'");
			
			parent::defineEntidade('artigo');
			$exSql2 = parent::updateSql("artigo.PTS_ART = PTS_ART + 1","COD_ART = {$codArt}");
		
			//INSERE O CÓDIGO DO USUÁRIO E A POSTAGEM FEITA
			parent::defineEntidade('curtir_artigo');
			if(self::SQLSERVER == TRUE)
				$exSql3 = parent::insertSql("'{$codArt}' , '{$codUsuSess}'", 'relative');
			else	
				$exSql3 = parent::insertSql(" 'null' , '{$codArt}' , '{$codUsuSess}'", 'relative');
		}	
		else
		{
			
			//RETORNA OS PONTOS DO USUÁRIO
			parent::defineEntidade('usuario');
			$exSql = parent::selectSql('PTS_USU',"COD_USU = '{$codUsu}'", '', '', false);
			
			if(parent::SQLSERVER == TRUE)
				$resp = mssql_fetch_assoc($exSql);
			else
				$resp = parent::fetch($exSql);
				
			$pontos = $resp['PTS_USU'];
			
			$codTitulo = self::retornaTituloUsuario($pontos);
			
			//ATUALIZA OS PONTOS DO ARTIGO E DO USUÁRIO
			parent::defineEntidade('usuario');
			$exSql1 = parent::updateSql("PTS_USU = PTS_USU - 1, COD_TIT_USU = '{$codTitulo}'","COD_USU = '{$codUsu}'");
			
			parent::defineEntidade('artigo');
			$exSql2 = parent::updateSql("PTS_ART = PTS_ART - 1","COD_ART = '{$codArt}'");
			
			//REMOVE O CURTIR DO USUÁRIO
			parent::defineEntidade('curtir_artigo');
			$exSql3 = parent::deleteSql("COD_CUR = '{$codCur}'");
		}	
		parent::encerraConexaoSql($conSql);
		
		if($exSql1 != false && $exSql2 != false && $exSql3 != false) return 'true'; else return 'false';
		
	}

	function retornaTituloUsuario($pontos)
	{
		$ptNivel = 170;
		
			if($pontos == 0 || $pontos <= $ptNivel)
				$codTitulo = 1;
			else if($pontos > $ptNivel && $pontos <= $ptNivel * 2)
				$codTitulo = 2;
			else if($pontos > $ptNivel * 2 && $pontos <= $ptNivel * 3)
				$codTitulo = 3;
			else if($pontos > $ptNivel * 3 && $pontos <= $ptNivel * 4)
				$codTitulo = 4;
			else
				$codTitulo = 5;
				
		return $codTitulo;
	}
	
}
if(isset($_GET['acao']))
{
	
	$codCur = $_GET['codCur'];
	$codArt = $_GET['codArt'];
	$codUsu = $_GET['codUsu'];
	$curtir = $_GET['curtir'];
	$obj = new manageCurtir;
	die($obj->curtirArtigo($codCur,$codArt,'1',$codUsu,false));
}
?>