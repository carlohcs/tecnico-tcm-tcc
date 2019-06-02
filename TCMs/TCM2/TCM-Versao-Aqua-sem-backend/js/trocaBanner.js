$(function(){	
	n = 0;
});
function trocaBanner(){
		var imagem = new Array(4);
		imagem[0] = "<a href='http://www.amazon.com/Command-Conquer-Red-Alert-3-Pc/dp/B0016BVY7U'><img src='img/publicidade/p_bn2.jpg' alt='Publicidade'/></a>";
		imagem[1] = "<a href='http://www.playrf.com'><img src='img/publicidade/p_bn3.jpg' alt='Publicidade'/></a>";
		imagem[2] = "<a href='http://global.4story.com/'><img src='img/publicidade/p_bn4.jpg' alt='Publicidade'/></a>";
		imagem[3] = "<a href='http://www.finalfantasyxiv.com'><img src='img/publicidade/p_bn1.jpg' alt='Publicidade'/></a>";

		$('#banner_adv').html(imagem[n]);
		
		n++;
		if(n>=imagem.length){ n = 0; }	
	}
var tempo2 = window.setInterval("trocaBanner()",4000);