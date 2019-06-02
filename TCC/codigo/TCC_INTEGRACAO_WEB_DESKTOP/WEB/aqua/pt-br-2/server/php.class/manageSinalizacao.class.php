<?php
	class manageSinalizacao extends sqlInstruction
	{
		
		function sinalizarUsuario($arrPost)
		{
			
			if($arrPost['tipo'] == 'noticias') $cmtEnt = 'NOT'; else if($arrPost['tipo'] == 'artigo') $cmtEnt = 'ART'; else $cmtEnt = 'DEST';
			
			$conSql = parent::conexaoSql();parent::defineEntidade('sinalizacao_'.$arrPost['tipo']);
			
			if(parent::SQLSERVER == true)
			{
				$exSql = parent::insertSql("'{$arrPost['codPost']}', '{$arrPost['codUsuSinalizado']}','{$arrPost['codUsuSinalizando']}',
				'{$arrPost['codComentario']}','{$arrPost['codMotivo']}'",'relative');
				
			}	
			else
				$exSql = parent::insertSql("'null', '{$arrPost['codPost']}', '{$arrPost['codUsuSinalizado']}','{$arrPost['codUsuSinalizando']}',
			'{$arrPost['codComentario']}','{$arrPost['codMotivo']}'",'relative');
			
			if($exSql != false) echo 1; else echo 0;
			
		}	
		
	}
?>	