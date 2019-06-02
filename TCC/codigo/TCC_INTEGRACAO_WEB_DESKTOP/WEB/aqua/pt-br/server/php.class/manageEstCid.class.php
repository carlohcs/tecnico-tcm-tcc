<?php
include_once('sqlInstruction.class.php');
class manageEstadoCidade extends sqlInstruction{
	
		function listaEstados($slc){
	
			$conSql = parent::conexaoSql();
			parent::defineEntidade("estados");

			$exSql = parent::selectSql("COD_ESTADO,SIGL_ESTADO,DESC_ESTADO", '', 'COD_ESTADO ASC', '',false);
		
			if($exSql != FALSE){
				
				while($linha = parent::fetch($exSql)){
					
					if($slc == "slc"){
						
						echo "<option value='".$linha['COD_ESTADO']."' name='".$linha['SIGL_ESTADO']."'>".$linha['DESC_ESTADO']."</option>";
					
					}
					
				}
				
				parent::encerraConexaoSql($conSql);
				
			}else{
			
				echo "<option>Erro em entidade.</option>";
				
			}
		
		}
		
		function listaCidades($slc,$codEst){
	
			$conSql = parent::conexaoSql();
			parent::defineEntidade("cidades");
			
			$exSql = parent::selectSql("DESC_CIDADE,COD_CIDADE", "COD_ESTADO = ".$codEst, 'DESC_CIDADE ASC', '',false);
						
			if($exSql != FALSE){
				
				while($linha = parent::fetch($exSql)){
					
					if($slc == "slc"){
						
						echo "<option value='".$linha['COD_CIDADE']."'>".$linha['DESC_CIDADE']."</option>";
						
					}
						
				}
					
				parent::encerraConexaoSql($conSql);
					
			}else{
			
				echo "<option>Erro em entidade.</option>";
				
			}
		
		}	
		
	}
	if(isset($_POST['postEst'])){
		$codEst = $_POST['postEst'];
		$obj = new  manageEstadoCidade;
		$obj->listaCidades('slc',$codEst);	
	}
	
?>	