			n = 1;
			function trocaBanner(){
			n++;
			var imagem = new Array(5);
			imagem[0] = "img/banner2.jpg";
			imagem[1] = "img/banner3.jpg";
			imagem[2] = "img/banner4.jpg";
			imagem[3] = "img/banner5.jpg";
			imagem[4] = "img/banner6.jpg";
				document.getElementById('banner_top').style.background = "url("+imagem[n]+") no-repeat";
				if(n>imagem.length){ n = 0; } 
			}
			tempo = setInterval('trocaBanner()', 3000);