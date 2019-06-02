$(function(){
	var flagAcao = true;

	var flagAcaoBtn = true;
	//MAIS NOTICIAS NA PÁGINA PRINCIPAL
	$('#btn_list_plus').click(function(e){
		e.preventDefault();
		if(flagAcao == true){
		$.ajax({
			url: "server/php.class/retornaDadosClasseAjax.php",
			type: "POST",
			data: {postAcao: 'maisNoticias', qtdNot: 7, vlAtual: $("#vlAtualNot").val()},
			async: true,
			dataType: "text",
			beforeSend: function() {
				$("#bg_list_article").append("<img src='img/loading.gif' id='load' />");
				var w = ($('#bg_list_article').width() - $('#load').width()) / 2;
				var h = ($('#bg_list_article').height() - $('#load').height()) / 2;
				$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
			},
			complete: function(){
				$("#load").remove();
			},
			error: function(){
				$("#bg_list_article").append("<p id='list_news_high'>Desculpe, página não encontrada no servidor. Contate o administrador.</p>");
			},
			success: function(data){
				var strNova = data.split("|");
				
				var noticia = new Array();var linkNoticia = new Array();var dataNoticia = new Array(); var cont1 = 0; var cont2 = 0; var cont3 = 0;
				for(i=0;i<7;i++){ noticia[cont1] = strNova[i]; cont1++;}
				for(i=7;i<14;i++){ linkNoticia[cont2] = strNova[i]; cont2++;}
				for(i=14;i<21;i++){ dataNoticia[cont3] = strNova[i]; cont3++;}
				
				for(i=0;i<7;i++) $("#bg_list_li").append('<li>' +	'<span>' + dataNoticia[i] + '</span>' + '<a href="noticias/' + linkNoticia[i] + '">' + noticia[i] + '</a>' + '</li>');
				
				flagAcao = false; flagAcaoBtn = false;
				$('#btn_list_plus').css('background','url("img/btn_list_less.png")');
			}
		});
		}
		else
		{
			if(flagAcaoBtn == false){ $('#btn_list_plus').css('background','url("img/btn_list_plus.png")');	$("#bg_list_li li").eq(6).nextAll('li').hide('slow'); flagAcaoBtn = true;}
			else{$('#btn_list_plus').css('background','url("img/btn_list_less.png")');	$("#bg_list_li li").eq(6).nextAll('li').show('slow'); flagAcaoBtn = false;}
		}
	});
	//-----MAIS NOTICIAS NA PÁGINA PRINCIPAL
	
	//BUSCA DO USUÁRIO
	var tit = $('#title_game').text();
	$('#c_search').keydown(function(){
		
		if($(this).val().length >= 2)
		{
		$('#title_game').text("Busca");
			$.ajax({
				url: "server/php.class/retornaDadosClasseAjax.php",
				type: "POST",
				data: {postAcao: 'buscaPalChave', valorBusca: $(this).val()},
				async: true,
				dataType: "xml",
				beforeSend: function() {
					$("#box_center").html("<img src='img/loading.gif' id='load' />");
					var w = ($('#box_center').width() - $('#load').width()) / 2;
					var h = ($('#box_center').height() - $('#load').height()) / 2;
					
				},
				complete: function(){
					$("#load").remove();
				},
				error: function(){
					
					$("#box_center").html("<p class='center'>Desculpe, tente realizar a busca novamente.</p>");
				},
				success: function(data){

				$("#box_center").html("<p class='desc_cat'>Artigos</p>");

					var html = '<ul>';
					
					if($(data).find('artigos item url:first').text() != 0)
					{
						$(data).find('artigos item').each(function(i){
					
							var lnkAtu = $(this).find('url').text();
							var titAtu = $(this).find('titulo').text();
							var dtAtu = $(this).find('data').text();
						
							html += "<li class='gallery'><a href='artigos/" + lnkAtu + "'><span>" + dtAtu + "</span> - " + titAtu + "</a></li>";
						
						});
					}
					else
					{
						
						html+="<li class='gallery'>Nenhum resultado encontrado.</li>";
						
					}
					
					html += '</ul>';
					
					html += '<p class="desc_cat">Jogos</p>';
					
					html += '<ul>';
					
					if($(data).find('jogos item url').text() != 0)
					{
					
						$(data).find('jogos item').each(function(i){
					
							var lnkAtu = $(this).find('url').text();
							var titAtu = $(this).find('titulo').text();
						
							html += "<li class='gallery'><a href='jogos/" + lnkAtu + "'>" + titAtu + "</a></li>";
							
						});
					}
					else
					{
						
						html+="<li class='gallery'>Nenhum resultado encontrado.</li>";
						
					}	
					
					html += '</ul>';
					
					$("#box_center").append(html);
					
				}	
			});	
		}else if($(this).val().length > 0 && $(this).val().length < 2){
			
			$("#center1").html('<p>::ARTIGOS</p><ul><li>Nenhum resultado encontrado.</li></ul><p>::JOGOS</p><ul><li>Nenhum resultado encontrado.</li></ul>');
			
		}else if($(this).val().length == 0){ 
				
				$('#title_game').text(tit);
			}
			
		});	
		
	//----BUSCA DO USUÁRIO	
	
	//ESTADOS E CIDADES	
	$('#slcCid')
	.html('<option value="0">--Selecione estado--</option>')
	.attr('disabled','disabled');

	$('#slcEst').change(function(){
		
		if($(this).val() != 0){
			$.ajax({
				url: "server/php.class/manageEstCid.class.php",
				contentType: "application/x-www-form-urlencoded;charset=UTF-8",
				type: "POST",
				data: ({postEst:  $(this).val()}),
				async: true,
				beforeSend: function(){
					$('#slcCid')
						.html("<option id='slcCid'>Carregando...</option>");
				},
				complete: function(){
					$('#slcCid').removeAttr('disabled');
				},
				success: function(data){$('#slcCid').html(data);},
				error: function(){$('#slcCid').html('<option value="0">--Selecione estado--</option>').attr('disabled','disabled');}
			});
				
		}else{
			
			$('#slcCid')
			.html('<option value="0">--Selecione estado--</option>')
			.attr('disabled','disabled');
			
		}
	});
	//--ESTADOS E CIDADES		
	
	//COMENTÁRIO	
	$('#comment a').click(function(e){
		e.preventDefault();
		if($('#permCmt').val() != 'false'){
		
		if($(this).attr('href') == 'comentarArtigo')
		var tpComt = 'comentarioArtigo';
		
		else if($(this).attr('href') == 'comentarNoticia')
		var tpComt = 'comentarioNoticia';
		
		else var tpComt = 'comentarDestaque';
			
		$('#comment a').css({'display':'none'});
		
		 $('#comment').append('<a href="#" id="enviComment"></a><textarea id="txtareaComment" name="txtareaComment"></textarea><span id="cont"></span><br/>');
		 $('#txtareaComment').focus();
		 $('#enviComment').click(function(e){
		 e.preventDefault();

			$.ajax({
				url: "server/php.class/retornaDadosClasseAjax.php",
				dataType: "text",
				type: "POST",
				data: ({postAcao: 'comentario', codPost: $('#codPost').val(), codUsu: $('#codUsu').val(), postComment:  $('#txtareaComment').val(), tpCommt: tpComt}),
				async: true,
				beforeSend: function(){
					$("#box_center").append("<img src='img/loading.gif' id='load' />");
					var w = ($('#box_center').width() - $('#load').width()) / 2;
					var h = ($('#box_center').height() - $('#load').height()) / 2;
					$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
				},
				complete: function(){$('#load').remove();},
				success: function(data){ 
					if(data == 'true') window.location.reload(true); else jAlert('<p>Erro no sistema! Tente novamente mais tarde.</p>', ' ', function() {$.alerts.dialogClass = null;});
				},
				error: function(){jAlert('<p>Erro no sistema! Tente novamente mais tarde.</p>', ' ', function() {$.alerts.dialogClass = null;});}
			});
		});
		}else jAlert('<p>Faça login ou registre-se para comentar.</p>', ' ', function() {$.alerts.dialogClass = null;});
	});
	//--COMENTÁRIO	
	
	//CURTIR ARTIGO
	 $('.curtir').click(function(){
		var okCurt = $('#statusCurtir').val();
		var codCurt = $('#codCur').val();
		var codUsut = $('#codUsu').val();
		var codArtt = $('#codPost').val();
		
		//alert('Acao: ' + okCurt + 'Cod do curtimento: \n' + codCurt + "Cod do usuario escritor: \n" + codUsut +"\n Código do artigo: " + codArtt);
		//return false;
		$.ajax({
			url: "server/php.class/retornaDadosClasseAjax.php",
			dataType: "text",
			type: "POST",
			data: ({postAcao: 'curtir', codArt: codArtt, curtir: okCurt, codCur: codCurt, codUsu: codUsut}),
			async: true,
			beforeSend: function(){
				$("#box_center").append("<img src='img/loading.gif' id='load' />");
				var w = ($('#box_center').width() - $('#load').width()) / 2;
				var h = ($('#box_center').height() - $('#load').height()) / 2;
				$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
			},
			complete: function(){$('#load').remove();},
			success: function(data){ 	
				if(data == 'true'){
					if(okCurt == 'true'){
						window.location.reload(true);
					}else{
						$('#statusCurtir').val('true');
						window.location.reload(true);
					} 
				}else $(this).text("Erro!");},
			error: function(){alert("ERRO:" + data);$(this).text("Erro!");}
		});
	});
	 //CURTIR ARTIGO
	 
	 //BOTÃO RENASCER
	$('#btn_reborn').click(function(){
		if($('#flagCristal').val() == 'true')
		{
			jAlert('<p>Você tem certeza que deseja renascer?</p>', ' ', function(){
				$.ajax({
					url: "server/php.class/retornaDadosClasseAjax.php",
					dataType: "text",
					type: "POST",
					data: ({postAcao: 'renascer'}),
					async: true
				});
				window.location.reload(true);
			}, 'visible');
			
		}else{	
			$('.efeito_fade').append('<span class="hover"></span>');	
			$("span.hover").fadeIn(400).fadeOut(300);
			$('.efeito_fade').removeClass();
		}
	});
	//BOTÃO RENASCER
	
});