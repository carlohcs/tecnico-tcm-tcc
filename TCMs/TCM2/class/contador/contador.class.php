<?php
	function contador(){
		//Define a zona de hor�rio para S�o Paulo
		date_default_timezone_set('America/Sao_Paulo');
		//Array com arquivos
		$arr = array(0=>"contador.txt", 1=>"ipUser.txt");
		//Data da �ltima modifica��o do arquivo
		$dataModi = date("d M Y", filemtime($arr[1]));
		//Data Atual
		$dataAtual = date("d M Y");
		//Configura��es do contador
		$inserir1 = file($arr[0]);
		$abre1 = fopen($arr[0], "r+");
		//Configura��es do Ip
		$ipUser = $_SERVER["REMOTE_ADDR"];
		$inserir2 = file($arr[1]);
		$abre2 = fopen($arr[1], "r+");
		//Inser��o do contador
		$in = $inserir1[0]+1;
		//Se o ip que estiver no arquivo n�o for igual ao ip do usu�rio atual, salva
		if($inserir2[0] != $ipUser){
			fwrite($abre1, $in); 
			fwrite($abre2, $ipUser);
		}
		//Se o ip for o mesmo, mas a Data atual for maior que a de modifica��o do arquivo, salva 
		if($dataAtual > $dataModi){
			fwrite($abre1, $in); 
			fwrite($abre2, $ipUser);	
		}
		//Exibe acessos
		echo "<p>Acessos: ".$in."</p>";
		//echo "<p>Modificado em: ".date("d M Y H:i:s", filemtime($arr[1]))."</p>";
	}
	contador();
?>