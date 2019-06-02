<?php 
header("Content-type: text/html; charset=iso-8859-1"); 	
include_once($_SERVER['DOCUMENT_ROOT'].'/TCC/aqua/pt-br/server/php.class/sqlInstruction.class.php');
include_once($_SERVER['DOCUMENT_ROOT'].'/TCC/aqua/pt-br/server/php.class/manageJogos.class.php');

?>
<html>
	<head>
		<script type="text/javascript">
		$(function() {
			$('#tinymce').tinymce({
				script_url : 'http://127.0.0.1:88/TCC/aqua/pt-br/js/tiny_mce/tiny_mce.js',
				theme : "simple",
				theme_simple_toolbar_location : "top"
			});
			$('#save').click(function(){
				var txtArt = $('#tinymce').tinymce().getContent();
				//alert($('#tituloArt').val() + "|" + $('#plChave').val() + "|" + $('#plChave').val() + $('#categoria :selected').val());	
				var clone = $('#cont_article').clone();
				$.ajax({
					url: "server/php.class/retornaDadosClasseAjax.php",
					type: "POST",
					data: {postAcao: 'escreveArtigo', 
					titulo: $('#tituloArt').val(), texto: txtArt, 
					plChave: $('#plChave').val(), 
					categoria: $('#plChave').val(),
					codCategoria: $('#categoria :selected').val()					
					},
					async: true,	dataType: "text",
					beforeSend: function(){
						$("#write_article").html("<img src='img/loading.gif' id='load' />");
						var w = ($('#write_article').width() - $('#load').width()) / 2;
						var h = ($('#write_article').height() - $('#load').height()) / 2;
						$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
					},
					complete: function(){	$("#load").remove(); },
					error: function(){
						jAlert('<p>Desculpe, erro no servidor. Contate o administrador.</p>', ' ', function(){$.alerts.dialogClass = null;});
						$('div').remove('#divBg');
					},
					success: function(data){ 
					if(data == 'true') {
						jAlert('<p>Artigo enviado com sucesso.</p>', ' ', function(){$.alerts.dialogClass = null;});
						$('div').remove('#divBg');
					}
					else {
							jAlert('<p>Desculpe, erro no servidor. Contate o administrador.</p>', ' ', function(){$.alerts.dialogClass = null;});
							$('div').remove('#divBg');
						}
					}	
				});
			});
					
			$('#cancel').click(function(){

				$('#msgContentPop').slideUp(500);
				$("#contentPop")
						.slideUp(500)
						.html('')
						.remove();
					$("#divBg")
						.animate({opacity: 0}, 500)
						.remove();	
			});
			
	var plChave = $("input[type=text][name=plChave]");
	//Propriedades para o campo Buscar
	plChave.css({'color':'#3f656c', 'font-style':'italic'});
	plChave.focus(function(){ plChave.css({'color':'#fff','font-style':'normal'}); if(($(this).val()) == "Separe por vírgula ex: palavra1, palavra2, palavra3"){ $(this).val("");} });
	plChave.blur(function(){ if(($(this).val()) == "Separe por vírgula ex: palavra1, palavra2, palavra3"){ $(this).val(""); } if(($(this).val()) == ""){ $(this).val("Separe por vírgula ex: palavra1, palavra2, palavra3"); plChave.css({'color':'#3f656c', 'font-style':'italic'});} });
		
	//Carrega para os dados inciais
	plChave.val("Separe por vírgula ex: palavra1, palavra2, palavra3");
			
		});					
		</script>	
	</head>
	<body>
	<div id="write_article">
		<div id="cont_article">
			<div id="headerPop">
				<div id="close"></div>
				<div id="msgContentPop"></div>
			</div>
			<div id="contentPopVal"></div>
			<p>Título: <input type="text" id="tituloArt" name="tituloArt" maxlength="100" size="60" /></p>
			<div id="art_msg">* Os artigos somente serão publicados caso sejam aprovadas pelos moderadores</div>
			<textarea style="width:506px; height:305px; overflow-x: hidden;"  rows="10" cols="10"id="tinymce" class="tinymce"></textarea>	
			<p id="keyword">Palavras-Chave: <input type="text" maxlength="60" id="plChave" value="" name="plChave"/></p>
			<p id="cat_art">Categoria: 
			<?php
				$objJogos = new manageJogos;
				$cate = $objJogos->listaCategoria(false);
				$jogosCate = $objJogos->listaJogosCategoria(false);

				echo '<select id="categoria" name="categoria">';
				for($i=0;$i<count($cate['codCategoria']);$i++)
				{
					echo "<option value=".$cate['codCategoria'][$i].">".$cate['descricaoCategoria'][$i]."</option>";
				}
				//echo "<option value='4'>Outros</option>";
				echo '</select>';
			?></p>
			<div id="footerPop">
				<div id="cntBtn">
					<input type="button" value="" class="btnAction btnSend" id="save" />
					<input type="button" value=""  class="btnAction btnCanc" id="cancel" />
				</div>
			</div>
		</div>	
	</div>	
	
	</body>
</script>
</html>