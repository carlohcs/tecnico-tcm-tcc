<?php
$hostname = "127.0.0.1";
$database = "joiandd";
$username = "root";
$password = "";
$conn = mysql_pconnect($hostname, $username, $password) or trigger_error(mysql_error(),E_USER_ERROR); 

include('JSON.php');
include('funcoes_red.php');
$result = array();

if (isset($_FILES['Filedata']) )
{	$file = $_FILES['Filedata']['tmp_name'];
	$error = false;
	$size = false;
	if (!is_uploaded_file($file) || ($_FILES['Filedata']['size'] > 2 * 1024 * 1024) )
	{
		$error = 'Fa&ccedil;a upload de arquivos menores que 2Mb!!! ';
	}
	elseif (!$error && !($size = @getimagesize($file) ) )
	{
		$error = 'Fa&ccedil;a o upload apenas de imagens, outros arquivos n&atilde;o s&atilde;o suportados.';
	}
	elseif (!$error && ($size[0] < 25) || ($size[1] < 25))
	{
		$error = 'Fa&ccedil;a o upload de uma imagem maior que 25px.';
	}
	else {

		$tmp_name = $_FILES['Filedata']['tmp_name'];
		$aux_tipo_imagem = $size['mime'];
			//// Definicao de Diretorios / 
            $diretorio = "img/usuarios/";
            
            ///// certifique que seu diretório tenha permissao para escrita (chmod 0777)
			if(!file_exists($diretorio)) {
                mkdir($diretorio);
            }
            if(!file_exists($diretorio_g)) {
                mkdir($diretorio_g);
            }
            if(!file_exists($diretorio_p)) {
                mkdir($diretorio_p);
            }
            
				// declarar as variaveis para as fotos
				// foto minuatura
					$tb_nome = "thumb_".date('dmy').time()."";		
					$larg_tb = 120;
					$altu_tb = 90;
				
            if ($aux_tipo_imagem == "image/jpeg") {				
				$nome_thumb = "$tb_nome.jpg";
                reduz_imagem_jpg($tmp_name, $larg_tb , $altu_tb , $diretorio_p.$nome_thumb);
            }         
            if ($aux_tipo_imagem == "image/gif") {
                $nome_thumb = "$tb_nome.gif";
                reduz_imagem_gif($tmp_name, $larg_tb , $altu_tb , $diretorio_p.$nome_thumb);
            }
            if ($aux_tipo_imagem == "image/png") {
                $nome_thumb = "$tb_nome.png";
                reduz_imagem_png($tmp_name, $larg_tb , $altu_tb , $diretorio_p.$nome_thumb);
            }
			// fim do redimensionamento e criacao das miniaturas ... 
	}

	if ($error) {
		$result['result'] = 'failed';
		$result['error'] = utf8_encode($error);
	}
	
	else
	{
		$result['result'] = 'success';
		$result['size'] = "Imagem enviada com sucesso.";
		
		// Grava informações no banco
		mysql_query("use $database");
		mysql_query("UPDATE usuario SET FT_USU = 'img/usuarios/$nome_thumb' WHERE COD_USU = '$_SESSION['sessaoUsuario']['codigo']'");
	}
 
}
else
{
	$result['result'] = 'error';
	$result['error'] = 'Arquivo ausente ou erro interno!';
}


			
/*if (!headers_sent() )
{
	header('Content-type: application/json');
}
 
echo json_encode($result);*/
echo '1'; 
?>