<?php

class module{

	function getErrorsAlert()
	{
	
		if(isset($_GET['lgError'])){
		
			$pss = base64_decode($_GET['user']);$tpErro =  $_GET['lgError'];
			
			switch($tpErro)
			{
				case "login": 
					echo '<script>window.onload = function(){jAlert("Login Inv�lido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
				break;
				case "pass": 
					echo '<script>window.onload = function(){jAlert("Senha Inv�lida!", " ", function(){$.alerts.dialogClass = null;$("#c_login").val("'.$pss.'");$("#c_senha").focus(); })};</script>';
				break;
				case "logt":
					echo '<script>window.onload = function(){jAlert("Login Inv�lido!", " ", function(){$.alerts.dialogClass = null;$("#c_login").focus(); })};</script>';					 
				break;
			}
			
		}
		if(isset($_GET['escreverArtigoNegado'])) echo "<script>jAlert('<p>Voc� precisa estar logado para escrever artigos!</p>Fa�a login ou cadastra-se.', ' ', function(){	$.alerts.dialogClass = null;})</script>";
	}
}	
?>	
	