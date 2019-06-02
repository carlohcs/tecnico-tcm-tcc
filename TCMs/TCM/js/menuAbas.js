$(document).ready(function() {
	$("#content > div").hide();
	$("#content > div:eq(0)").show();
	$("#tabs > a:eq(0)").css("background", "url(img/aba.png) top left no-repeat");
});
 
function opentab(num) {
	$("#content > div").hide();
	$("#content > div:eq(" + (num-1) + ")").fadeIn();
	$("#tabs > a").css("background", "url(img/aba.png) top left no-repeat");
	$("#tabs > a:eq(" + (num-1) + ")").css("background", "url(img/aba_visit.png) top left no-repeat");	
}