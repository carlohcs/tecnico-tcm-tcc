var n = 0;
function troca(param1,param2,param3)
{
	
	//Param1 = $caminhoImg | Param2 = $titulos | Param3 = $links
	
	var retorno = new Array();
	retorno['caminhoImg'] = param1.split("|");
	retorno['titulos'] = param2.split("|");
	retorno['links'] = param3.split("|");
	
	var imagem = new Array(4);
	imagem[0] = "<a href='http://" + retorno['links'][0] + "'><img src='" + retorno['caminhoImg'][0] + "' title='" + retorno['titulos'][0] + "' alt='Publicidade' /></a>";
	imagem[1] = "<a href='http://" + retorno['links'][1] + "'><img src='" + retorno['caminhoImg'][1] + "' title='" + retorno['titulos'][1] + "' alt='Publicidade' /></a>";
	imagem[2] = "<a href='http://" + retorno['links'][2] + "'><img src='" + retorno['caminhoImg'][2] + "' title='" + retorno['titulos'][2] + "' alt='Publicidade' /></a>";
	imagem[3] = "<a href='http://" + retorno['links'][3] + "'><img src='" + retorno['caminhoImg'][3] + "' title='" + retorno['titulos'][3] + "' alt='Publicidade' /></a>";

	//$('#banner_adv').html(imagem[n]);
	document.getElementById("banner_adv").innerHTML = imagem[n];
			
	n++;
	
	if(n>=imagem.length){ n = 0; }
	
	
	
}
//var tmpPub = window.setInterval("troca('" + param1 + "', '" + param2 + "', '" + param3 + "')",4000);
//var tempo2 = window.setInterval("trocaPublicidade(" + param1 + ", " + param2 + ", " + param3 + ")",4000);
//var tempo2 = window.setInterval("trocaBanner()",4000);