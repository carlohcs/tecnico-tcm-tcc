<?php
//include("sqlInstruction.class.php");
	class manageSinalizacao extends sqlInstruction
	{
		
		function sinalizarUsuario($arrPost)
		{
			
			
			if($arrPost['tipo'] == 'noticias') $cmtEnt = 'noticias'; else if($arrPost['tipo'] == 'artigo') $cmtEnt = 'artigo'; else $cmtEnt = 'destaque';
			
			$conSql = parent::conexaoSql();parent::defineEntidade('sinalizacao_'.$cmtEnt);
			
			
				$exSql = parent::insertSql("'{$arrPost['codPost']}', '{$arrPost['codUsuSinalizado']}','{$arrPost['codUsuSinalizando']}',
				'{$arrPost['codComentario']}','{$arrPost['codMotivo']}'",'relative');
			
//die(var_dump($exSql));			
	//			echo "INSTRUCAO: ".parent::retornaInstrucaoSql();
			
			
			if($exSql != false) echo 1; else echo 0;
			
		}	
		
	}
	/*if(isset($_GET))
	{
	
	$obj = new manageSinalizacao;
	$exSql = $obj->sinalizarUsuario($_GET);
	var_dump($exSql);
	}*/
?>	