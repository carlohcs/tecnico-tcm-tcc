$(function(){	
	n = 1;
	nn = 1;
	$('#banner_top_bt').click(trocaBanner);
});
function trocaBanner(){
		var imagem = new Array(5);
		imagem[0] = "img/banner1.jpg";
		imagem[1] = "img/banner2.jpg";
		imagem[2] = "img/banner3.jpg";
		imagem[3] = "img/banner4.jpg";
		imagem[4] = "img/banner5.jpg";
		imagem[5] = "img/banner6.jpg";
		$('#banner_top').animate({opacity:0.5}, 300).animate({opacity:1}, 300 ).css('background', 'url('+imagem[n]+') no-repeat');
		n++;
		if(n>=imagem.length){ n = 0; }	
	}
function trocaBanner2(){
		var imagem = new Array(4);
		imagem[0] = "img/publicidade/p_bn2.jpg";
		imagem[1] = "img/publicidade/p_bn3.jpg";
		imagem[2] = "img/publicidade/p_bn4.jpg";
		imagem[3] = "img/publicidade/p_bn5.jpg";
		imagem[4] = "img/publicidade/p_bn6.jpg";
		$('#banner').css('background', 'url('+imagem[nn]+') no-repeat');
		nn++;
		if(nn>=imagem.length){ nn = 0; }	
	}	
var tempo = window.setInterval("trocaBanner()",5000);
var tempo2 = window.setInterval("trocaBanner2()",4000);