function insereVideo(){
	var local = document.getElementById("box_center");
	var object = document.createElement("object");
	
	var navegador = navigator.appName;
	var param = document.createElement("param");
	
	object.setAttribute("width", "440");
	object.setAttribute("height", "300");
	object.setAttribute("style", "margin-left:40px;");
	
	if(navegador == 'Microsoft Internet Explorer'){ 
	param.setAttribute('name', 'movie');
	param.setAttribute('value', 'http://www.youtube.com/v/bwhlr6arlWg');
	object.setAttribute('id', 'youtube');
	object.setAttribute('classid', 'clsid:D27CDB6E-AE6D-11cf-96B8-444553540000');
	object.setAttribute('codebase', 'http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0');
	}
	else{
	object.setAttribute('id', 'youtube');
	object.setAttribute("data", "http://www.youtube.com/v/bwhlr6arlWg");
	object.setAttribute('type', 'application/x-shockwave-flash');
	object.setAttribute('value', 'http://www.youtube.com/v/bwhlr6arlWg');
	object.setAttribute('name', 'movie');
	}
	local.appendChild(object);
	var local2 = document.getElementById("youtube");
	local2.appendChild(param);
	}
function trocaVideo(n){
	var videos = new Array(4);
	
	//ESPORTE
	videos[0] = "http://www.youtube.com/v/bwhlr6arlWg";
	videos[1] = "http://www.youtube.com/v/5Eja_EEdEEg";
	videos[2] = "http://www.youtube.com/v/9rJCU-Vjwy8";

	
	document.getElementById('youtube').data = videos[n];
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
		"<p class='t_down'>Requisitos de Sistema</p>" + "<p>Voc� j� verificou as configura��es do seu computador?</p>" + 
		"<p>Se o sistema n�o atende os requisitos do jogo, talvez possa ter um desempenho abaixo do desej�vel." +
		"Para garantir uma boa experi�ncia durante a jogabilidade, recomendamos as configura��es abaixo:</p>" +
		"<p class='t_down2'>Requisitos m�nimos</p>" +
		"<ul>" + 
		"<li>Sistema Operacional Windows XP ou posterior do Windows XP ou posterior</li>" +
		"<li>CPU P 3-4-1.8Ghz 1Ghz</li>" +
		"<li>128MB de RAM 256MB</li>" +
		"<li>3GB HDD 1.5GB</li>" +
		"<li>VGA placa 3D Acceleration</li>" +
		"<li>Nenhum som Cart�o de som 16bit</li>" +
		"<li>REDE 56kbps Cable Modem / DSL</li>" +
		"<li>Download DirectX</li>" +
		"<li>Fa�a o download da vers�o de acordo com seu sistema operacional.</li>" +
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