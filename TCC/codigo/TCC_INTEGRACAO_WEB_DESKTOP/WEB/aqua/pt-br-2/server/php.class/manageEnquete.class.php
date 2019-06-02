<?php
class manageEnquete extends sqlInstruction
{
	
	public $codEnquete;
	
	function __construct($codEnquete)
	{
		
		$this->codEnquete = $codEnquete;
		
	}
	
	//Vota em uma enquete
	function votaEnquete($voto)
	{
	
	if($voto != false)
	{
		//Faz a verificação da opção do voto
		switch($voto)
		{
		
			case 1:
				$coluna = "PCT_ITN1_ENQ";
			break;
			case 2:
				$coluna = "PCT_ITN2_ENQ";
			break;
			case 3:
				$coluna = "PCT_ITN3_ENQ";
			break;
			case 4:
				$coluna = "PCT_ITN4_ENQ";
			break;
			
		}
		
		$conSql = parent::conexaoSql();
		parent::defineEntidade("enquete");
		
		$exSql = parent::updateSql("{$coluna} = {$coluna} + '1'", "COD_ENQ = '{$this->codEnquete}'");
		
		if($exSql == true) return true;
		
		else	return false;
			
	}
	else
	{
		return false;
	}
	}
	
	//Exibir Resultados da Enquete escolhida
	function resultadoEnquete()
	{
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade("enquete");

		//Busca os dados da enquete
		$exSql = parent::selectSql("TIT_ENQ,ITN1_ENQ,ITN2_ENQ,ITN3_ENQ,ITN4_ENQ,
		PCT_ITN1_ENQ,PCT_ITN2_ENQ,PCT_ITN3_ENQ,PCT_ITN4_ENQ", "COD_ENQ = '{$this->codEnquete}'", '', '',true);
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
		
		$total = (int) (parent::exibeArrayDados("valorOp1", "enquete") + parent::exibeArrayDados("valorOp2", "enquete") + parent::exibeArrayDados("valorOp3", "enquete") + parent::exibeArrayDados("valorOp4", "enquete"));
		
		$resultado1 = 0; $resultado2 = 0; $resultado3 = 0; $resultado4 = 0;
		
		//Realiza porcentagens
		if ($total > 0){
		
			$resultado1 = (int) ((parent::exibeArrayDados("valorOp1", "enquete") / $total) * 100);
			$resultado2 = (int) ((parent::exibeArrayDados("valorOp2", "enquete") / $total) * 100);
			$resultado3 = (int) ((parent::exibeArrayDados("valorOp3", "enquete") / $total) * 100);
			$resultado4 = (int) ((parent::exibeArrayDados("valorOp4", "enquete") / $total) * 100);
			
		}
			
		$form = "<p id='t_poll'>Enquete</p>";
		$form.= "<p id='text_poll'>Total de votos: {$total}</p>";
		$form.= "<ul id='poll_frm'>";
			$form.= "<li class='pad'>".parent::exibeArrayDados("opcao1", "enquete").": {$resultado1}%</li>";
			$form.= "<li class='pad'>".parent::exibeArrayDados("opcao2", "enquete").": {$resultado2}%</li>";
			$form.= "<li class='pad'>".parent::exibeArrayDados("opcao3", "enquete").": {$resultado3}%</li>";
			$form.= "<li class='pad'>".parent::exibeArrayDados("opcao4", "enquete").": {$resultado4}%</li>";
		$form.= "</ul>";
		//$form.= "<input type='submit' class='enqt2' id='back'>Voltar</a>";
		$form.= "<form method='post'><input type='submit' name='' value='Voltar' id='back' /></form><br />";
		echo $form;
		
	}

	//Listar a Enquete escolhida	
	function listaEnquete()
	{
		
		//Inicia conexao
		$conSql = parent::conexaoSql();
		parent::defineEntidade('enquete');
		

		//Busca os dados da enquete
		$exSql = parent::selectSql("TIT_ENQ,ITN1_ENQ,ITN2_ENQ,ITN3_ENQ,ITN4_ENQ", "COD_ENQ = '{$this->codEnquete}'", '', '',true);
		
		//Fecha Conexao
		parent::encerraConexaoSql($conSql);
		
		//Exibe a enquete formatada na tela
		$form = "<p id='t_poll'>Enquete</p>";
		$form.= "<p id='text_poll'>".parent::exibeArrayDados("titulo", "enquete")."</p>";
		$form.= "<form action='' method='POST' name='frmEn'>";
		$form.= "<ul id='poll_frm'>";
		$form.= "<li><input type='radio' name='tpOp' value='1' class='styled' />".parent::exibeArrayDados("opcao1", "enquete")."</li>";
		$form.= "<li><input type='radio' name='tpOp' value='2' class='styled' />".parent::exibeArrayDados("opcao2", "enquete")."</li>";
		$form.= "<li><input type='radio' name='tpOp' value='3' class='styled' />".parent::exibeArrayDados("opcao3", "enquete")."</li>";
		$form.= "<li><input type='radio' name='tpOp' value='4' class='styled' />".parent::exibeArrayDados("opcao4", "enquete")."</li>";
		$form.= "</ul>";
		$form.= "<input class='enqt2' id='vote' type='submit' name='frmVoto' value='Votar' />";
		$form.="<input type='submit' name='frmResult' value='Resultado' id='result' /><br />";
		//$form.= "<a class='enqt2' href='".$_GET['page']."/enquete/resultado' id='result' name='frmResult'>Resultado<a/>";
		$form.="</form>";
		echo $form;
		
	}	

}
?>