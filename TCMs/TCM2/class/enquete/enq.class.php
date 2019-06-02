<?php
class Enquete{
	public $opcao, $arquivoArr, $tpOp, $ipUser, $checa,$sess,$sess2;
	function defineDados($opcao = array("Google", "Amigos", "Publicações", "Outros"),
	$arquivoArr = array(
	0=>"class/enquete/google.txt",
	1=>"class/enquete/amigos.txt",
	2=>"class/enquete/publicacoes.txt",
	3=>"class/enquete/outros.txt",
	4=>"<p id='ask_poll'>Como você conheceu o JOI&D?</p>",
	5=>"class/enquete/ipUser.txt")){
		//Define a zona de horário para São Paulo
		date_default_timezone_set('America/Sao_Paulo');
		$this->opcao = $opcao;
		$this->arquivoArr = $arquivoArr;
		$ipUser = $_SERVER["REMOTE_ADDR"];
		$this->ipUser = $ipUser;
	}
	function abreAr($arquivoInd){		
		$arquivoArr = array(
	0=>"class/enquete/google.txt",
	1=>"class/enquete/amigos.txt",
	2=>"class/enquete/publicacoes.txt",
	3=>"class/enquete/outros.txt",
	4=>"<p id='ask_poll'>Como você conheceu o JOI&D?</p>",
	5=>"class/enquete/ipUser.txt");
		
		$inserir = file($arquivoArr[$arquivoInd]);
		$abreAr = fopen($arquivoArr[$arquivoInd], "w");
		$insere = fwrite($abreAr, $inserir[0]+1); 
		if($insere){$msg = "Voto enviado.";}else{$msg = "Voto não enviado.";}
		echo "<p>".$msg."</p>";
		echo "<p><a href='$_SERVER[PHP_SELF]'>Voltar</a></p>";
	}
	function vota(){	
		$this->tpOp = isset($_POST['tpOp']) ? $_POST['tpOp'] : FALSE;
		$arquivo = file($this->arquivoArr[5]);
		if($this->tpOp != ""){		
			if($arquivo[0] != $this->ipUser){	
				$abreAr = fopen($this->arquivoArr[5], "w");
				$insere = fwrite($abreAr, $this->ipUser);
				$checa = TRUE;
				$_SESSION["acesso"] = time();
				$_SESSION["entrada"] = date('H:i:s');
			}else{
				$checa = FALSE;
				$dataModi = date("d M Y", filemtime("class/enquete/ipUser.txt"));
				$dataAtual = date("d M Y");
				if(isset($_SESSION["acesso"]) && isset($_SESSION["entrada"])){
					if((time() - $_SESSION["acesso"]) > 60 * 2) { 
						$abreAr = fopen($this->arquivoArr[5], "w");
						$insere = fwrite($abreAr, "0.0.0.0");
						$checa = TRUE;
						$_SESSION["acesso"] = time();
						$_SESSION["entrada"] = date('H:i:s');
					}
				}else if($dataAtual > $dataModi){
					$abreAr = fopen($this->arquivoArr[5], "w");
					$insere = fwrite($abreAr, "0.0.0.0");
					$checa = TRUE;
					$_SESSION["acesso"] = time();
					$_SESSION["entrada"] = date('H:i:s');
				}
			}	
			if($checa == TRUE){
				switch($this->tpOp){
					case '0':
						$enq = new Enquete; $enq->abreAr('0');
					break;
					case '1':
						$enq = new Enquete; $enq->abreAr('1');
					break;
					case '2':
						$enq = new Enquete; $enq->abreAr('2');
					break;							
					case '3':
						$enq = new Enquete; $enq->abreAr('3');
					break;
				}
			}else{
				//if(isset($_SESSION["entrada"])){
					echo "Você já votou.<br /> Hora do voto: ".$_SESSION["entrada"];
					echo "<br />Você poderá votar novamente em 2 minutos!";
					echo "<br /><a style:'margin-left:5px;' href='$_SERVER[PHP_SELF]'>Voltar</a>";
					
			}
		}else{	
			echo "Selecione uma opção.<br /><a style='margin-left:10px;' href='$_SERVER[PHP_SELF]'>Tentar novamente</a>";
			exit;
		}
	}
	function resultados(){
		//Pega os valores dos arquivos
		$valor1 = file($this->arquivoArr[0]); $valor2 = file($this->arquivoArr[1]); 
		$valor3 = file($this->arquivoArr[2]); $valor4 = file($this->arquivoArr[3]); 
		//Define o total de votos
		$total = $valor1[0] + $valor2[0] + $valor3[0] + $valor4[0];
		//Define porcentagem de cada opção
		$pcGoo = number_format($valor1[0] / $total * 100);
		$pcAmig = number_format($valor2[0] / $total * 100);
		$pcPubli = number_format($valor3[0] / $total * 100);
		$pcOut = number_format($valor4[0] / $total * 100);
		//Exibe os resultados
		echo "<p>TOTAL DE VOTOS: ".$total."</p>";
		echo "<p>Google: ".$pcGoo."%</p>";
		echo "<p>Amigos: ".$pcAmig."%</p>";
		echo "<p>Publicações: ".$pcPubli."%</p>";
		echo "<p>Outros: ".$pcOut."%</p>";
		echo "<p><a href='$_SERVER[PHP_SELF]'>Voltar</a></p>";
	}

	function get(){
		$voto = isset($_POST['frmVoto']) ? $_POST['frmVoto'] : FALSE;
		$resul = isset($_POST['frmResult']) ? $_POST['frmResult'] : FALSE;
		if($voto){$enq = new Enquete; $enq->defineDados(); $enq->vota();}
		if($resul){$enq = new Enquete; $enq->defineDados(); $enq->resultados();}
		if(!$resul && !$voto){$enq = new Enquete; $enq->defineDados(); $enq->exibeForm();}
	}	

	function exibeForm(){
	echo "<p id='t_poll'>Enquete</p>";
		echo "<p>".$this->arquivoArr[4]."</p>";
		echo "<form action=".$_SERVER['PHP_SELF']." method='POST' name='frmEn'>\n<ul>";
		while(list($key, $value) = each($this->opcao)){
			echo "<input type='radio' name='tpOp' value='$key' class='styled' /><li>".$value."</li>";
		}
		 echo "<div id='align_poll'><input id='votar' type='submit' name='frmVoto' value='Votar'/>";
		 echo "<input type='submit' id='result' name='frmResult' value='Resultado' /></div></ul>";
		 
		echo "</form>";
	}
}	
$enq = new Enquete;
$enq->get();
?>