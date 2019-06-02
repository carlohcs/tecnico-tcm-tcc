var checkboxHeight = "25";
var radioHeight = "25";
var selectWidth = "190";

document.write('<style type="text/css">input.styled { display: none; } select.styled { position: relative; width: ' + selectWidth + 'px; opacity: 0; filter: alpha(opacity=0); z-index: 5; } .disabled { opacity: 0.5; filter: alpha(opacity=50); }</style>');

var Custom = {
	init: function() {
		var inputs = document.getElementsByTagName("input"), span = Array(), textnode, option, active;
		for(a = 0; a < inputs.length; a++) {
			if((inputs[a].type == "checkbox" || inputs[a].type == "radio") && inputs[a].className == "styled") {
				span[a] = document.createElement("span");
				span[a].className = inputs[a].type;

				if(inputs[a].checked == true) {
					if(inputs[a].type == "checkbox") {
						position = "0 -" + (checkboxHeight*2) + "px";
						span[a].style.backgroundPosition = position;
					} else {
						position = "0 -" + (radioHeight*2) + "px";
						span[a].style.backgroundPosition = position;
					}
				}
				inputs[a].parentNode.insertBefore(span[a], inputs[a]);
				inputs[a].onchange = Custom.clear;
				if(!inputs[a].getAttribute("disabled")) {
					span[a].onmousedown = Custom.pushed;
					span[a].onmouseup = Custom.check;
				} else {
					span[a].className = span[a].className += " disabled";
				}
			}
		}
		inputs = document.getElementsByTagName("select");
		for(a = 0; a < inputs.length; a++) {
			if(inputs[a].className == "styled") {
				option = inputs[a].getElementsByTagName("option");
				active = option[0].childNodes[0].nodeValue;
				textnode = document.createTextNode(active);
				for(b = 0; b < option.length; b++) {
					if(option[b].selected == true) {
						textnode = document.createTextNode(option[b].childNodes[0].nodeValue);
					}
				}
				span[a] = document.createElement("span");
				span[a].className = "select";
				span[a].id = "select" + inputs[a].name;
				span[a].appendChild(textnode);
				inputs[a].parentNode.insertBefore(span[a], inputs[a]);
				if(!inputs[a].getAttribute("disabled")) {
					inputs[a].onchange = Custom.choose;
				} else {
					inputs[a].previousSibling.className = inputs[a].previousSibling.className += " disabled";
				}
			}
		}
		document.onmouseup = Custom.clear;
	},
	pushed: function() {
		element = this.nextSibling;
		if(element.checked == true && element.type == "checkbox") {
			this.style.backgroundPosition = "0 -" + checkboxHeight*3 + "px";
		} else if(element.checked == true && element.type == "radio") {
			this.style.backgroundPosition = "0 -" + radioHeight*3 + "px";
		} else if(element.checked != true && element.type == "checkbox") {
			this.style.backgroundPosition = "0 -" + checkboxHeight + "px";
		} else {
			this.style.backgroundPosition = "0 -" + radioHeight + "px";
		}
	},
	check: function() {
		element = this.nextSibling;
		if(element.checked == true && element.type == "checkbox") {
			this.style.backgroundPosition = "0 0";
			element.checked = false;
		} else {
			if(element.type == "checkbox") {
				this.style.backgroundPosition = "0 -" + checkboxHeight*2 + "px";
			} else {
				this.style.backgroundPosition = "0 -" + radioHeight*2 + "px";
				group = this.nextSibling.name;
				inputs = document.getElementsByTagName("input");
				for(a = 0; a < inputs.length; a++) {
					if(inputs[a].name == group && inputs[a] != this.nextSibling) {
						inputs[a].previousSibling.style.backgroundPosition = "0 0";
					}
				}
			}
			element.checked = true;
		}
	},
	clear: function() {
		inputs = document.getElementsByTagName("input");
		for(var b = 0; b < inputs.length; b++) {
			if(inputs[b].type == "checkbox" && inputs[b].checked == true && inputs[b].className == "styled") {
				inputs[b].previousSibling.style.backgroundPosition = "0 -" + checkboxHeight*2 + "px";
			} else if(inputs[b].type == "checkbox" && inputs[b].className == "styled") {
				inputs[b].previousSibling.style.backgroundPosition = "0 0";
			} else if(inputs[b].type == "radio" && inputs[b].checked == true && inputs[b].className == "styled") {
				inputs[b].previousSibling.style.backgroundPosition = "0 -" + radioHeight*2 + "px";
			} else if(inputs[b].type == "radio" && inputs[b].className == "styled") {
				inputs[b].previousSibling.style.backgroundPosition = "0 0";
			}
		}
	},
	choose: function() {
		option = this.getElementsByTagName("option");
		for(d = 0; d < option.length; d++) {
			if(option[d].selected == true) {
				document.getElementById("select" + this.name).childNodes[0].nodeValue = option[d].childNodes[0].nodeValue;
			}
		}
	}
}

