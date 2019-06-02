var google = 0; var amigos = 0; var publicacoes = 0; var outros = 0; var total = 0; var contaGo = contaAm = contaPu = contaOu = 0;
function vota(){
	var inputsEnq = document.getElementById('poll_frm').getElementsByTagName('input');
	for(i=0;i<inputsEnq.length;i++){
		if(inputsEnq[i].type == "radio"){
			if(inputsEnq[i].checked){
				var selecionado = inputsEnq[i].value;
			}
		}
	}
	if(selecionado == "Google") google++; 
	if(selecionado == "Amigos") amigos++;
	if(selecionado == "Publicacoes") publicacoes++;
	if(selecionado == "Outros") outros++;
	document.getElementById("msg_vote").style.display = 'block';
	document.getElementById("content").innerHTML = "Obrigado, voto enviado com sucesso!";
	
}
function resultado(){
	var cx = document.getElementById("poll");
	var total = google + amigos + publicacoes + outros;
	if (total > 0){
		contaGo = (google / total) * 100;
		contaAm = (amigos / total) * 100;
		contaPu = (publicacoes / total) * 100;
		contaOu = (outros / total) * 100;
	}
	cx.innerHTML = "<p id='t_poll'>Enquete</p>";
	cx.innerHTML+= "<p id='text_poll'>Total de votos:" + total + "</p>";
	cx.innerHTML+= "<ul id='enqt2'>";
	cx.innerHTML+= "<li class='pad'>Google: " + parseInt(contaGo) + "%</li>";
	cx.innerHTML+= "<li class='pad'>Amigos: " + parseInt(contaAm) + "%</li>";
	cx.innerHTML+= "<li class='pad'>Publicações: " + parseInt(contaPu) + "%</li>";
	cx.innerHTML+= "<li class='pad'>Outros: " + parseInt(contaOu) + "%</li>";
	cx.innerHTML+= "</ul>";
	cx.innerHTML+= "<div id='enqt2'><a href='javascript: void(0);' onclick='insereForm();' id='back'>Voltar</a>";
}

function insereForm(){
	var form = "<p id='t_poll'>Enquete</p>";
	form+= "<p i>Como você conheceu o<br/>JOI&amp;D?</p>";
	form+= "<form action='' method='POST' name='frmEn'>";
	form+= "<ul id='poll_frm'>";
	form+= "<li><input type='radio' name='tpOp' value='Google' class='styled' />Google</li>";
	form+= "<li><input type='radio' name='tpOp' value='Amigos' class='styled' />Amigos</li>";
	form+= "<li><input type='radio' name='tpOp' value='Publicacoes' class='styled' />Publicações</li>";
	form+= "<li><input type='radio' name='tpOp' value='Outros' class='styled' />Outros</li>";
	form+= "</ul>";
	form+= "<input class='enqt2' id='vote' type='button' name='frmVoto' value='Votar' onclick='vota()' />";
	form+= "<input class='enqt2' type='button' id='result' name='frmResult' value='Resultado'  onclick='resultado()' />";
	form+="</form>";
	document.getElementById("poll").innerHTML = form;
	Custom.init();
}	
window.onload = function(){ insereForm(); }

$(document).ready(function(){
	$('#confirm').click(function(){
		$('#msg_vote').css('display','none');
	});
});
