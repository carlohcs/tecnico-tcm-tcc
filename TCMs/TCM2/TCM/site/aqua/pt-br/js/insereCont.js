function insereVideo(){
		var local = document.getElementById("box_center");
	var iframe = document.createElement("iframe");
	iframe.setAttribute("id", "youtube");
	iframe.setAttribute("src", "http://www.youtube.com/embed/9rJCU-Vjwy8");
	iframe.setAttribute("style", "margin-left:40px; width:440px; height: 300px");
	iframe.setAttribute("title", "YouTube video player");
	iframe.setAttribute("frameborder", "0");
	local.appendChild(iframe);
	}
function trocaVideo(n){
	var videos = new Array();
	
	//ESPORTE
	videos[0] = "http://www.youtube.com/v/bwhlr6arlWg";
	videos[1] = "http://www.youtube.com/v/5Eja_EEdEEg";
	videos[2] = "http://www.youtube.com/v/9rJCU-Vjwy8";

	
	document.getElementById('youtube').src = videos[n];
}	
function imagens(){
	var local = document.getElementById("box_center");
	local.innerHTML = "<ul>";
	for(i=1;i<8;i++){
		local.innerHTML+= "<li class='gallery'><a  href='galeria/0" + i + ".jpg' rel='clbx' title='Maple Story "+i+"'><img class='gallery_img' src='galeria/0" + i + ".jpg' alt='Imagem "+i+"' rel='cl' /></a></li>";
	}	
	local.innerHTML+= "</ul>";
	local.innerHTML+="<div id='t_screen' style='clear: both; padding-bottom: 35px;'><p>Screenshots</p></div>";
	//Colorbox
	$("a[rel='clbx']").colorbox();
}
	//Adicionando Videos
$(function(){
	$('#menu_box ul li a:eq(0)').click(function(){
		$('#box_center').html("");
		$('#box_center').html("<p class='t_down'><strong>Download</strong></p>" +
		"<p><strong><a href='http://download2.nexon.net/Game/MapleStory/Downloader/MSDownloaderV98.exe'>Clique aqui</a></strong> para fazer o download.</p>" +
		"<p class='t_down'>Requisitos de Sistema</p>" + "<p>Você já verificou as configurações do seu computador?</p>" + 
		"<p>Se o sistema não atende os requisitos do jogo, talvez possa ter um desempenho abaixo do desejável." +
		"Para garantir uma boa experiência durante a jogabilidade, recomendamos as configurações abaixo:</p>" +
		"<p class='t_down2'>Requisitos mínimos</p>" +
		"<ul>" + 
		"<li>Sistema Operacional Windows XP ou posterior do Windows XP ou posterior</li>" +
		"<li>CPU P 3-4-1.8Ghz 1Ghz</li>" +
		"<li>128MB de RAM 256MB</li>" +
		"<li>3GB HDD 1.5GB</li>" +
		"<li>VGA placa 3D Acceleration</li>" +
		"<li>Nenhum som Cartão de som 16bit</li>" +
		"<li>REDE 56kbps Cable Modem / DSL</li>" +
		"<li>Download DirectX</li>" +
		"<li>Faça o download da versão de acordo com seu sistema operacional.</li>" +
		"</ul>");
	});
	$('#menu_box ul li a:eq(1)').click(function(){
		$('#box_center').html("");
		imagens();
	});
	$('#menu_box ul li a:eq(2)').click(function(){
		$('#box_center').html("");
		insereVideo();
		$('#box_center').append(
			'<p onclick="trocaVideo(0);">Video 1</p>' +
			'<p onclick="trocaVideo(1);">Video 2</p>' +
			'<p onclick="trocaVideo(2);">Vodeo 3</p>'
		);
	});
});	