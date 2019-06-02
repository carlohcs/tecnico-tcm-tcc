/*
 *Autor: Carlos Henrique | http://www.twitter.com/carlohcs | http://www.facebook.com/carlohcs
 *Data: 01/07/2011
 *Descrição:Função criada para exibir um 'container' no meio da tela como espécie de alerta
 */
(function($){ 
	 
	//Definindo função 'divShow'
	$.containerShow = function(options){
		
		var file = ['include/include_sec/escreverArtigo.php','js/upload/uploadFoto.php','include/include_sec/sinalizar.php'];
				
		//Adicionando divs ao html
		$('body').append(
			'<div id="divBg"></div>' +
				'<div id="contentPop">' +
					'<div id="headerPop">' +
						'<div id="close"></div>' +
						'<div id="msgContentPop"></div>' +
					'</div>' +
					'<div id="contentPopVal"></div>' +
					'<div id="footerPop">' +
						'<div id="cntBtn">' +
							'<input type="button" value="" class="btnAction btnSave" id="save" /><input type="button" value=""  class="btnAction btnCanc" id="cancel" />' +
						'</div>' +	
					'</div>' + 
				'</div>'
		);
		
		$('#divBg')
			.css({width: '100%', height: '100%',position: 'fixed', top: 0, left: 0, zIndex: 9998, opacity: 0})
			.animate({opacity: 0.8}, 300);
		
		//Armazenando largura e altura da página para posicionamento
		var h = ($(window).height() - $('#contentPop').height()) / 2;
		var w = ($(window).width() - $('#contentPop').width()) / 2;
		
		$('#contentPop')
			.css({position: 'fixed', top: h, left: w, zIndex: 9998 })
			.stop().slideDown(300);
				
		$('#headerPop').css({height:50, marginBottom: 5});
		
		$('#contentPopVal').css({width: 970, height: 370, margin: '0 auto'});
		
		var typeEnv = "GET";
		var dataEnv = "";
		if(options.data){ dataEnv = options.data; typeEnv = "POST"; }
		
		$.ajax({
			url: file[options.file],
			type: typeEnv,
			data: {dados: dataEnv},	
			beforeSend: function(){
				$("#contentPopVal").html("<img src='img/loading.gif' id='load' />");var w = ($('#contentPopVal').width() - $('#load').width()) / 2;
				var h = ($('#contentPopVal').height() - $('#load').height()) / 2;$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
			},
			complete: function(){$("#load").remove();},
			error: function(){$("#contentPopVal").append(clone + "<p class='center'>Desculpe, erro no servidor. Contate o administrador.</p>");},
			success: function(data){$("#contentPopVal").append(data);}
		});
		
		$('#footerPop').css({height: 50, marginTop: 9});

		$('#msgContentPop')
			.css({fontSize: '24px',margin: '0 20px', paddingTop: 10, color: '#fff'})
			.slideDown(500);

		
		$('#close')
			.css({background: "url('img/pop/delClose.png')",backgroundPosition: '0 16px',	 position:'absolute', margin: '17px 950px'})
			.stop().slideDown(300);	
			
				
		//Definindo título do alerta
		$('#msgContentPop').text(options.title);
				
		
		$('#close,#cancel').click(function(){
			$('#msgContentPop').slideUp(500);
			$("#contentPop")
					.slideUp(500)
					.html('')
					.remove();
				$("#close").slideUp(500);
				$("#divBg")
					.animate({opacity: 0}, 500)
					.remove();	
		});
		
		//Verificando possibilidade de tecla (Esc)
		$('html').keydown(function(event){
			//Definindo variável para pegar o elemento que chama event
			if(event.which == 27){
				$('#msgContentPop').slideUp(500);
				$("#contentPop")
					.slideUp(500)
					.html('')
					.remove();
				$("#close").slideUp(500);
				$("#divBg")
					.animate({opacity: 0}, 500)
					.remove();	
			}
			if(event.which == 116){
				event.preventDefault();
			}
		});
	};
})(jQuery);