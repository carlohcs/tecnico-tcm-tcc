<?php header("Content-type: text/html; charset=iso-8859-1"); ?>
<html>
	<head>
		<script type="text/javascript">
		$(function() {
			$('#tinymce').tinymce({
				script_url : 'http://127.0.0.1:8080/TCC/aqua/pt-br/js/tiny_mce/tiny_mce.js',
				theme : "simple",
				theme_simple_toolbar_location : "top",
				width: '100px'
			});
			$('#save').click(function(){
				
				var txtArt = $('#tinymce').tinymce().getContent();
				
				var clone = $('#cont_article').clone();
				$.ajax({
					url: "server/php.class/retornaDadosClasseAjax.php",
					type: "POST",
					data: {postAcao: 'escreveArtigo', titulo: $('#tituloArt').val(), texto: txtArt, 
					plChave1: $('#plChave1').val(),plChave2: $('#plChave2').val(),plChave3: $('#plChave3').val() },
					async: true,	dataType: "text",
					beforeSend: function(){
						$("#write_article").html("<img src='img/loading.gif' id='load' />");
						var w = ($('#write_article').width() - $('#load').width()) / 2;
						var h = ($('#write_article').height() - $('#load').height()) / 2;
						$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
					},
					complete: function(){	$("#load").remove(); },
					error: function(){$("#write_article").append(clone + "<p class='center'>Desculpe, erro no servidor. Contate o administrador.</p>");},
					success: function(data){	alert(data); if(data == 'true') $("#write_article").html('<p>Artigo enviado com sucesso.</p>'); 
					else $("#write_article").append(clone + "<p class='center'>Desculpe, erro no servidor. Contate o administrador.</p>");	}
				});
			});
		});					
		</script>	
	</head>
	<body>
	<div id="write_article">
		<div id="cont_article">
			<h3>TÍTULO: <input type="text" id="tituloArt" malength="100" size="60" /></h3>
			<textarea style="width: 100%; height: 330px;" id="tinymce" class="tinymce"></textarea>	
			<p>Palavras-Chave: <input type="text" maxlength="10" id="plChave1" /><input type="text" maxlength="10" id="plChave2" />
			<input type="text" maxlength="10" id="plChave3" /></p>
		</div>	
	</div>	
	</body>
</script>
</html>