<?php
	header("Content-type: text/html; charset=iso-8859-1"); 
	include_once("../../server/php.class/sqlInstruction.class.php");
	$objSql = new sqlInstruction;
	
	$arrDados = explode("|",$_POST["dados"]); 
	$cmEnt = ($arrDados[0] == 'noticias') ? 'NOT' : 'ART'; 
	$conSql = $objSql->conexaoSql(); $objSql->defineEntidade("usuario, ".$arrDados[0]."");
	
	$objSql->selectSql("usuario.NOM_USU, {$arrDados[0]}.TIT_{$cmEnt}", "usuario.COD_USU = '{$arrDados[2]}' AND {$arrDados[0]}.COD_{$cmEnt} = '{$arrDados[1]}'","","",true);
	
	$tituloPost = ($arrDados[0] == 'noticias') ? $objSql->exibeArrayDados('titulo','noticia') : $objSql->exibeArrayDados('titulo','artigo');
	$objSql->encerraConexaoSql($conSql);
?>
<html>
	<head>
		<script type="text/javascript">
		var tipoSin = '<?php echo $arrDados[0]; ?>'; var codPostSin =  '<?php echo $arrDados[1]; ?>';
		var codUsuSin =  '<?php echo $arrDados[2]; ?>'; var codUsuSinndo = '<?php echo $arrDados[3]; ?>';
		var codCom =  '<?php echo $arrDados[4]; ?>';
		$(function() {
			$('#save').click(function(){
				var motivoSin = $('#slcSina option:selected').val();var clone = $('#cont_article').clone();
				$.ajax({
					url: "server/php.class/retornaDadosClasseAjax.php",
					type: "POST",
					data: {
						postAcao: 'sinalizar', tipo: tipoSin, codMotivo: motivoSin, 
						codPost:codPostSin , codUsuSinalizado: codUsuSin,
						codUsuSinalizando: codUsuSinndo ,codComentario: codCom
					},
					async: true,	dataType: 'text',
					beforeSend: function(){
						$("#write_article").html("<img src='img/loading.gif' id='load' />");
						var w = ($('#write_article').width() - $('#load').width()) / 2;
						var h = ($('#write_article').height() - $('#load').height()) / 2;
						$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
					},
					complete: function(){	$("#load").remove(); },
					error: function(){$("#write_article").html(clone + "<p class='center'>Desculpe, erro no servidor. Contate o administrador.</p>");},
					success: function(data){ 
						if(data == 1) $("#write_article").html('<p>Sinalização enviada.</p>');
						else $("#write_article").html(clone + "<p class='center'>Desculpe, erro no servidor. Contate o administrador.</p>");	
					}
					
				});
			});
		});					
		</script>	
	</head>
	<body>
	<div id="write_article">
		<div id="cont_article">
			<h3>Sinalizar: <span id="titPost"><?php echo $tituloPost; ?></span></h3>
			<p>Usuário a sinalizar: <span id="usuSina"><?php echo $objSql->exibeArrayDados('nome','usuario'); ?></span></p>
			<p><select id="slcSina">
				<option value="0">--Selecione motivo--</option>
				<option value="2">Difamação</option>
				<option value="1">Mal uso</option>
			</select></p>
		</div>	
	</div>	
	</body>
</html>