$(document).ready(function(){
	Custom.init();
	$('#bg_cbanner ul').cycle({
		//pausa imagens ao passar mouse
		pause: true,
		//pausa imagens ao passar mouse
		pauseOnPagerHover: true, 
		prev:    '#prev_cbanner',
		next:    '#next_cbanner',
		pager:   '#btn_cbanner',
		pagerAnchorBuilder: pagerFactory,

		before: function(atual, proximo, opcoes, avancando){
			$('.fundo',atual).slideUp('slow');
		},
		
		after: function(atual, proximo, opcoes, avancando){
			$('.fundo',proximo).slideDown('slow');
		}
	});
	 function pagerFactory(idx, slide){
		var s = idx > 3 ? ' style="display:none "' : '';
		return '<li'+s+'><a href="#" id="link">'+(idx+1)+'</a></li>';
	}

	//Pega os campos
	var login = $("input[type=text][name=login]");
	var senha = $("input[type=password][name=senha]");
	var search = $("input[type=text][name=search]");
	
	//Propriedades para o campo Login
	login.css({'color':'#fff', 'font-style':'italic'});
	login.focus(function(){ login.css({'color':'#fff','font-style':'normal'}); if(($(this).val()) == "nome de usuário"){ $(this).val("");} });
	login.blur(function(){ if(($(this).val()) == "usuário"){ $(this).val(""); } if(($(this).val()) == ""){ $(this).val("nome de usuário"); login.css({'color':'#fff', 'font-style':'italic'});} });
	
	//Propriedades para o campo Senha
	senha.focus(function(){ senha.css({'color':'#fff','font-style':'normal'}); if(($(this).val()) == "************"){ $(this).val("");} });
	senha.blur(function(){ if(($(this).val()) == "************"){ $(this).val(""); } if(($(this).val()) == ""){ $(this).val("************"); senha.css({'color':'#fff'});} });
	
	//Propriedades para o campo Buscar
	search.css({'color':'#fff', 'font-style':'italic'});
	search.focus(function(){ search.css({'color':'#fff','font-style':'normal'}); if(($(this).val()) == "palavra-chave..."){ $(this).val("");} });
	search.blur(function(){ if(($(this).val()) == "palavra-chave..."){ $(this).val(""); } if(($(this).val()) == ""){ $(this).val("palavra-chave..."); search.css({'color':'#fff', 'font-style':'italic'});} });
	
	//Carrega para os dados inciais
	login.val("nome de usuário");
	search.val("palavra-chave...");
		
	//Manipula efeitos dos parceiros
	var parc = $('.parce');
	parc.css('opacity',0.2);
	parc.mouseover(function(){ $(this).stop().animate({opacity: 1}, 500); });
	parc.mouseout(function(){ $(this).stop().animate({opacity: 0.2}, 500); });
	
	 //Contador do textarea 
	$("#txtare").focus(function(){
		//A cada 100 milesegundos, executa a função por causa do focus
		interval = window.setInterval(fc,100);
		function fc(){  
			var valortxt = $("#txtare").val().length;
			$("#conttxt").text("Faltam " + eval(100 - valortxt) + " caracteres.");
			if(valortxt > 100){ $("#txtare").val($("#txtare").val().substring(0,100)); }
		}});
	$("#txtare").blur(function(){ clearInterval(interval); });

	
	//Aplica efeito em backTop
	$(window).scroll(function(){
		if (window.scrollY) scrSt = window.scrollY; else if (document.documentElement.scrollTop) scrSt = document.documentElement.scrollTop;
		else	scrSt = document.body.scrollTop;
		if(scrSt >= 171){ $('#backTop').stop().animate({'opacity': 1}, 600, 'linear'); }else{ $('#backTop').stop().animate({'opacity': 0}, 600, 'linear');}
	});
	$('#backTop').click(function(){
		$(this).stop().animate({'opacity': 0}, 600, 'linear');
	});
	
	//Sharer
	$('#stSharer').toggle(
		function(){ $('#sharer').animate({opacity: 1.0, left: '1150px'}, 500); $(this).css('background','url(img/sharer/setaEsq.png) no-repeat'); 
		}, 
		function(){ $('#sharer').animate({opacity: 0, left: '1050px'}, 500); $(this).css('background','url(img/sharer/setaDir.png) no-repeat');
		} 
	);
	
	//Efeito menu
	$('#menu_top, #bgdown_banner').hover(function(){ $('#bgdown_banner').stop().animate({opacity: 0.0}, 500); });
	$('#menu_top, #bgdown_banner').mouseout(function(){ $('#bgdown_banner').stop().animate({opacity: 1}, 500);	});
	
});
