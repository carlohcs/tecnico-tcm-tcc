<?php
	class manageComentario extends sqlInstruction
	{
		
		function listaComentarioArtigo($codArt)
		{
			
			$conSql = parent::conexaoSql(); parent::defineEntidade('comentario_artigo, artigo, usuario');
			
			$objRespo = parent::selectSql("artigo.COD_ART,comentario_artigo.COD_CMT,comentario_artigo.DT_CMT, comentario_artigo.TXT_CMT, usuario.LOG_USU, usuario.FT_USU, usuario.COD_USU", 
			"comentario_artigo.COD_ART = artigo.COD_ART AND comentario_artigo.COD_USU = usuario.COD_USU AND artigo.COD_ART =".$codArt."", '', '',false);
			
			if($objRespo != false)
			{
			
				$retornoArray = array(); $retornoArray['numLinhas'] = mysql_num_rows($objRespo);
			
				while($dadosRetorno = parent::fetch($objRespo))
				{
					$retornoArray['txtComentario'][] = $dadosRetorno['TXT_CMT'];
					$retornoArray['dtComentario'][] = parent::formataData($dadosRetorno['DT_CMT']);
					$retornoArray['usuComentario'][] = $dadosRetorno['LOG_USU'];
					$retornoArray['usuFoto'][] = $dadosRetorno['FT_USU'];
					$retornoArray['codUsu'][] = $dadosRetorno['COD_USU'];
					$retornoArray['codArt'][] = $dadosRetorno['COD_ART'];
					$retornoArray['codComent'][] = $dadosRetorno['COD_CMT'];
				}
			
				parent::encerraConexaoSql($conSql);
				
				return $retornoArray;
			
			}else return false;
			
	
		}
		
		function listaComentarioDestaque($codDest)
		{
			
			$conSql = parent::conexaoSql(); parent::defineEntidade('comentario_destaque, destaque, usuario');
			
			$objRespo = parent::selectSql("destaque.COD_DEST,comentario_destaque.COD_CMT,comentario_destaque.DT_CMT, comentario_destaque.TXT_CMT, usuario.LOG_USU, usuario.FT_USU, usuario.COD_USU", 
			"comentario_destaque.COD_DEST = destaque.COD_DEST AND comentario_destaque.COD_USU = usuario.COD_USU AND destaque.COD_DEST =".$codDest."", '', '',false);
			
			if($objRespo != false)
			{
						
				while($dadosRetorno = parent::fetch($objRespo))
				{
					$retornoArray['txtComentario'][] = $dadosRetorno['TXT_CMT'];
					$retornoArray['dtComentario'][] = parent::formataData($dadosRetorno['DT_CMT']);
					$retornoArray['usuComentario'][] = $dadosRetorno['LOG_USU'];
					$retornoArray['usuFoto'][] = $dadosRetorno['FT_USU'];
					$retornoArray['codUsu'][] = $dadosRetorno['COD_USU'];
					$retornoArray['codDest'][] = $dadosRetorno['COD_DEST'];
					$retornoArray['codComent'][] = $dadosRetorno['COD_CMT'];
				}
						
				parent::encerraConexaoSql($conSql);
				
				return $retornoArray;
			
			}else return false;
			
	
		}
		
		function listaComentarioNoticia($codNot)
		{
			
			$conSql = parent::conexaoSql(); parent::defineEntidade('comentario_noticia, noticias, usuario');
			
			$objRespo = parent::selectSql("noticias.COD_NOT,comentario_noticia.COD_CMT,comentario_noticia.DT_CMT, comentario_noticia.TXT_CMT, usuario.LOG_USU, usuario.FT_USU, usuario.COD_USU",
			"comentario_noticia.COD_NOT = noticias.COD_NOT AND comentario_noticia.COD_USU = usuario.COD_USU AND noticias.COD_NOT =".$codNot."", '', '',false);
			
			if($objRespo != false)
			{
			
				$retornoArray = array(); $retornoArray['numLinhas'] = parent::rows($objRespo);
			
				
				while($dadosRetorno = parent::fetch($objRespo))
				{
					$retornoArray['txtComentario'][] = $dadosRetorno['TXT_CMT'];
					$retornoArray['dtComentario'][] = parent::formataData($dadosRetorno['DT_CMT']);
					$retornoArray['usuComentario'][] = $dadosRetorno['LOG_USU'];
					$retornoArray['usuFoto'][] = $dadosRetorno['FT_USU'];
					$retornoArray['codUsu'][] = $dadosRetorno['COD_USU'];
					$retornoArray['codNot'][] = $dadosRetorno['COD_NOT'];
					$retornoArray['codComent'][] = $dadosRetorno['COD_CMT'];
				}
				
				parent::encerraConexaoSql($conSql);
				
				return $retornoArray;
			
			}else return false;
			
	
		}
		
		function comentario($codPost,$codUsu,$txtComment,$tpCommt)
		{
			
			$conSql = parent::conexaoSql(); 
			$dtCo = date("Y/m/d");
			
			if($tpCommt == 'comentarioArtigo') parent::defineEntidade('comentario_artigo');				
			else	if($tpCommt == 'comentarioNoticia') parent::defineEntidade('comentario_noticia'); 
			else parent::defineEntidade('comentario_destaque');
				
			if(parent::SQLSERVER == TRUE)
				$objRespo = parent::insertSql("'{$txtComment}', '{$dtCo}', '{$codUsu}', '{$codPost}'",'relative');					
			else
				$objRespo = parent::insertSql("'null', '{$txtComment}', '{$dtCo}', '{$codUsu}', '{$codPost}'",'relative');					
			
			parent::encerraConexaoSql($conSql);
			
			if($objRespo != false) return 'true'; else return 'false';
									
		}
		
		function exibeComentarioEcho($codPost,$type){
			
			if($type == 'artigo')	$arrComent = self::listaComentarioArtigo($codPost);
			else if($type == 'noticias') $arrComent = self::listaComentarioNoticia($codPost);
			else $arrComent = self::listaComentarioDestaque($codPost);
			
			$getUser = isset($_GET['user']) ? $_GET['user'] : FALSE;
			$verificaSess = ((!empty($_SESSION)) && ($_SESSION['sessaoUsuario']['logado'] == true)) ? true : false;
			
			$usuSinalizando = ($verificaSess == true) ? $_SESSION['sessaoUsuario']['codigo'] : '';
			
			$html = "";
			
			if($arrComent != false){
			
				$html.= "<ul>";
				
				for($i=0;$i<$arrComent['numLinhas'];$i++)
				{
					$html.= "<li>".$arrComent['dtComentario'][$i]."</li>";
					$html.= "<li><img src='".$arrComent['usuFoto'][$i]."' /></li>";
					$html.= "<li><a href='perfil/".$arrComent['usuComentario'][$i]."'>".$arrComent['usuComentario'][$i]."</a></li>";
					$html.= "<li>".$arrComent['txtComentario'][$i]."</li>";
					if($type == 'artigo'){ if(!empty($_SESSION) && $_SESSION['sessaoUsuario']['codigo'] != $arrComent['codUsu'][$i]) $html.= "<li><button class='sinalizar' value='artigo|{$arrComent['codArt'][$i]}|{$arrComent['codUsu'][$i]}|{$usuSinalizando}|{$arrComent['codComent'][$i]}'>Sinalizar</button></li>";}
					else if($type == 'noticias'){ if(!empty($_SESSION) && $_SESSION['sessaoUsuario']['codigo'] != $arrComent['codUsu'][$i]) $html.= "<li><button class='sinalizar' value='noticias|{$arrComent['codNot'][$i]}|{$arrComent['codUsu'][$i]}|{$usuSinalizando}|{$arrComent['codComent'][$i]}'>Sinalizar</button></li>";}
					else { if(!empty($_SESSION) && $_SESSION['sessaoUsuario']['codigo'] != $arrComent['codUsu'][$i]) $html.= "<li><button class='sinalizar' value='destaque|{$arrComent['codDest'][$i]}|{$arrComent['codUsu'][$i]}|{$usuSinalizando}|{$arrComent['codComent'][$i]}'>Sinalizar</button></li>";}
				}
				
				$html.= "</ul>";
			
				echo $html;
				
			}else{
				
				if($verificaSess == true) echo "<p>".$_SESSION['sessaoUsuario']['nome'].", seja o primeiro a comentar!</p>";	
				else echo "<p>Seja o primeiro a comentar.</p>";
			}
			if($verificaSess == false) $permCmt = 'false'; else $permCmt = 'true';
		}	
	
	}

?>