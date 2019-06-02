<?php
class Login{
	function LogaUser(){
		if(isset($_POST['loga'])){
			//Recebe Login e Senha por POST
			$logUser = isset($_POST['login']) ? trim($_POST['login']) : FALSE;
			$senUser = isset($_POST['senha']) ? trim($_POST['senha']) : FALSE;
			if(empty($logUser) || empty($senUser)){
				echo "<p id='erro'>COMPLETE TODOS OS CAMPOS!</p>";
			}else{
				//Abre arquivo com usuários cadastrados
				$arrArq = file("class/confUser/users.txt");
				//Usuário, senha, nome e email começam como nulo
				$logOk = 0; $senOk = 0; $nomOk = 0; $emaOk = 0;
				for($i=0;$i<count($arrArq);$i++){
					$encontraLog = trim(substr($arrArq[$i], 6));
					$encontraSen = trim(substr($arrArq[$i], 7));
					//Se encontrar
					if($logUser == $encontraLog){ $logOk++; }
					if($senUser == $encontraSen){ $senOk++; break; }
				}	
				for($i=2;$i<count($arrArq);$i++){
					$encontraNom = trim(substr($arrArq[$i], 7));
					$encontraEma = trim(substr($arrArq[$i+1], 9));				
					if($encontraNom){ $nomOk++ ; } if($encontraEma){ $emaOk++; break;}
				}
				//Se não encontrar usuário
				if($logOk == 0){ echo "<span id='erro'>LOGIN INVÁLIDO!</span>"; }
				//Se não encontrar senha
				if($senOk == 0){ echo "<span id='erro'>SENHA INVÁLIDA!</span>"; }
				//Se encontrar os dois
				if($logOk > 0 && $senOk > 0){
					$_SESSION["logUser"] = $logUser;
					$_SESSION["nomUser"] = $encontraNom;
					$_SESSION["emaUser"] = $encontraEma;}
			}
		}
	}
	function Logout(){
		unset($_SESSION['logUser']);
		unset($_SESSION['nomUser']);
		unset($_SESSION['emaUser']);
		header('Location:http://localhost/pt-br/index.php');
	}
}
$login = new Login;
$login->LogaUser();
if(isset($_GET['get']) == 'logout'){ $login->Logout(); }				
?>				