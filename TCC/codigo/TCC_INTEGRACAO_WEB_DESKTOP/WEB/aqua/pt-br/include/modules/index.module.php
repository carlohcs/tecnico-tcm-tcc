<?php

class module{

	function getErrorsAlert()
	{
	
		if(isset($_GET['lgError'])){
		
			$pss = base64_decode($_GET['user']);$tpErro =  $_GET['lgError'];
			
			switch($tpErro)
			{
				case "login": 
					echo '<script>window.onload = function(){jAlert("Login Inválido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
				break;
				case "pass": 
					echo '<script>window.onload = function(){jAlert("Senha Inválida!", " ", function(){$.alerts.dialogClass = null;$("#c_login").val("'.$pss.'");$("#c_senha").focus(); })};</script>';
				break;
				case "logt":
					echo '<script>window.onload = function(){jAlert("Login Inválido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
				break;
			}
			
		}
		if(isset($_GET['escreverArtigoNegado'])) echo "<script>jAlert('<p>Você precisa estar logado para escrever artigos!</p>Faça login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";
	}
}	
?>	
	