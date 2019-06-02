function insereVideo(){
	var local = document.getElementById("videos");
	var iframe = document.createElement("iframe");
	iframe.setAttribute("id", "youtube");
	//iframe.setAttribute("src", "http://www.youtube.com/embed/9rJCU-Vjwy8");
	iframe.setAttribute("style", "margin-left:40px; width:440px; height: 300px");
	iframe.setAttribute("title", "YouTube video player");
	iframe.setAttribute("frameborder", "0");
	var navegador = navigator.appName;
	if(navegador == 'IE'){ iframe.setAttribute('className', 'youtube-player'); 
	}else{ iframe.setAttribute('class', 'youtube-player'); }
	//iframe.setAttribute('type', 'text/html');	
	local.appendChild(iframe);
}
function trocaVideo(n){
	var videos = new Array(27);
	
	//ESPORTE
	videos[0] = "http://www.youtube.com/embed/xNJNjjTxt7I";
	videos[1] = "http://www.youtube.com/embed/5Eja_EEdEEg";
	videos[2] = "http://www.youtube.com/embed/9rJCU-Vjwy8";
	
	videos[3] = "http://www.youtube.com/embed/vCYMSLbMqOQ";
	videos[4] = "http://www.youtube.com/embed/5Eja_EEdEEg";

	videos[5] = "http://www.youtube.com/embed/v54DEfs1_tY";
	videos[6] = "http://www.youtube.com/embed/0giINXA4NYo";
	
	//AÇÃO
	videos[7] = "http://www.youtube.com/embed/pT0KQCqJGFo";
	videos[8] = "http://www.youtube.com/embed/31S6lTXh23I";
	
	videos[9] = "http://www.youtube.com/embed/ZOLqSm9jioU";
	videos[10] = "http://www.youtube.com/embed/OdJCIWSMP3Y";
	videos[11] = "http://www.youtube.com/embed/48rtsiZHG8Y";
	
	//CLÁSSICOS
	videos[12] = "http://www.youtube.com/embed/SXlwFlX333A";
	videos[13] = "http://www.youtube.com/embed/2IgsL49wcCo";
	videos[14] = "http://www.youtube.com/embed/yHdkCLQdN2A";
	
	videos[15] = "http://www.youtube.com/embed/NqyKpJwk29o";
	videos[16] = "http://www.youtube.com/embed/WLttemu-Xx4";
	videos[17] = "http://www.youtube.com/embed/JEpnHJW9QO0";
	
	//RPG
	videos[18] = "http://www.youtube.com/embed/82TSz2_UDxU";
	videos[19] = "http://www.youtube.com/embed/SyyVVy5tIhk";
	videos[20] = "http://www.youtube.com/embed/N0-24VCcH78";
	
	videos[21] = "http://www.youtube.com/embed/nFkMgksMB8o";
	videos[22] = "http://www.youtube.com/embed/VX8OyD7PCXU";
	videos[23] = "http://www.youtube.com/embed/rylN5UKLbIg";
	
	videos[24] = "http://www.youtube.com/embed/fI-WvgNOCls";
	videos[25] = "http://www.youtube.com/embed/31VpcWV2R9E";
	videos[26] = "http://www.youtube.com/embed/s6kYbXb1MAk";
	
	document.getElementById('youtube').src = videos[n];
}	
window.onload = insereVideo;