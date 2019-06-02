$(function(){
	$('#frmLoga').submit(function(){
		var login = $('#c_login').val();
		var senha = $('#c_senha').val();
		var vaLogin = /^[a-z0-9.-_]{6,12}/.test(login);
		var vaSenha = /^[\w]{6,12}/.test(senha);
		if(vaLogin == false){
			jAlert('Login Inválido!', ' ', function() {
				$.alerts.dialogClass = null;		
				$('#c_login').focus();
			});
			return false;
		}else if(vaSenha == false){
			jAlert('Senha Inválida!', ' ', function() {
				$.alerts.dialogClass = null;
				$('#c_senha').focus();
			});
			return false;
		}
		else
			return true;
	});
});