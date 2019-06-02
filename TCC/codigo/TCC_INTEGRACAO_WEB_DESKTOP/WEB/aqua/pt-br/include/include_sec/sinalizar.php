<?php
	header("Content-type: text/html; charset=iso-8859-1"); 
	include_once("../../server/php.class/sqlInstruction.class.php");
	$objSql = new sqlInstruction;
	
	$arrDados = explode("|",$_POST["dados"]); 
	if($arrDados[0] == 'noticias') $cmEnt = 'NOT'; else if($arrDados[0] == 'artigo') $cmEnt = 'ART'; else $cmEnt = 'DEST';
	 
	$conSql = $objSql->conexaoSql(); $objSql->defineEntidade("usuario, ".$arrDados[0]."");
	
	$objSql->selectSql("usuario.NOM_USU, {$arrDados[0]}.TIT_{$cmEnt}", "usuario.COD_USU = '{$arrDados[2]}' AND {$arrDados[0]}.COD_{$cmEnt} = '{$arrDados[1]}'","","",true);
	
	if($arrDados[0] == 'noticias') $tituloPost = $objSql->exibeArrayDados('titulo','noticia');
	else if($arrDados[0] == 'artigo') $tituloPost = $objSql->exibeArrayDados('titulo','artigo');
	else $tituloPost =  $objSql->exibeArrayDados('titulo','destaque');
	
	$objSql->encerraConexaoSql($conSql);
?>
<html>
	<head>
		<script type="text/javascript">
		var tipoSin = '<?php echo $arrDados[0]; ?>'; var codPostSin =  '<?php echo $arrDados[1]; ?>';
		var codUsuSin =  '<?php echo $arrDados[2]; ?>'; var codUsuSinndo = '<?php echo $arrDados[3]; ?>';
		var codCom =  '<?php echo $arrDados[4]; ?>';
		//alert("Tabela: " + tipoSin);
		$(function() {
			$('#contentPop').css({width:300, height: 120, paddingTop:30});
			$('#save').click(function(){
				var motivoSin = $('#slcSina option:selected').val();var clone = $('#cont_article').clone();
				/*alert("Tabela: " + tipoSin + "COD do post: " + codPostSin+ "Cod usu sinalizado: " + codUsuSin + "Cod do usu a sinalizar: " + codUsuSinndo +
				"Cod do comentario" + codCom + "Motivo: " + motivoSin);*/
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
						$("#cont_article").html("<img src='img/loading.gif' id='load' />");
						var w = ($('#cont_article').width() - $('#load').width()) / 2;
						var h = ($('#cont_article').height() - $('#load').height()) / 2;
						$('#load').css({position:'absolute',marginLeft: w,marginTop: h});
					},
					complete: function(){	$("#load").remove(); },
					error: function(){$("#cont_article").html("<p class='msg_error_serv'>Desculpe, erro no servidor. Contate o administrador.</p>");},
					success: function(data){ 
					alert(data);
						if(data == 1) $("#cont_article").html('<p>Sinalização enviada.Obrigado.</p>');
						else $("#cont_article").html("<p class='msg_error_serv'>Desculpe, erro no servidor. Contate o administrador.</p>");	
					}
					
				});
			});
		});					
		</script>	
	</head>
	<body>
		<?php	$conSql = $objSql->conexaoSql(); $objSql->defineEntidade('motivo_sinalizacao');$exSql = $objSql->selectSql("COD_MTV,DESC_MTV",'','','',false);?>
		<div id="cont_article">
			<h3>Sinalizar: <span id="titPost"><?php echo $tituloPost; ?></span></h3>
			<p>Usuário a sinalizar: <span id="usuSina"><?php echo $objSql->exibeArrayDados('nome','usuario'); ?></span></p>
			<p><select id="slcSina">
			<option value="0">--Selecione motivo--</option>
				<?php while($resp = $objSql->fetch($exSql)) echo "<option value='{$resp['COD_MTV']}'>{$resp['DESC_MTV']}</option>"; ?>
			</select></p>
			<?php $objSql->encerraConexaoSql($conSql);	?>
			<button id="save">Sinalizar</button>
		</div>	
	
	</body>
</html>