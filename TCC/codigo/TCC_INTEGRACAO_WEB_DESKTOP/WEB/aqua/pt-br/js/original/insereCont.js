function insereVideo(){
	var local = document.getElementById("box_center");
	var iframe = document.createElement("iframe");
	iframe.setAttribute("id", "youtube");
	iframe.setAttribute("src", "http://www.youtube.com/v/9rJCU-Vjwy8&color1=0x000000&color2=0x000000");
	iframe.setAttribute("style", "margin-left:40px; width:440px; height: 300px");
	iframe.setAttribute("title", "YouTube video player");
	iframe.setAttribute("frameborder", "0");
	var navegador = navigator.appName;
	if(navegador == 'IE'){ iframe.setAttribute('className', 'youtube-player'); 
	}else{ iframe.setAttribute('class', 'youtube-player');	}
	iframe.setAttribute('type', 'application/x-shockwave-flash');	
	local.appendChild(iframe);
}
function trocaVideo(n){
	var videos = new Array(27);
	
	//ESPORTE
	videos[0] = "http://www.youtube.com/v/xNJNjjTxt7I";
	videos[1] = "http://www.youtube.com/v/5Eja_EEdEEg";
	videos[2] = "http://www.youtube.com/v/9rJCU-Vjwy8";
	
	videos[3] = "http://www.youtube.com/v/vCYMSLbMqOQ";
	videos[4] = "http://www.youtube.com/v/5Eja_EEdEEg";

	videos[5] = "http://www.youtube.com/v/v54DEfs1_tY";
	videos[6] = "http://www.youtube.com/v/0giINXA4NYo";
	
	//AÇÃO
	videos[7] = "http://www.youtube.com/v/pT0KQCqJGFo";
	videos[8] = "http://www.youtube.com/v/31S6lTXh23I";
	
	videos[9] = "http://www.youtube.com/v/ZOLqSm9jioU";
	videos[10] = "http://www.youtube.com/v/OdJCIWSMP3Y";
	videos[11] = "http://www.youtube.com/v/48rtsiZHG8Y";
	
	//CLÁSSICOS
	videos[12] = "http://www.youtube.com/v/SXlwFlX333A";
	videos[13] = "http://www.youtube.com/v/2IgsL49wcCo";
	videos[14] = "http://www.youtube.com/v/yHdkCLQdN2A";
	
	videos[15] = "http://www.youtube.com/v/NqyKpJwk29o";
	videos[16] = "http://www.youtube.com/v/WLttemu-Xx4";
	videos[17] = "http://www.youtube.com/v/JEpnHJW9QO0";
	
	//RPG
	videos[18] = "http://www.youtube.com/v/82TSz2_UDxU";
	videos[19] = "http://www.youtube.com/v/SyyVVy5tIhk";
	videos[20] = "http://www.youtube.com/v/N0-24VCcH78";
	
	videos[21] = "http://www.youtube.com/v/nFkMgksMB8o";
	videos[22] = "http://www.youtube.com/v/VX8OyD7PCXU";
	videos[23] = "http://www.youtube.com/v/rylN5UKLbIg";
	
	videos[24] = "http://www.youtube.com/v/fI-WvgNOCls";
	videos[25] = "http://www.youtube.com/v/31VpcWV2R9E";
	videos[26] = "http://www.youtube.com/v/s6kYbXb1MAk";
	
	document.getElementById('youtube').src = videos[n] + "&color1=0x000000&color2=0x000000";
}
function imagens(){
	var local = document.getElementById("box_center");
	local.innerHTML = "<ul>";
	for(i=1;i<6;i++){
		local.innerHTML+= "<li><a href='galeria/0" + i + ".jpg' rel='clbx' title='Maple Story "+i+"'><img src='galeria/0" + i + ".jpg' alt='Imagem "+i+"' rel='cl' /></a></li>";
	}	
	local.innerHTML+= "</ul>";
	local.innerHTML+="<div style='clear: both; margin-bottom: 5px;'></div>";
	//Colorbox
	$("a[rel='clbx']").colorbox();
}
	//Adicionando Videos
$(function(){
	$('#menu_box ul li a:eq(0)').click(function(){
		$('#box_center').html("");
	});
	$('#menu_box ul li a:eq(1)').click(function(){
		$('#box_center').html("");
		imagens();
	});
	$('#menu_box ul li a:eq(2)').click(function(){
		$('#box_center').html("");
		insereVideo();
		$('#box_center').append(
			'<p onclick="trocaVideo(0);">UM</p>' +
			'<p onclick="trocaVideo(1);">DOIS</p>' +
			'<p onclick="trocaVideo(2);">TRES</p>'
		);
	});
});	