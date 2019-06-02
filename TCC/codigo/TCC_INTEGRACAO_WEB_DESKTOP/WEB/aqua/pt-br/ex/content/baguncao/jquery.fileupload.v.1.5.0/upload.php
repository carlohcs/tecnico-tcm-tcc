<?php
// JQuery File Upload Plugin v1.5.0 by RonnieSan - (C)2009 Ronnie Garcia
if (!empty($_FILES)) {
	$tempFile = $_FILES['Filedata']['tmp_name'];
	$targetPath = 'http://127.0.0.1:8080/TCC/aqua/pt-br/' . $_GET['folder'];
		
	move_uploaded_file($tempFile,$targetPath);
}
echo '1';
?>