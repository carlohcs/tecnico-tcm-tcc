<?php

	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/sqlInstruction.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manageSession.class.php");
	include_once($_SERVER['DOCUMENT_ROOT']."/TCC/aqua/pt-br/server/php.class/manipulationData.class.php");
	
	$obj = new manipulationData;
	$resp = $obj->excluirUsuario();
	
	/*if($resp != false)
	{
		$obj = new manageSession;
		$logout = $obj->encerraSessaoUsuario();
	}*/
	//var_dump($logout);
	var_dump($resp);
	
	//header("Location: ".$logout);
/*
DELETE u,ar, cA, cD, cN, cAr, rnk
FROM usuario AS u
LEFT JOIN artigo AS ar ON ar.COD_USU = u.COD_USU 
LEFT JOIN comentario_artigo AS cA ON cA.COD_USU = u.COD_USU
LEFT JOIN comentario_destaque AS cD ON cD.COD_USU = u.COD_USU
LEFT JOIN comentario_noticia AS cN ON cN.COD_USU = u.COD_USU
LEFT JOIN curtir_artigo AS cAr ON cAr.COD_USU = u.COD_USU
LEFT JOIN ranking_usuario AS rnk ON rnk.COD_USU = u.COD_USU
WHERE u.COD_USU = 2

--DEU CERTO
DELETE u,ar, cA, cD, cN, cAr, rnk, snA, snD, snN
FROM usuario AS u
LEFT JOIN artigo AS ar ON ar.COD_USU = u.COD_USU 
LEFT JOIN comentario_artigo AS cA ON cA.COD_USU = u.COD_USU
LEFT JOIN comentario_destaque AS cD ON cD.COD_USU = u.COD_USU
LEFT JOIN comentario_noticia AS cN ON cN.COD_USU = u.COD_USU
LEFT JOIN curtir_artigo AS cAr ON cAr.COD_USU = u.COD_USU
LEFT JOIN ranking_usuario AS rnk ON rnk.COD_USU = u.COD_USU
LEFT JOIN sinalizacao_artigo AS snA ON snA.COD_USU_SINALIZADO = u.COD_USU OR snA.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_destaque AS snD ON snD.COD_USU_SINALIZADO = u.COD_USU OR snD.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_noticia AS snN ON snN.COD_USU_SINALIZADO = u.COD_USU OR snN.COD_USU_SINALIZAR = u.COD_USU
WHERE u.COD_USU = 11
--DEU CERTO

DELETE u,ar, cA, cD, cN, cAr, rnk,snA,snD,snN
FROM usuario AS u
LEFT JOIN artigo AS ar ON a.COD_USU = u.COD_USU 
LEFT JOIN comentario_artigo AS cA ON cA.COD_USU = u.COD_USU
LEFT JOIN comentario_destaque AS cD ON cD.COD_USU = u.COD_USU
LEFT JOIN comentario_noticia AS cN ON cN.COD_USU = u.COD_USU
LEFT JOIN curtir_artigo AS cAr ON cAr.COD_USU = u.COD_USU
LEFT JOIN ranking_usuario AS rnk ON rnk.COD_USU = u.COD_USU
LEFT JOIN sinalizacao_artigo AS snA ON snA.COD_USU_SINALIZADO = u.COD_USU,snA.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_destaque AS snD ON snD.COD_USU_SINALIZADO = u.COD_USU,snD.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_noticia AS snN ON snN.COD_USU_SINALIZADO = u.COD_USU,snN.COD_USU_SINALIZAR = u.COD_USU
WHERE u.COD_USU = 2





DELETE u,ar, cA, cD, cN, cAr, rnk, snA, snA1, snD, snD1, snN, snN1
FROM usuario AS u
LEFT JOIN artigo AS ar ON ar.COD_USU = u.COD_USU 
LEFT JOIN comentario_artigo AS cA ON cA.COD_USU = u.COD_USU
LEFT JOIN comentario_destaque AS cD ON cD.COD_USU = u.COD_USU
LEFT JOIN comentario_noticia AS cN ON cN.COD_USU = u.COD_USU
LEFT JOIN curtir_artigo AS cAr ON cAr.COD_USU = u.COD_USU
LEFT JOIN ranking_usuario AS rnk ON rnk.COD_USU = u.COD_USU
LEFT JOIN sinalizacao_artigo AS snA ON snA.COD_USU_SINALIZADO = u.COD_USU OR snA.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_destaque AS snD ON snD.COD_USU_SINALIZADO = u.COD_USU OR snD.COD_USU_SINALIZAR = u.COD_USU
LEFT JOIN sinalizacao_noticia AS snN ON snN.COD_USU_SINALIZADO = u.COD_USU OR snN.COD_USU_SINALIZAR = u.COD_USU
WHERE u.COD_USU = 2
*/
?>