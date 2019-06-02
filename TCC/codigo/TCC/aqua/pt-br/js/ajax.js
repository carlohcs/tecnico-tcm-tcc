$(function(){
	var flagAcao = true;
	var flagAcaoBtn = true;
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
				$("#bg_list_article").append("<p class='center'>Desculpe, página não encontrada no servidor. Contate o administrador.</p>");
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
	var clone = $("#box_center").clone(); var tit = $('#title_game').text();
	$('#c_search').keydown(function(){
		$('#title_game').text("Busca");
		if($(this).val().length >= 3)
		{
			$.ajax({
				url: "server/php.class/retornaDadosClasseAjax.php",
				type: "POST",
				data: {postAcao: 'buscaPalChave', valorBusca: $(this).val()},
				async: true,
				dataType: "text",
				beforeSend: function() {
					$("#box_center").html("<img src='img/loading.gif' id='load' />");
					var w = ($('#box_center').width() - $('#load').width()) / 2;
					var h = ($('#box_center').height() - $('#load').height()) / 2;
					$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
				},
				complete: function(){
					$("#load").remove();
				},
				error: function(){
					$("#box_center").html("<p class='center'>Desculpe, tente realizar a busca novamente.</p>");
				},
				success: function(data){
					$("#box_center").html('<p>::Artigos::</p><ul>' + data + '</ul><p>::Jogos::</p>');
				}	
			});	
		}else if($(this).val().length > 0 && $(this).val().length <= 2){
			//$("#bg1_menu").html('');
			//$('#bg1_menu').load("include/center.php");
			$("#center1").html('<p>Nenhum Artigo/Notícia encontrada.</p>');
		}else if($(this).val().length == 0){
			$("#box_center").html(clone);
			$('#title_game').text(tit);
		}
		});	
});
	//$('#c_search').leave(function(){ $("#bg1_menu").html(clone); });