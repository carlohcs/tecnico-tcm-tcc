<?php session_start(); ?>
<html>
	<head>
		<base href="http://127.0.0.1:8080/TCC/aqua/pt-br/" />
		<script type="text/javascript" src="jquery.js"></script>
		<script type="text/javascript" src="js/upload/ajaxupload.3.5.js"></script>
		<script type="text/javascript">
		$(function() {
			var status=$('#status');

			new AjaxUpload($('#upload'), {

				// Arquivo que fará o upload
				action: 'js/upload/upload.php',
				//Nome da caixa de entrada do arquivo
				name: 'uploadfile',
				onSubmit: function(file, ext){
					if (! (ext && /^(jpg|png|jpeg|gif)$/.test(ext))){ 
						status.text('Somente JPG, PNG ou GIF são permitidas');
						return false;
					}
					status.text('Enviando...');
				},
				onComplete: function(file, response){
					//Limpamos o status
					status.text('');
					//Adicionar arquivo carregado na lista
					var resposta = response.split(";");
					if(resposta[0]=="success"){
						$('#cmp_up').html('<p text-align="center">Imagem enviada com sucesso.</p>');
						$('#ftUser,#ftUserBox,#user_img').attr('src',resposta[1]);
					} else{
						$('#cmp_up').append('<p text-align="center">Falha ao enviar, envie uma imagem com no máximo 2Mb.</p>');
					}

				}
			});
		});
		</script>
		<style>
#upload{
	margin:30px 200px; padding:15px;
	font-weight:bold; font-size:1.3em;
	font-family:Arial, Helvetica, sans-serif;
	text-align:center;
	background:#f2f2f2;
	color:#3366cc;
	border:1px solid #ccc;
	width:150px;
	cursor:pointer !important;
	-moz-border-radius:5px; -webkit-border-radius:5px;
}
.darkbg{
	background:#ddd !important;
}
#status{
	font-family:Arial; padding:5px; text-align: center;
}
ul#files{ list-style:none; padding:0; margin:0; }
ul#files li{ padding:10px; margin-bottom:2px; width:200px; float:left; margin-right:10px;}
ul#files li img{ max-width:180px; max-height:150px; }
.success{ background:#99f099; border:1px solid #339933; }
.error{ background:#f0c6c3; border:1px solid #cc6622; }       
</style>
	</head>
	<body>
	<div id="postFoto">
	
	<div id="ft_grnd" style="float: left;">
		
		<img src="<?php if($_SESSION['sessaoUsuario']['foto'] != '') echo $_SESSION['sessaoUsuario']['foto']; else echo 'img/login/user_default2.png'; ?>" width="61" height="57" id="ftUserBox"/>
		
	</div>
	<div id="cmp_up">
		<div id="upload" ><span>Upload File<span></div><span id="status" ></span>
		<ul id="files"></ul>
	</div>	
	</div>	
	</body>
</html>